using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_management_system
{

    class Program
    {
        
        static int ask_of_member()
            //return 1 if member is doctor and 2 if student
        {

            Console.WriteLine("\nYou are doctor or student?:");
            Console.WriteLine("\t \t 1- doctor");
            Console.WriteLine("\t \t 2- student");
            Console.Write("\t \t please,enter choise[1-2]: ");
            int choise=0;
            bool z = false;
            do
            {

                z=int.TryParse(Console.ReadLine(),out choise);
                if(choise==1)
                {
                    return 1;
                   
                }
                if(choise==2)
                {
                    return 2;
                 
                }
                Console.Write("\t \t In valid value..please,renter choise[1-2]: ");
            }
            while(z==false);
            return 3;
        }
       
        public static void Main()
        {

            course c1 = new course();
            c1.name = "A";
            c1.Code = "15";

            course c2 = new course();
            c2.name = "B";
            course c3 = new course();
            c3.name = "C";
            course c4 = new course();
            c4.name = "D";
            course c5 = new course();
            c5.name = "E";
            course.courses.Add(c1);
            course.courses.Add(c2);
            course.courses.Add(c3);
            course.courses.Add(c4);
            course.courses.Add(c5);
            



            doctor ff = new doctor();
            ff.Username = "Ahmed";
            ff.Password = "ahmedelemam200";
            c1.doctor_of_course = ff;


            doctor.usersname.Add(ff.Username);
            doctor.userspassword.Add(ff.Password);
            doctor.userscode.Add("123");
            doctor.usersemail.Add("123@123");
            doctor.usersobjects.Add(ff);

            /*
            c1.doctor_of_course = ff;
            ff.user_courses.Add(c1);
            */


            
            
            doctor f = new doctor();
            f.Username = "Ahmed0";
            f.Password = "ahmedelemam200";
            
            doctor.usersname.Add(f.Username);
            doctor.userspassword.Add(f.Password);
            doctor.usersobjects.Add(f);
            /*
            List<int> ls = new List<int>();
            ls.Add(5);
            ls.Add(6);
            List<int> lis = new List<int>();
            lis.Add(5);
            lis.Add(6);
            List<int> lss =ls.
            */
       
          
            student rr = new student();
            rr.Username = "Ahmed";
            rr.Password = "ahmedelemam200";
            student.usersname.Add(rr.Username);
            student.userspassword.Add(rr.Password);
            student.usersobjects.Add(rr);

            
            rr.user_courses.Add(course.courses[0]);
            rr.user_courses.Add(course.courses[2]);
            
            


            
            student r = new student();
            r.Username = "Ahmed0";
            r.Password = "ahmedelemam200";
            student.usersname.Add(r.Username);
            student.userspassword.Add(r.Password);
            student.usersobjects.Add(r);


            
            Console.WriteLine("\t \t \t \t Welcome!..");
            Console.WriteLine("Please make achoise:-");
            Console.WriteLine("\t \t 1- login");
            Console.WriteLine("\t \t 2- signup");
            Console.WriteLine("\t \t 3- Shutdown system");
            Console.Write("\t \t please,enter choise[1-3]: ");
            int choise;
            bool z = false;
            do
            {
                z = int.TryParse(Console.ReadLine(), out choise);
                //if login()
                if (choise == 1)
                {
                    int member_type = ask_of_member();
                    switch (member_type)
                    {
                        case 1://if member is doctor
                            {
                               int index_of_doctor=doctor.login();
                               doctor.after_login(index_of_doctor); 
                               
                             
                                break;
                            }
                        case 2://if member is student
                            {
                                int index_of_student = student.login();
                                student.after_login(index_of_student);
                                /*
                                Console.WriteLine("Please make achoise:-");
                                Console.WriteLine("\t \t 1- Register in course");
                                Console.WriteLine("\t \t 2- List my courses");
                                Console.WriteLine("\t \t 3- view course");
                                Console.WriteLine("\t \t 4- Grades Report");
                                Console.WriteLine("\t \t 5- Logout");
                                Console.Write("\t \t please,enter choise[1-5]: ");
                                */

                                
                                break;
                            }
                    
                    
                    }
                    
                    break;
                }
                //if signup()
                if (choise == 2)
                {
                    int member_type = ask_of_member();
                    switch (member_type)
                    {
                        case 1://if member is doctor
                            {
                                int index_of_doctor = doctor.signup();
                                doctor.signup();
                               
                                break;
                            }
                        case 2://if member is student
                            {
                                int index_of_student = student.signup();
                                break;
                            }
                    }
                    break;
                }
                //if Exit()
                if (choise == 3)
                {

                    Environment.Exit(0);
                    break;
                }
                z = false;
                Console.Write("\t \t In valid value..please,renter choise[1-3]: ");
            }
            while (z == false);
            Console.ReadKey();
        }
    }
}
