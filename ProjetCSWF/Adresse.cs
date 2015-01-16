using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class Adresse
    {
        private string pays;
        private string ville;
        private string rue;
        private string CP;


        public override string ToString()
        {
            return (rue+", "+ville+", "+CP+", "+pays);
        }
    }
}
