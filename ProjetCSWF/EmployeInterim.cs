using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public class EmployeInterim : Personne
    {
        public int age {get; set;}
        public List<Competence> competences { get; set; }

        public EmployeInterim() { }

        public EmployeInterim(string nom, string prenom, string n_telephone, int age) : base(nom, prenom, n_telephone)
        {
            this.age = age;
            this.competences = new List<Competence>();
        }

        // Ajout d'une compétence
        public void addCompetences(string intitule, int niveau)
        {
            competences.Add(new Competence(intitule, niveau));
        }

        public override string ToString()
        {
            return (nom + "\n" + prenom + "\n" + n_telephone) + "\n" + age + " ans";
        }
    }
}
