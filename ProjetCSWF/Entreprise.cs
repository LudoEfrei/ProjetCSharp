using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public class Entreprise
    {
        public string nom { get; set; }
        public Adresse adresse { get; set; }
        public string n_siret { get; set; }
        public Contact contact { get; set; }

        public Entreprise() { }

        public Entreprise(string nom, Adresse adresse, string n_siret, Contact contact)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.n_siret = n_siret;
            this.contact = contact;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\nAdresse : " + adresse + "\nNumero Siret : " + n_siret + "\nContact : \n" + contact;
        }
    }
}
