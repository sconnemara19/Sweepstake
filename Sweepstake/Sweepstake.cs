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
            // generate random between 0,count
            int index = rand.Next(0, contestants.Count);
            //loop through the dictionary stoping at the number you just randomly generated and make them the winner
            for (int i = 0; i < contestants.Count; i++)
            {
                if (contestants.Count == rand.Next()) 
                {
                    Console.WriteLine("Sweepstake Winner");
                }
            }
           
           
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.name);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.email);
            Console.WriteLine(contestant.registration);
        }


    }
}
