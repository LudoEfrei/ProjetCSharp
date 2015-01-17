using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    class Entreprises
    {
        public List<Entreprise> liste { get; set; }

        public Entreprises()
        {
            this.liste = new List<Entreprise>();
        }

        // Serialisation
        public void writeXML()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Entreprise>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/entreprises.xml";
            FileStream file = File.Create(path);

            try
            {
                writer.Serialize(file, this.liste);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();
        }

        // Deserialisation
        public void readXML()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Entreprise>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/entreprises.xml");
            List<Entreprise> entreprises = new List<Entreprise>();
            try
            {
                this.liste = (List<Entreprise>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();
        }
    }
}
