using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class Adresse
    {
        public string pays { get; set; }
        public string ville { get; set; }
        public string rue { get; set; }
        public string CP { get; set; }

        public Adresse(string pays, string ville, string rue, string CP)
        {
            this.pays = pays;
            this.ville = ville;
            this.rue = rue;
            this.CP = CP;
        }

        public override string ToString()
        {
            return (rue+", "+ville+", "+CP+", "+pays);
        }
    }
}
