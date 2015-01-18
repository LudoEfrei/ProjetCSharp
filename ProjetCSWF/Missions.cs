using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    public class Missions
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
            
            try
            {
                StreamReader file = new StreamReader(directory + "/missions.xml");
                List<Mission> missions = new List<Mission>();
                this.liste = (List<Mission>)reader.Deserialize(file);

                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
                return;
            }
        }

        // Recherche
        // Selon titre de la mission, et nom de l'entreprise
        public Missions search(string critere)
        {
            Missions trouvailles = new Missions();
            critere = critere.ToLower();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.titre.ToLower() == critere || mission.entreprise.nom.ToLower() == critere                    
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Selon interimaire (nom, prenom ou les deux)
        public Missions searchInterim(string critere)
        {
            Missions trouvailles = new Missions();
            critere = critere.ToLower();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.interimaire != null &&
                    (mission.interimaire.nom.ToLower() == critere || mission.interimaire.prenom.ToLower() == critere ||
                    (mission.interimaire.nom.ToLower() + " " + mission.interimaire.prenom.ToLower()) == critere ||
                    (mission.interimaire.prenom.ToLower() + " " + mission.interimaire.nom.ToLower()) == critere)
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Selon interimaire (objet)
        public Missions searchInterim(EmployeInterim interimaire)
        {
            Missions trouvailles = new Missions();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.interimaire != null && mission.interimaire == interimaire
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Missions qui n'ont pas d'intérimaires
        public Missions searchNoInterim()
        {
            Missions trouvailles = new Missions();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.interimaire == null
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Missions qui n'ont pas d'intérimaires et avec un critère
        public Missions searchNoInterim(string critere)
        {
            Missions trouvailles = new Missions();
            critere = critere.ToLower();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.interimaire == null &&
                    (mission.interimaire.nom.ToLower() == critere || mission.interimaire.prenom.ToLower() == critere ||
                    (mission.interimaire.nom.ToLower() + " " + mission.interimaire.prenom.ToLower()) == critere ||
                    (mission.interimaire.prenom.ToLower() + " " + mission.interimaire.nom.ToLower()) == critere)
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Missions avec risque de retard > valeur entrée (25% par exemple)
        public Missions searchRisqueGT(int risque)
        {
            Missions trouvailles = new Missions();

            // Query Creation
            var missionQuery =
                from mission in this.liste
                where mission.interimaire != null && mission.Risque >= risque
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                trouvailles.liste.Add(mission);
                Console.WriteLine(mission);
            }

            return trouvailles;
        }

        // Lister
        public void show()
        {
            // Query Creation
            var missionQuery =
                from mission in this.liste
                select mission;

            // Query execution
            foreach (Mission mission in missionQuery)
            {
                // Affichage dans form ?
                Console.WriteLine(mission);
            }
        }
    }
}
