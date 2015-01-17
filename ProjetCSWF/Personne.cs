using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public abstract class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string n_telephone { get; set; }

        public Personne() { }

        public Personne(string nom, string prenom, string n_telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.n_telephone = n_telephone;
        }

        public override string ToString()
        {
            return (nom + "\n" + prenom + "\n" + n_telephone);
        }
    }
}
