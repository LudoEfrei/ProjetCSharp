using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    public class XMLWrite
    {
        // Ecriture du fichier XML des interimaires
        public static void writeXML(List<EmployeInterim> collections, string nomFichier)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<EmployeInterim>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/" + nomFichier + ".xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, collections);
            file.Close();
        }

        // Ecriture du fichier XML des entreprises
        public static void writeXML(List<Entreprise> collections, string nomFichier)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Entreprise>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/" + nomFichier + ".xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, collections);
            file.Close();
        }

        // Ecriture du fichier XML des missions
        public static void writeXML(List<Mission> collections, string nomFichier)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Mission>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/" + nomFichier + ".xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, collections);
            file.Close();
        }
    }
}
