using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;

namespace Educational_management_system
{
    class doctor:member
    {
        public static List<string> usersname = new List<string>();
        public static List<string> userspassword = new List<string>();
        public static List<string> usersemail = new List<string>();
        public static List<string> userscode = new List<string>();
        public static IList<doctor> usersobjects = new List<doctor>();
        public  IList<course> user_courses = new List<course>();
        

        public doctor()
        {
        }


        /*if doctor is found return index of it ,if not ask user
                 if he want to relogin or go to first page of program*/
        public static int login()
        {
            int index = 0;
            Console.WriteLine("\nPlease,enter your username and password:");
            doctor member_object = new doctor();
            Console.Write("\t \t 1- username:");
            member_object.Username = Console.ReadLine();
            Console.Write("\t \t 1- password:");
            member_object.Password = Console.ReadLine();
            for (int i = 0; i < doctor.usersname.Count; i++)
            {

                if (doctor.usersname[i] == member_object.Username)
                {
                    if (doctor.userspassword[i] == member_object.Password)
                    {
                        //if user is found 
                        index = i;
                        Console.WriteLine("\n\t\tWelcome {0} .You are logged in \n", usersname[i]);
                        return index;
                    }
                }
            }
            //if user isn't found 
            Console.WriteLine("\t \t Error in username or password");
            Console.WriteLine("\nPlease make achoise:-");
            Console.WriteLine("\t \t 1- Re_enter username and password");
            Console.WriteLine("\t \t 2- Forget you username or password ");
            Console.WriteLine("\t \t 3- Back to first page");
            Console.Write("\t \t please,enter choise[1-3]: ");
            int choose = 0;
            bool c = true;
            do
            {
                c = int.TryParse(Console.ReadLine(), out choose);
                //Re_enter username and password
                if (choose == 1)
                {
                    index=doctor.login();
                    return index;

                }
                    //If Forget user or password ask for email&code if they are correct 
                    //print username&password ..else ask him if he want to back or exit
                else if (choose == 2)
                {
                   
                    doctor forgetten_doc = new doctor();
                    Console.WriteLine("\nPlease enter your email and code you remember:-");
                    Console.Write("\t \t Email:");
                    forgetten_doc.Email = Console.ReadLine();
                    Console.Write("\t \t Code:");
                    forgetten_doc.Code = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < usersemail.Count; i++)
                    {
                        
                        if (forgetten_doc.Email == usersemail[i])
                        { 
                        if(forgetten_doc.Code==userscode[i])
                        {
                            Console.WriteLine("\n Your username is:{0}", usersname[i]);
                            Console.WriteLine(" Your Password is:{0}", userspassword[i]);

                            Console.WriteLine("\nPlease make achoise:-");
                            Console.WriteLine("\t \t 1- Back to first page");
                            Console.WriteLine("\t \t 2- Shut down System");
                            Console.Write("\t \t please,enter choise[1-2]: ");

                            int choise=0;
                            bool z = false;
                            do
                            {
                                z = false;
                                z = int.TryParse(Console.ReadLine(), out choise);
                                switch (choise)
                                {
                                    case 1:
                                        {
                                            z = true;//go to main()
                                            break;
                                            
                                        }
                                    case 2:
                                        {
                                            Environment.Exit(0);
                                            break;
                                        }
                                }
                                if (z == false) Console.Write("\t \t In valid value..please,renter choise[1-2]: ");
                                
                            }
                            while (z == false);
                            found = true;
                            break;
                        }
                        }
                    }
                    //if found go to main()
                    if (found == true)
                    {
                        Console.Clear();
                        Program.Main();
                    }
                        //if Error in email&code
                    else
                    {
                        Console.WriteLine("\t \t Error in your email or code ");
                        Console.WriteLine("\nPlease make achoise:-");
                        Console.WriteLine("\t \t 1- Back to first page");
                        Console.WriteLine("\t \t 2- Shut down System");
                        Console.Write("\t \t please,enter choise[1-2]: ");
                        int choise = 0;
                        bool z = false;
                        do
                        {
                            z = false;
                            z = int.TryParse(Console.ReadLine(), out choise);
                            switch (choise)
                            {
                                case 1:
                                    {
                                        z = true;//go to main()
                                        break;

                                    }
                                case 2:
                                    {
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            if (z == false) Console.Write("\t \t In valid value..please,renter choise[1-2]: ");
                            
                        }
                        while (z == false);
                        Console.Clear();
                        Program.Main();
                    
                    }

                
                }
                    //if he want to exit
                else if (choose == 3)
                {
                    Console.Clear();
                    //Program.Main();
                    break;
                }

                else
                {
                    Console.Write("\t \t Invalid value .. please,renter choise[1-2]: ");
                    c = false;
                }
            }
            while (c == false);
            Program.Main();//if(choose==2||3);
            return 0;
        }


        public static int signup()
        {
            doctor new_user = new doctor();
            Console.WriteLine("\nPlease,enter username:");
            Console.Write("\t \t username:");
            new_user.Username = Console.ReadLine();
            Console.WriteLine("\nPlease,enter password:");
            Console.Write("\t \t password:");
            new_user.Password = Console.ReadLine();
            Console.WriteLine("\nPlease,enter your email:");
            Console.Write("\t \t email:");
            new_user.Email = Console.ReadLine();
            Console.WriteLine("\nFor more security..enter code you will use if you forget your account:");
            Console.Write("\t \t code:");
            new_user.Code = Console.ReadLine();

            //Adding user in system database
            usersobjects.Add(new_user);
            usersname.Add(new_user.Username);
            userspassword.Add(new_user.Password);
            usersemail.Add(new_user.Email);
            userscode.Add(new_user.Code);

            //surely,that's user will be stored in the last index of userobjects(count-1)
            int num = usersobjects.Count;
            return num - 1;

        }



        public static void after_login(int index_of_doctor)
        {
            Console.WriteLine("Please make achoise:-");
            Console.WriteLine("\t \t 1- Create course"); 
            Console.WriteLine("\t \t 2- List my courses");
            Console.WriteLine("\t \t 3- view course");
            Console.WriteLine("\t \t 4- Logout");
            Console.Write("\t \t please,enter choise[1-4]: ");
            ////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////
            create_course(index_of_doctor);
            view_course(index_of_doctor);

        }


        public static void create_course(int index_of_doctor)
        {
            course c = new course();
            Console.WriteLine("\n\nplease enter data of your new course:");
            Console.Write("\t \t 1- name:");
            c.Name = Console.ReadLine();
            Console.Write("\t \t 2- code:");
            c.Code = Console.ReadLine();
            c.doctor_of_course = usersobjects[index_of_doctor];
            course.courses.Add(c);
            usersobjects[index_of_doctor].user_courses.Add(course.courses.Last());
            Console.WriteLine("\t Course {0} with code {1} has been created successfully \n",c.Name,c.Code);
        }


        public static void list_courses(int index_of_doctor)
        {
            if (usersobjects[index_of_doctor].user_courses.Count != 0)
            {
                Console.WriteLine("\n \nYour Courses are:");
                for (int i = 0; i < usersobjects[index_of_doctor].user_courses.Count; i++)
                    Console.WriteLine("\t \t . Course {0} code {1} ", usersobjects[index_of_doctor].user_courses[i].Name, usersobjects[index_of_doctor].user_courses[i].Code);
            }
            else
                Console.WriteLine("\n \n\t\t You haven't created any course yet");
        }


        public static void view_course(int index_of_doctor)
        {
            //List Courses
            if (usersobjects[index_of_doctor].user_courses.Count == 0)
            {
                Console.WriteLine("\n \n\t\t You haven't created any course yet");

            }
            else
            {
                bool z = false;

                int index_of_course = -1;

                Console.WriteLine("\n \nYour Courses are:");
                for (int i = 0; i < usersobjects[index_of_doctor].user_courses.Count; i++)
                    Console.WriteLine("\t \t {0} - Course {1} code {2} ",i+1, usersobjects[index_of_doctor].user_courses[i].Name, usersobjects[index_of_doctor].user_courses[i].Code);

                Console.Write("\t \t Please,Enter index of course you want to view [1-{0}]:", usersobjects[index_of_doctor].user_courses.Count);
                z = int.TryParse(Console.ReadLine(), out index_of_course);
                while (z == false || index_of_course < 1 || index_of_course > usersobjects[index_of_doctor].user_courses.Count)
                {
                    Console.Write("\t \t Invalid..Re-enter index of course you want to view [1-{0}]:", usersobjects[index_of_doctor].user_courses.Count);
                    z = int.TryParse(Console.ReadLine(), out index_of_course);
                }

                //index_of_course -1     ---->We use it always here

                Console.WriteLine("\nPlease make achoise:-");
                Console.WriteLine("\t \t 1- List Assignments");
                Console.WriteLine("\t \t 2- Create Assignment");
                Console.WriteLine("\t \t 3- view Assignment");
                Console.WriteLine("\t \t 4- Back");
                Console.Write("\t \t please,enter choise[1-4]: ");

                assignment.create_Assignment(index_of_doctor, index_of_course-1);
                assignment.list_assignment(index_of_doctor, index_of_course - 1);
                assignment.view_assignment(index_of_doctor, index_of_course - 1);

                

            }
        }




        
    }
}
