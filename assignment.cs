using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_management_system
{
    class assignment
    {
        public IList<student> students_solved_assignment = new List<student>();
        public IList<soutions> solution_of_assignment = new List<soutions>();

        int totalmark;
        string name;
        string question;

         public string Name
         {
             set
             {
                 while (string.IsNullOrWhiteSpace(value))
                 {
                     Console.Write("\t \t That is invalid name.. please re-enter it: ");
                     value = Console.ReadLine();
                 }
                 name = value;

             }
             get
             {
                 return name;
             }

         }
         public string Question
         {
             set
             {
                 while (string.IsNullOrWhiteSpace(value))
                 {
                     Console.Write("\t \t That is invalid question.. please re-enter it: ");
                     value = Console.ReadLine();
                 }
                 question = value;

             }
             get
             {
                 return question;
             }

         }
         public int Totalmark
         {
             
             set
             {
                 
                 while (int.TryParse(Console.ReadLine(), out value) == false)
                 {
                     Console.Write("\t \t Invalid mark .. Please re-enter it: ");
                 }
                
                 totalmark = value;
             }
             get
             {
                 return totalmark;
             }
         
         }


         public static void create_Assignment(int index_of_doctor, int index_of_course)
         {

             assignment a = new assignment();
             Console.WriteLine("\n\nplease enter data of your new assignment:");
             Console.Write("\t \t 1- name:");
             a.Name = Console.ReadLine();
             Console.Write("\t \t 2-assignment:");
             a.Question = Console.ReadLine();
             Console.Write("\t \t 2-totalmark:");
              a.Totalmark = 5;//I have property of it made me give it value 
             doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Add(a);
             Console.WriteLine("\t assignment {0} with totalmark {1} has been created successfully \n", a.Name,a.Totalmark);
         }

         public static void list_assignment(int index_of_doctor, int index_of_course)
         {
             if (doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count == 0)
             {
                 Console.WriteLine(" \n\n\t\t You haven't Created any assignment for this course yet ..");
             }
             else
             {
                 Console.WriteLine(" \nYour assignments are:");
                 for (int i = 0; i < doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count; i++)
                 {
                     Console.WriteLine("\t \t . Assignment {0} of totalmark {1}", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[i].Name, doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[i].Totalmark);
                 }
             }
         
         }


         public static void view_assignment(int index_of_doctor, int index_of_course)
         { 
         
         //list assignment
             if (doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count == 0)
             {
                 Console.WriteLine(" \n\n\t\t You haven't Created any assignment for this course yet ..");
             }
             else
             {
                 Console.WriteLine(" \nYour assignments are:");
                 for (int i = 0; i < doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count; i++)
                 {
                     Console.WriteLine("\t \t {0} - Assignment {1} of totalmark {2}",i+1, doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[i].Name, doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[i].Totalmark);
                 }

                 Console.Write("\t \t Please,Enter index of assignment you want to view [1-{0}]:", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count);
                 int index_of_assignment = -1;
                 bool n = int.TryParse(Console.ReadLine(), out index_of_assignment);
                 while (n == false || index_of_assignment < 1 || index_of_assignment > doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count)
                 {
                     Console.Write("\t \t Invalid..Re-enter index of assignment you want to view [1-{0}]:", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments.Count);
                     n = int.TryParse(Console.ReadLine(), out index_of_assignment);
                 }

                 //index_of_assignment -1        ---->Here to access assignment

                 Console.WriteLine("\nPlease make achoise:-");
                 Console.WriteLine("\t \t 1- Show info");
                 Console.WriteLine("\t \t 2- List solutions");
                 Console.WriteLine("\t \t 3- view solution");
                 Console.WriteLine("\t \t 4- Show Grades Report");
                 Console.WriteLine("\t \t 5- Back");
                 Console.Write("\t \t please,enter choise[1-5]: ");
                 int choise = -1;
                 bool z = false;
                 do
                 {
                     z = int.TryParse(Console.ReadLine(), out choise);
                     switch (choise)
                     {
                         //Show info
                         case 1:
                             {
                                 Console.WriteLine();
                                 Console.WriteLine("\t     --> This assignment is {0}..", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].Question);
                                 Console.WriteLine("\t     --> Total mark of this assignment is {0}..", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].Totalmark);
                                 Console.WriteLine("\t     --> Number of students has submitted is {0}.", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].students_solved_assignment.Count);

                                 z = true;
                                 break;
                             }
                         //List solution
                         case 2:
                             {
                                 if (doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment-1].solution_of_assignment.Count!=0)
                                 {
                                     Console.WriteLine("\n \nSolutions of assignment {0} by students are:", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].Name);
                                     for (int i = 0; i < doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].solution_of_assignment.Count; i++)
                                         Console.WriteLine("\t \t . Solution \" {0} \" by user \" {1} \"", doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].solution_of_assignment[i].Solution, doctor.usersobjects[index_of_doctor].user_courses[index_of_course].course_assignments[index_of_assignment - 1].solution_of_assignment[i].stu.Username);

                                 }
                                 else
                                     Console.WriteLine("\n \t\t No students has submited yet");
                                 z = true;
                                 break;
                             }
                         //view solution
                         case 3:
                             {
                                 
                                 z = true;
                                 break;
                             }
                         //Grades Report
                         case 4:
                             {
                                 z = true;
                                 break;
                             }
                         //Back
                         case 5:
                             {

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
         
         
         
         
         
         
         
         }


    }
}
