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
