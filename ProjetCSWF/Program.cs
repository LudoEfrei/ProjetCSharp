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
            // Deserialisation (Chargement)
            List<EmployeInterim> interimaires = XMLReader.ReadXMLinterim();
            // Collections
            //List<EmployeInterim> interimaires = new List<EmployeInterim>();
            List<Entreprise> entreprises = new List<Entreprise>();
            List<Mission> missions = new List<Mission>();

            // Test
            interimaires.Add(new EmployeInterim("Doe", "John", "0689857898", 25));
            interimaires[0].addCompetences("Cablage électrique", 2);
            interimaires.Add(new EmployeInterim("Smith", "Charles", "0778983545", 28));
            interimaires[1].addCompetences("Cablage électrique", 3);

            entreprises.Add(new Entreprise("Orange", new Adresse("France", "Paris", "78 Rue Olivier De Serres", "75015"),
                "38012986646850", new Contact("Sanchez", "Emilia", "0778987898")));

            missions.Add(new Mission("Maintenance du parc informatique", entreprises[0], new DateTime(2015, 01, 20), new DateTime(2015, 02, 20)));

            // Traitement

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(interimaires));

            // Serialisation (Sauvegarde)
            XMLWrite.writeXML(interimaires, "interimaires");
            XMLWrite.writeXML(entreprises, "entreprises");
            XMLWrite.writeXML(missions, "missions");


            
            
        }

    }

}
