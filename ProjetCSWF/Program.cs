using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Collections
            List<EmployeInterim> interimaires = new List<EmployeInterim>();
            List<Entreprise> entreprises = new List<Entreprise>();
            List<Mission> missions = new List<Mission>();

            // Deserialisation (Chargement)

            // Traitement

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Serialisation (Sauvegarde)
            
        }

    }

}
