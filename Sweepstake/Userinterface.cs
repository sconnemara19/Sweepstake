using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    static class Userinterface
    {
        //Memeber Variables 

        
        
        //Constructor 
        static Userinterface()
        {

        }
        //Memeber Methods

        public static void Name()
        {
            Console.WriteLine("What is your first name?");
          string userinput = Console.ReadLine();
            
        }
        public static void LastName()
        {
            Console.WriteLine("What is your last name?");
            string input = Console.ReadLine();
        }
        public static void EmailAddress()
        {
            Console.WriteLine(" What is your email address?");
            string userinput = Console.ReadLine();
        }
        public static void Registration()
        {
            Console.WriteLine("Please enter your registration number");
           int input= Int32.Parse(Console.ReadLine());


        }
        public static void ContestantInformation()
        {
            Name();
            EmailAddress();
            Registration();

        }
        
    }
}
