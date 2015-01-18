using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public class Avancement
    {
        private int pourcentage;
        public DateTime milestone { get; set; }

        public Avancement() 
        {
            this.pourcentage = 0;
        }

        public Avancement(int pourcentage, DateTime milestone)
        {
            this.pourcentage = pourcentage;
            this.milestone = milestone;
        }

        public int Pourcentage
        {
            get { return pourcentage; }
            set
            {
                if ((value >= 0) && (value <= 100))
                    pourcentage = value;
            }
        }

        public override string ToString()
        {
            return "Avancement : " + pourcentage + "% le " + milestone;
        }
    }
}
