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
            


            ISweepstakeManager user = null;
            string input = Userinterface.PickAManager();
            switch (input)
            {
                case "Stack":
                    user = new SweepstakeStackManager();
                    break;
                case "Queue":
                    user = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    CreateManager();
                    break;
            }
            return user;
                
                
        } 
    
    
    
    
    
    
    }



}
