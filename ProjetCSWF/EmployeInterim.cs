using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    class EmployeInterim : Personne
    {
        public int age {get; set;}
        private List<string> competences { get; private set; }

        public EmployeInterim(string nom, string prenom, string n_telephone, int age) : base(nom, prenom, n_telephone)
        {
            this.age = age;
            this.competences = new List<string>();
        }
        public override string ToString()
        {
            return (nom + "\n" + prenom + "\n" + n_telephone) + "\n" + age + " ans";
        }
    }
}
