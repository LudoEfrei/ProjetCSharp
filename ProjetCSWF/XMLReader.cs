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
                Console.WriteLine(interimaires[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ICI JE BUG");
                Console.WriteLine(ex.GetBaseException());
                Console.WriteLine("ICI JE BUG");
            }

            file.Close();

            return interimaires;
        }
    }
}
