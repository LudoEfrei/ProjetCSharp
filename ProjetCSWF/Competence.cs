using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public class Competence
    {
        public string intitule { get; set; }
        private int niveau;

        public Competence() { }

        public Competence(string intitule, int niveau)
        {
            this.intitule = intitule;
            this.niveau = niveau;
        }

        // Niveau noté de 1 à 5
        public int Niveau
        {
            get { return niveau; }
            set
            {
                if ((value >= 1) && (value <= 5))
                    niveau = value;
            }
        }

        public override string ToString()
        {
            return "Competence : " + intitule + "\nNiveau : " + niveau;
        }
    }
}
