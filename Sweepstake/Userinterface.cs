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
            Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
        }
        public static  void EmailAddress()
        {
            Console.WriteLine(" What is your email address?");
             Console.ReadLine();
        }
        public static void Registration()
        {
            Console.WriteLine("Please enter your registration number");
             Int32.Parse(Console.ReadLine());


        }
        public static void ContestantInformation()
        {
            Name();
            EmailAddress();
            Registration();

        }


    }
}
