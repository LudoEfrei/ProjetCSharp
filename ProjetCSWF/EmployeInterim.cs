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
        // Selon intitule
        public Competence search(string intitule)
        {
            Competence trouvaille = new Competence();
            intitule = intitule.ToLower();

            // Query Creation
            var compQuery =
                from comp in this.competences
                where comp.intitule.ToLower() == intitule
                select comp;

            // Query execution
            foreach (Competence comp in compQuery)
            {
                trouvaille = comp;
            }

            return trouvaille;
        }

        // Selon intitule niveau
        public Competence search(string intitule, int niveau)
        {
            Competence trouvaille = new Competence();
            intitule = intitule.ToLower();

            var compQuery =
                from comp in this.competences
                where comp.intitule.ToLower() == intitule && comp.Niveau == niveau
                select comp;

            foreach (Competence comp in compQuery)
            {
                trouvaille = comp;
            }
            return trouvaille;
        }

        public string listComp()
        {
            string laListe = "";

            var compQuery =
                from comp in this.competences
                select comp;

            foreach (Competence comp in compQuery)
            {
                laListe += "[" + comp.intitule + "] (Niveau : " + comp.Niveau + ") ";
            }

            return laListe;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\n Prenom : " + prenom + "\n Telephone : " + n_telephone + "\n Age : " + age + " ans";
        }


        // Surcharge de l'opérateur Equals etc pour operateur ==
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            EmployeInterim p = obj as EmployeInterim;
            if ((Object)p == null)
                return false;
            return nom == p.nom && prenom == p.prenom &&
                n_telephone == p.n_telephone && age == p.age &&
                competences == p.competences;
        }

        public bool Equals(EmployeInterim p)
        {
            if ((object)p == null)
            {
                return false;
            }

            return nom == p.nom && prenom == p.prenom &&
                n_telephone == p.n_telephone && age == p.age &&
                competences == p.competences;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(EmployeInterim a, EmployeInterim b)
        {
            if (Object.ReferenceEquals(a, b))
                return true;
            if (((object)a == null) || ((object)b == null))
                return false;
            for (int i = 0; i < a.competences.Count; i++)
            {
                try 
                { 
                if (a.competences[i] != b.competences[i])
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return a.nom == b.nom && a.prenom == b.prenom &&
                a.n_telephone == b.n_telephone && a.age == b.age;
        }

        public static bool operator !=(EmployeInterim a, EmployeInterim b)
        {
            if (Object.ReferenceEquals(a, b))
                return false;
            if (((object)a == null) || ((object)b == null))
                return true;
            return a.nom == b.nom || a.prenom == b.prenom ||
                a.n_telephone == b.n_telephone || a.age == b.age ||
                a.competences == b.competences;
        }
    }
}
