using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSWF
{
    public class Mission
    {
        public string titre { get; set; }
        public Entreprise entreprise { get; set; }
        public EmployeInterim interimaire { get; set; }
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }
        public List<Avancement> avancements { get; set; }
        private int risque;


        public Mission() { }

        public Mission(string titre, Entreprise entreprise, EmployeInterim interimaire, DateTime debut, DateTime fin)
        {
            this.titre = titre;
            this.entreprise = entreprise;
            this.interimaire = interimaire;
            this.debut = debut;
            this.fin = fin;
            this.avancements = new List<Avancement>();
            this.avancements.Add(new Avancement(0, DateTime.Today));
            this.risque = 0;
        }

        // Constructeur sans employé intérimaire défini
        public Mission(string titre, Entreprise entreprise, DateTime debut, DateTime fin)
        {
            this.titre = titre;
            this.entreprise = entreprise;
            this.debut = debut;
            this.fin = fin;
            this.avancements = new List<Avancement>();
            this.avancements.Add(new Avancement(0, DateTime.Today));
            this.risque = 0;
        }

        // Risque que le travail ne soit pas fini avant la date fin en pourcentage
        public int Risque
        {
            get { return risque; }
            set
            {
                if ((value >= 0) && (value <= 100))
                    risque = value;
            }
        }

        //Interimaire qui ne doit pas avoir une autre mission dont la date de fin > date de début d'une autre
        public bool embaucher(Missions missions, EmployeInterim interimaire)
        {
            bool pasPris = true;
            Missions autresMissions = missions.searchInterim(interimaire.nom + " " + interimaire.prenom);

            foreach (Mission mission in autresMissions.liste)
            {
                Console.WriteLine(this.debut);
                Console.WriteLine(fin);
                pasPris = false;
                if (fin >= this.debut) 
                    pasPris = false;
            }

            if (pasPris == false)
            {
                Console.WriteLine("Impossible d'embaucher cet intérimaire pour cette mission, une autre mission interfère.");
            }

            return pasPris;

        }

        // Lister les avancements de la mission durant une période de temps
        public List<Avancement> listAvancements(DateTime de, DateTime a)
        {
            List<Avancement> trouvailles = new List<Avancement>();

            var avtQuery =
                from avt in this.avancements
                where avt.milestone >= de && avt.milestone <= a
                select avt;
            Console.WriteLine("Avancements du " + de + " au " + a + " : ");
            foreach (Avancement avt in avtQuery)
            {
                Console.WriteLine(avt);
                trouvailles.Add(avt);
            }

            return trouvailles;
        }

        /*
        // Faire une facture
        public void makeFacture()
        {
            if (this.fin < DateTime.Today)
            {
                Console.WriteLine("La mission n'est pas terminée, impossible de faire une facture.");
            }
            else 
            {
                Console.WriteLine(this);
                double result = (double)this.interimaire.tarif;
                result *= (this.fin - this.debut).TotalDays;
                Console.WriteLine("Salaire : " + result + " euros");
            }
        }

        // Editer une facture
        public void  editFacture(double salaire)
        {
            if (this.fin < DateTime.Today)
            {
                Console.WriteLine("La mission n'est pas terminée, il n'y a pas de facture à éditer.");
            }
            else
            {
                Console.WriteLine(this);
                Console.WriteLine("Salaire : " + salaire + " euros");
            }
        }
        */

        public override string ToString()
        {
            return "Titre : " + titre + "\nEntreprise : " + entreprise + "\nInterimaire : \n" + interimaire +
                "\nDate de debut : " + debut + "\nDate de fin : " + fin + "\nAvancement : " + avancements.Last() +"\nRisque : " + risque + "%";
        }

    }
}
