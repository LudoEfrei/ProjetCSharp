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
        private int avancement;
        private int risque;


        public Mission() { }

        public Mission(string titre, Entreprise entreprise, EmployeInterim interimaire, DateTime debut, DateTime fin)
        {
            this.titre = titre;
            this.entreprise = entreprise;
            this.interimaire = interimaire;
            this.debut = debut;
            this.fin = fin;
            this.avancement = 0;
            this.risque = 0;
        }

        // Constructeur sans employé intérimaire défini
        public Mission(string titre, Entreprise entreprise, DateTime debut, DateTime fin)
        {
            this.titre = titre;
            this.entreprise = entreprise;
            //this.interimaire = new EmployeInterim("null", "null", "null", -1);
            this.debut = debut;
            this.fin = fin;
            this.avancement = 0;
            this.risque = 0;
        }

        // Avancement en pourcentage
        public int Avancement
        {
            get { return avancement; }
            set 
            {  
                if ((value >= 0) && (value <= 100))
                    avancement = value;
            }
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

        public override string ToString()
        {
            return "Titre : " + titre + "\nEntreprise : " + entreprise + "\n Interimaire : \n" + interimaire +
                "\nDate de debut : " + debut + "\nDate de fin : " + fin + "\nAvancement : " + avancement + "\nRisque : " + risque;
        }

    }
}
