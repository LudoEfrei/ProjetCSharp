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

        // Recherche d'une compétence
        // Selon intitulé et niveau
        public Competence search(string intitule, int niveau)
        {
            Competence trouvaille = new Competence();

            // Query Creation
            var compQuery =
                from comp in this.competences
                where comp.intitule == intitule && comp.Niveau == niveau
                select comp;

            // Query execution
            foreach (Competence comp in compQuery)
            {
                trouvaille = comp;
            }
                
            return trouvaille;
        }

        // Selon intitule
        public Competence search(string intitule)
        {
            Competence trouvaille = new Competence();

            // Query Creation
            var compQuery =
                from comp in this.competences
                where comp.intitule == intitule
                select comp;

            // Query execution
            foreach (Competence comp in compQuery)
            {
                trouvaille = comp;
            }

            return trouvaille;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\nPrenom : " + prenom + "\nTelephone : " + n_telephone + "\nAge : " + age + " ans";
        }
    }
}
