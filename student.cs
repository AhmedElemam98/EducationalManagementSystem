using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_management_system
{
    class student:member
    {
        public static List<string> usersname = new List<string>();
        public static List<string> userspassword = new List<string>();
        public static List<string> usersemail = new List<string>();
        public static List<string> userscode = new List<string>();
        public static IList<student> usersobjects = new List<student>();
        public IList<course>user_courses=new List<course>();
        private IList<course> un_registered_courses = new List<course>();
        public IList<course> Un_registered_courses
        {
            set
            {
                this.un_registered_courses = value;

            }
            get
            {
               
                //To check that courses student doesn't registered in
                if (this.user_courses.Count != course.courses.Count)
                {
                    
                    for (int i = 0; i < course.courses.Count; i++)
                    {
                        bool z = false;
                        for (int y = 0; y < user_courses.Count; y++)
                        {
                            if (this.user_courses[y] == course.courses[i])
                            {
                                z = true;
                                break;
                            }

                        }
                        if (z == false)
                        {
                            //Add course if really isn't in un_registered_course
                            if(!un_registered_courses.Contains(course.courses[i]))
                            {
                            this.un_registered_courses.Add(course.courses[i]);
                            }
                        }
                    }
                }
               
                return this.un_registered_courses;
            }
        }





        /*if student is found return index of it ,if not ask user
          if he want to relogin or go to first page of program*/
        public static int login()
        {
            int index = 0;
            Console.WriteLine("\nPlease,enter your username and password:");
            student member_object = new student();
            Console.Write("\t \t 1- username:");
            member_object.Username = Console.ReadLine();
            Console.Write("\t \t 1- password:");
            member_object.Password = Console.ReadLine();
            for (int i = 0; i < student.usersname.Count; i++)
            {

                if (student.usersname[i] == member_object.Username)
                {
                    if (student.userspassword[i] == member_object.Password)
                    {
                        //if user is found
                        Console.WriteLine("\n\t\tWelcome {0} .You are logged in \n", usersname[i]);
                        index = i;
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
                if (choose == 1)
                {
                    index = student.login();
                    return index;
                }
                else if (choose == 2)
                {
                    student forgetten_stu = new student();
                    Console.WriteLine("\nPlease enter your email and code you remember:-");
                    Console.Write("\t \t Email:");
                    forgetten_stu.Email = Console.ReadLine();
                    Console.Write("\t \t Code:");
                    forgetten_stu.Code = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < usersemail.Count; i++)
                    {

                        if (forgetten_stu.Email == usersemail[i])
                        {
                            if (forgetten_stu.Code == userscode[i])
                            {
                                Console.WriteLine("\n Your username is:{0}", usersname[i]);
                                Console.WriteLine(" Your Password is:{0}", userspassword[i]);

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
                else if (choose == 3)
                {
                    Console.Clear();
                    Program.Main();
                    break;
                }
                else
                {
                    Console.Write("\t \t Invalid value .. please,renter choise[1-2]: ");
                    c = false;
                }
            }
            while (c == false);
            Program.Main();//if(choose==2);
            return 0;
        }



        public static int signup()
        {
            student new_user = new student();
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

        public static void after_login(int index_of_student)
        {
            Console.WriteLine("Please make achoise:-");
            Console.WriteLine("\t \t 1- Register in course");
            Console.WriteLine("\t \t 2- List my courses");
            Console.WriteLine("\t \t 3- view course");
            Console.WriteLine("\t \t 4- Grades Report");
            Console.WriteLine("\t \t 5- Logout");
            Console.Write("\t \t please,enter choise[1-5]: ");
            int choise = -1;
            bool z = false;
            do
            {
                z = int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                        //Register in course
                    case 1:
                        {
                            Regiter_in_course(index_of_student);
                           // Program.Main();
                            z = true;
                            break;
                        }
                    //List my courses
                    case 2:
                        {
                            list_my_courses(index_of_student);
                            z = true;
                            break;
                        }
                    //view course
                    case 3:
                        {
                            view_course(index_of_student);
                            z = true;
                            break;
                        }
                    //Grades Report
                    case 4:
                        {
                            z = true;
                            break;
                        }
                     //logout
                    case 5:
                        {

                            //Console.Clear();
                            //Program.Main();
                            z = true;
                            break;
                        }
                     //if enter number out of[1-5]
                    default:
                        {
                            z = false;
                            break;
                        }

                }
                if (z == false) Console.Write("\t \t In valid value..please,renter choise[1-5]: ");
            }
            while (z == false);
        }




        static void list_my_courses(int index_of_student)
        {
            int count_of_courses = usersobjects[index_of_student].user_courses.Count();

            if (count_of_courses > 0)
            {
                Console.WriteLine("\nYour have {0} courses:-", count_of_courses);
                for (int i = 0; i < count_of_courses; i++)
                {
                    Console.WriteLine("\t \t {0}) {1} -Code {2}", i + 1, usersobjects[index_of_student].user_courses[i].name, usersobjects[index_of_student].user_courses[i].code);
                }
            }
            else
            {
                Console.WriteLine("\n\t \tYou haven't registerd in any course");
            }
            Console.WriteLine();

        }





        static void Regiter_in_course(int index_of_student)
        {
            
            //if student has registered in all courses
            if (usersobjects[index_of_student].Un_registered_courses.Count == 0)
            {
                

                  Console.WriteLine("\n\t \tYou have registerd in all courses");
            }
            else
 
            {
                Console.WriteLine("\nplease choose course:");
                
                for (int y = 0; y < usersobjects[index_of_student].Un_registered_courses.Count; y++)
                {

                    Console.WriteLine("\t \t {0}-course {1} code {2}", y + 1, usersobjects[index_of_student].Un_registered_courses[y].name, usersobjects[index_of_student].un_registered_courses[y].code);
                }
                
                Console.Write("\t \t please,enter choise[1-{0}]: ", usersobjects[index_of_student].un_registered_courses.Count);
                
                int choise = -1;
                bool z = false;
                z = int.TryParse(Console.ReadLine(), out choise);
                while (z == false || choise > usersobjects[index_of_student].un_registered_courses.Count || choise <= 0) 
                {
                    Console.Write("\t \t In valid..please,renter choise[1-{0}]: ", usersobjects[index_of_student].Un_registered_courses.Count);
                    z = int.TryParse(Console.ReadLine(), out choise);
                }
                Console.WriteLine(usersobjects[index_of_student].un_registered_courses.Count);
                //Add course to student's courses&Remove it from un registered courses
                usersobjects[index_of_student].user_courses.Add(usersobjects[index_of_student].Un_registered_courses[choise - 1]);
                usersobjects[index_of_student].Un_registered_courses[choise - 1].students_of_course.Add(usersobjects[index_of_student]);
                usersobjects[index_of_student].Un_registered_courses.RemoveAt(choise - 1);
               
                
            }
        }


        static void view_course(int index_of_student)
        {
            //static void (list_my_courses)with edition in code to take input
            int count_of_courses = usersobjects[index_of_student].user_courses.Count;

            if (count_of_courses > 0)
            {
                Console.WriteLine("\nPlease choose one of your {0} courses you want to view :-", count_of_courses);
                for (int i = 0; i < count_of_courses; i++)
                {
                    Console.WriteLine("\t \t {0}) {1} -Code {2}", i + 1, usersobjects[index_of_student].user_courses[i].name, usersobjects[index_of_student].user_courses[i].code);
                }
                bool z = false;
                int result = -1;

                do
                {
                    Console.Write("\t \t Please make choise [1-{0}]:", count_of_courses);
                    z = int.TryParse(Console.ReadLine(), out result);
                }
                while (z == false || result <= 0 || result > count_of_courses);

                //index_of_Course To view

                int index_of_course = result - 1;
                Console.WriteLine("\n\tCourse {0} with code {1} - taught by doctor {2}",usersobjects[index_of_student].user_courses[index_of_course].Name,usersobjects[index_of_student].user_courses[index_of_course].Code,usersobjects[index_of_student].user_courses[index_of_course].doctor_of_course.Username);

                //if course has Assignments
                if (usersobjects[index_of_student].user_courses[index_of_course].course_assignments.Count > 0)
                {
                    Console.WriteLine("\n\tCourse has {0} assignment(s)", usersobjects[index_of_student].user_courses[index_of_course].course_assignments.Count);
                    for (int i = 0; i < usersobjects[index_of_student].user_courses[index_of_course].course_assignments.Count; i++)
                    {

                        Console.WriteLine("\tAssignment {1} {2} - {3} / {4} ");
                    }
                }
                else
                {

                    Console.WriteLine("\tCourse has no assignment yet");
                }













            }
            else
            {
                Console.WriteLine("\n\t \tYou haven't registerd in any course");
            }
            Console.WriteLine();
        
        
        
        }

        
            




    }
}
