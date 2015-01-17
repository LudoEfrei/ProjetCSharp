using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class Entreprise
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public string n_siret { get; set; }
        public Contact contact { get; set; }

        public Entreprise(string nom, string adresse, string n_siret, Contact contact)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.n_siret = n_siret;
            this.contact = contact;
        }

        public override string ToString()
        {
            return (nom + "\n" + adresse + "\n" + n_siret + "\n" + contact);
        }
    }
}
