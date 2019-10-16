using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    class SweepstakeStackManager : ISweepstakeManager
    {
        private Stack<Sweepstake> sweepstakeStack;
        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            sweepstakeStack.Push(sweepstake);   
        }

        public Sweepstake GetSweepstake()
        {
            Sweepstake foundsweepstake =  sweepstakeStack.Pop();
            return foundsweepstake;
           
            
        }
    }
}
