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
            
            try
            {
                StreamReader file = new StreamReader(directory + "/interimaires.xml");
                List<EmployeInterim> interimaires = new List<EmployeInterim>();
                this.liste = (List<EmployeInterim>)reader.Deserialize(file);

                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
                return;
            }  
        }

        // Recherche
        // Selon nom/prenom/age
        public Interimaires search(string critere)
        {
            Interimaires trouvailles = new Interimaires();
            critere = critere.ToLower();
            // Query Creation
            var interimQuery =
                from interim in this.liste
                where interim.nom.ToLower() == critere ||
                    interim.prenom.ToLower() == critere ||
                    (interim.nom.ToLower() + " " + interim.prenom.ToLower()) == critere ||
                    (interim.prenom.ToLower() + " " + interim.nom.ToLower()) == critere ||
                    interim.age.ToString() == critere ||
                    interim.n_telephone.ToLower() == critere
                select interim;

            // Query execution
            foreach (EmployeInterim interim in interimQuery)
            {
                trouvailles.liste.Add(interim);
                Console.WriteLine(interim);
            }

            return trouvailles;
        }
        
        // Selon competence (intitule et niveau)
        public Interimaires searchComp(string intitule, int niveau)
        {
            Interimaires trouvailles = new Interimaires();
            Competence compCorres = new Competence();
            intitule = intitule.ToLower();

            // Recherche de la competence
            foreach (EmployeInterim interim in this.liste)
            {
                try
                {

                    compCorres = interim.search(intitule, niveau);
                    if (compCorres.intitule != null && compCorres.intitule.ToLower() == intitule && compCorres.Niveau == niveau)
                    {
                        trouvailles.liste.Add(interim);
                        Console.WriteLine(interim);
                        Console.WriteLine(interim.search(intitule, niveau));
                    }
                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex);
                }
                
            }

            return trouvailles;
        }

        // Selon competence juste l'intitulé
        public Interimaires searchComp(string intitule)
        {
            Interimaires trouvailles = new Interimaires();
            Competence compCorres = new Competence();
            intitule = intitule.ToLower();

            // Recherche de la competence
            foreach (EmployeInterim interim in this.liste)
            {
                compCorres = interim.search(intitule);
                if (compCorres.intitule != null && compCorres.intitule.ToLower() == intitule)
                {
                    trouvailles.liste.Add(interim);
                    Console.WriteLine(interim);
                    Console.WriteLine(interim.search(intitule));
                }
            }

            return trouvailles;
        }

        // Lister
        public void show()
        {
            // Query Creation
            var interimQuery =
                from interim in this.liste
                select interim;

            // Query execution
            foreach (EmployeInterim interim in interimQuery)
            {
                // Affichage dans form ?
                Console.WriteLine(interim);
            }
        }
    }
}
