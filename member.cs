using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//بسم لله الرحمن الرحيم
namespace Educational_management_system
{
    class member
    {
        private string username;
        private string password;
        private string email;
        private string code;
        //To ensure that user enter correct email 
        //We used "try-catch" because handelexpetion terminate program if email not correct
        //through new System.Net.Mail.MailAddress(value);
        //for(; ;)is infinite loop to make user enter correct email
        public string Email
        {
            set
            {
                for (; ; )
                {
                    try
                    {
                        new System.Net.Mail.MailAddress(value);
                        email = value;
                        break;
                    }
                    catch
                    {
                        Console.Write("\t \t That is invalid email.. please re-enter it: ");
                        value=Console.ReadLine();
                    }
                }
                }
            get
            {
                return email;
            }
        }
        public string Username
        {
            set 
            {
                while (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.Write("\t \t That is invalid username.. please re-enter it: ");
                    }
                    else
                    {
                        Console.Write("\t \t Username is so weak .. please re-enter it: ");
                    }
                    value = Console.ReadLine();
                }
                username = value;
            
            }
            get
            {
                return username;
            }
       
        }
        public string Password
        {
            set
            {
                while (string.IsNullOrWhiteSpace(value)||value.Length<6)
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.Write("\t \t That is invalid password.. please re-enter it: ");
                    }
                    else
                    {
                        Console.Write("\t \t Password is so weak .. please re-enter it: ");
                    }
                    value = Console.ReadLine();
                }
                password = value;
            }
            get
            {
                return password;
            }
        
        }
        public string Code
        {
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.Write("\t \t That is invalid code.. please re-enter it: ");
                        value = Console.ReadLine();
                    }
                        
                }
                code = value;
            }
            get
            {
                return code;
            }
        
        
        }
    
 
       
        //Used when user login to show if user found or not..if found return index to search form array objects for his info
       /* public static bool login(int ask_of_member)
        {
    
            Console.WriteLine("\nPlease,enter your username and password:");
            switch (ask_of_member)
            {
                case 1:
                    {
                        //if user is doctor
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
                                    return true;//if user is found 
                                }
                            }
                        }
                        return false;//if user isn't found 
                    }
                case 2:
                    {
                        //if user is student
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
                                    return true;//if user is found 
                                }
                            }
                        }
                        return false;//if user isn't found
                    }
      
            }
            return false; 
        }
        */ 
        //Used when user signup
      

        

        

    }
}
