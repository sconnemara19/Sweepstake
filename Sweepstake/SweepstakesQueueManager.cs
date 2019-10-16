using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    class SweepstakesQueueManager : ISweepstakeManager
    {
        private Queue<Sweepstake> sweepstakeQueue;
        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            sweepstakeQueue.Enqueue(sweepstake);
        }

        public Sweepstake GetSweepstake()
        {
            Sweepstake locatedsweepstake = sweepstakeQueue.Dequeue();
            return locatedsweepstake;
            
        }
    }
}
