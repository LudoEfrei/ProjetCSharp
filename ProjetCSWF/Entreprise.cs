using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class Entreprise
    {
        private string nom;
        private string adresse;
        private string n_siret;
        private string contact;

        public Entreprise(string nom, string adresse, string n_siret, string contact)
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
