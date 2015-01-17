using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class Mission
    {
        public string titre { get; set; }
        private int avancement;
        private int risque;
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }

        public int Avancement
        {
            get { return avancement; }
            set 
            {  
                if ((value >= 0) && (value <= 100))
                    avancement = value;
            }
        }

        public int Risque
        {
            get { return risque; }
            set
            {
                if ((value >= 0) && (value <= 100))
                    risque = value;
            }
        }

    }
}
