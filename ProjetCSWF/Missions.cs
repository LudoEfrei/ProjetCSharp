using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    class Missions
    {
        public List<Mission> liste { get; set; }

        public Missions()
        {
            this.liste = new List<Mission>();
        }

        // Serialisation
        public void writeXML()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Mission>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/missions.xml";
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
            XmlSerializer reader = new XmlSerializer(typeof(List<Mission>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/missions.xml");
            List<Mission> missions = new List<Mission>();
            try
            {
                this.liste = (List<Mission>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();
        }
    }
}
