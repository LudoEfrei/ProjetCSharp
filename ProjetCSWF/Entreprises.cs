using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProjetCSWF
{
    public class Entreprises
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

            try
            {
                StreamReader file = new StreamReader(directory + "/entreprises.xml");
                List<Entreprise> entreprises = new List<Entreprise>();
                this.liste = (List<Entreprise>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
                return;
            }

            
        }

        // Recherche
        // Selon nom/adresse/n_siret/contact
        public Entreprises search(string critere)
        {
            Entreprises trouvailles = new Entreprises();
            critere = critere.ToLower();

            // Query Creation
            var enterpriseQuery =
                from enterprise in this.liste
                where enterprise.nom.ToLower() == critere || enterprise.adresse.rue.ToLower() == critere ||
                    enterprise.adresse.CP.ToLower() == critere || enterprise.adresse.ville.ToLower() == critere ||
                    enterprise.adresse.rue.ToLower() == critere || enterprise.adresse.pays.ToLower() == critere ||
                    enterprise.n_siret.ToLower() == critere || enterprise.contact.nom.ToLower() == critere ||
                    enterprise.contact.prenom.ToLower() == critere || enterprise.contact.n_telephone.ToLower() == critere ||
                    (enterprise.contact.nom.ToLower() + " " + enterprise.contact.prenom.ToLower()) == critere ||
                    (enterprise.contact.prenom.ToLower() + " " + enterprise.contact.nom.ToLower()) == critere
                select enterprise;

            // Query execution
            foreach (Entreprise enterprise in enterpriseQuery)
            {
                trouvailles.liste.Add(enterprise);
                Console.WriteLine(enterprise);
            }

            return trouvailles;
        }
    }
}
