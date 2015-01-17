using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ProjetCSWF
{
    public class Interimaires
    {
        public List<EmployeInterim> liste { get; set; }

        public Interimaires()
        {
            this.liste = new List<EmployeInterim>();
        }

        // Serialisation 
        public void writeXML()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<EmployeInterim>));

            // Si le dossier data n'existe pas, on le créer
            var directory = Environment.CurrentDirectory + "//data/";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var path = directory + "/interimaires.xml";
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
            XmlSerializer reader = new XmlSerializer(typeof(List<EmployeInterim>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/interimaires.xml");
            List<EmployeInterim> interimaires = new List<EmployeInterim>();
            try
            {
                this.liste = (List<EmployeInterim>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();
        }

        // Recherche
    }
}
