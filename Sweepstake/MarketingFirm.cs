using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake
{
    class MarketingFirm
    {
        //Member Variables
        ISweepstakeManager manager;       
     
     //Constructor
        public MarketingFirm(ISweepstakeManager manager)
        {
             this.manager = manager;
        }

    //Member Methods
     public void CreateSweepstake()
        {
            Sweepstake sweepstake = new Sweepstake();
        
        }

    
    
    }
}
