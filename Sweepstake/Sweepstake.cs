using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    class Sweepstake
    {
        //Member Variables 

        Random rand = new Random();
        //Constructor
        public Sweepstake()
        {
            string name;
            
        }



        //Memeber Methods


        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public void Register(Contestant contestant)
        {
            contestants.Add(contestants.Count + 1, contestant);
        }

        public void ContestantPickWinner()
        {
            int index = rand.Next(contestants.Count);
        }

        public void PrintContestantInfo(Contestant contestant)
        {
           
        }


    }
}
