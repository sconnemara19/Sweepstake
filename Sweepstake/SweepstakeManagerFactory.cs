using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    static class SweepstakeManagerFactory
    {
        public static ISweepstakeManager CreateManager()
        {
            string ChooseAManager()
            {
                Userinterface.PickAManager();
                string input = Console.ReadLine();
                return input;
            }


            ISweepstakeManager user = null;
            switch (manager)
            {
                case " Stack":
                    user = new SweepstakeStackManager();
                    break;
                case "Queue":
                    user = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    CreateManager(manager);
                    break;
            }
            return user;
                
                
        } 
    
    
    
    
    
    
    }



}
