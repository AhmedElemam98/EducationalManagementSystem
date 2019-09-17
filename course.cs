using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_management_system
{
    class course
    {
        public string name, code;
        public IList<assignment>course_assignments=new List<assignment>();
        public IList<student>students_of_course=new List<student>();
        public static IList<course>courses=new List<course>();
        public doctor doctor_of_course = new doctor();
        
       
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


        public string Code
        {
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.Write("\t \t That is invalid code.. please re-enter it: ");
                    value = Console.ReadLine();
                }
                code = value;

            }
            get
            {
                return code;
            }

        }
        


    }
}
