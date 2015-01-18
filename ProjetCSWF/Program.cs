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

            // Tests chercher un mec nommer "Charles Smith" puis "Doe John"
            Console.WriteLine("\nTest 4 : ");
            interimaires.search("charles Smith");
            Console.WriteLine("\nTest 5 : ");
            interimaires.search("Doe john");

            // Test selon l'age 25 ans
            Console.WriteLine("\nTest 6 : ");
            interimaires.search("25");

            // Test entreprise nom puis contact
            Console.WriteLine("\nTest 7 : ");
            entreprises.search("Orange");
            Console.WriteLine("\nTest 8 : ");
            entreprises.search("Emilia Sanchez");

            // Test missions titre puis interimaire
            Console.WriteLine("\nTest 9 : ");
            missions.search("maintenance du parc informatique");
            Console.WriteLine("\nTest 10 : ");
            missions.searchInterim("john doe");
            
            // Test missions sans interimaire
            Console.WriteLine("\nTest 11 : ");
            missions.searchNoInterim();

            // Test missions d'un interimaire objet
            Console.WriteLine("\nTest 12 : ");
            missions.searchInterim(interimaires.search("asami yamada").liste[0]);

            // Test embaucher 
            Console.WriteLine("\nTest 13 : ");
            missions.search("balayage des toilettes").liste[0].embaucher(missions, interimaires.search("asami yamada").liste[0]);

            // Interface Graphique
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(interimaires,entreprises,missions));

            // Serialisation des collections (Sauvegarde)
            interimaires.writeXML();
            entreprises.writeXML();
            missions.writeXML();
        }

    }

}
