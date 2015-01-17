using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjetCSWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Conteneurs
            Interimaires interimaires = new Interimaires();
            Entreprises entreprises = new Entreprises();
            Missions missions = new Missions();

            // Deserialisation des listes (Chargement)
            interimaires.readXML();
            entreprises.readXML();
            missions.readXML();

            // Test

            /*
             * !!! Ne pas décommenter au risque de les voir s'ajouter à la BDD tout le temps !!!
             * 
            interimaires.Add(new EmployeInterim("Doe", "John", "0689857898", 25));
            interimaires[0].addCompetences("Cablage électrique", 2);
            interimaires.Add(new EmployeInterim("Smith", "Charles", "0778983545", 28));
            interimaires[1].addCompetences("Cablage électrique", 3);

            entreprises.Add(new Entreprise("Orange", new Adresse("France", "Paris", "78 Rue Olivier De Serres", "75015"),
                "38012986646850", new Contact("Sanchez", "Emilia", "0778987898")));

            missions.Add(new Mission("Maintenance du parc informatique", entreprises[0], new DateTime(2015, 01, 20), new DateTime(2015, 02, 20)));
            */

            // Traitement

            // Recherche

            // Test Chercher John et sa compétence de cablage électrique
            Console.WriteLine("\nTest 1 : ");
            interimaires.search("John");

            // Test chercher un mec de compétence cablage électrique
            Console.WriteLine("\nTest 2 : ");
            interimaires.searchComp("Cablage électrique");

            // Test chercher un mec de compétence cablage électrique de niveau 3
            Console.WriteLine("\nTest 3 : ");
            interimaires.searchComp("Cablage électrique", 3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(interimaires));

            // Serialisation des collections (Sauvegarde)
            interimaires.writeXML();
            entreprises.writeXML();
            missions.writeXML();
        }

    }

}
