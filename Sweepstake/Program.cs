using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakeManager manager = SweepstakeManagerFactory.CreateManager();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        //string ChooseAManager()
        //    {
        //        Userinterface.PickAManager();
        //        string input = Console.ReadLine();
        //        return input;
        //    }
        // void AddAManager()
        //    {
        //        ISweepstakeManager manager = SweepstakeManagerFactory.CreateManager(manager);
        //    }
        }
    }


}
