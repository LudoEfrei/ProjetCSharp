using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    public class XMLReader
    {
        public static List<EmployeInterim> ReadXMLinterim()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<EmployeInterim>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/interimaires.xml");
            List<EmployeInterim> interimaires = new List<EmployeInterim>();
            try
            {
                interimaires = (List<EmployeInterim>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();

            return interimaires;
        }

        public static List<Entreprise> readXMLEntreprise()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Entreprise>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/entreprises.xml");
            List<Entreprise> entreprises = new List<Entreprise>();
            try
            {
                entreprises = (List<Entreprise>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();

            return entreprises;
        }

        public static List<Mission> readXMLMission()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Mission>));
            var directory = Environment.CurrentDirectory + "//data/";
            StreamReader file = new StreamReader(directory + "/missions.xml");
            List<Mission> missions = new List<Mission>();
            try
            {
                missions = (List<Mission>)reader.Deserialize(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }

            file.Close();

            return missions;
        }
    }
}
