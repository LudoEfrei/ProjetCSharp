using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSWF
{
    public partial class Form1 : Form
    {
        public Interimaires interimaires;
        public Entreprises entreprises;
        public Missions missions;

        public Form1(Interimaires interimaires,Entreprises entreprises, Missions missions)
        {
            InitializeComponent();
            this.interimaires = interimaires;
            this.entreprises = entreprises;
            this.missions = missions;

        }


        private void button_empl_Click(object sender, EventArgs e)
        {
            /*
            liste.Columns.Add("Nom", "Nom");
            liste.Columns.Add("Prénom", "Prenom");
            liste.Columns.Add("N°tel", "N°tel");
            liste.Columns.Add("Age", "Age");
            liste.Columns.Add("Compétences", "Compétences");

            int cpt = 0;
            foreach (EmployeInterim i in interimaires.liste)
            {    
                liste.Rows.Add(i.nom,i.prenom,i.n_telephone,i.age,i.listComp());
                liste.Rows[cpt].HeaderCell.Value = (cpt+1).ToString();
                cpt++;
            }

            button_miss.Hide();
            button_Ent.Hide();
            button_empl.Hide();
            liste.Show();
            button_ajouter.Show();
             * */
            Form2 f2 = new Form2(interimaires);
            f2.Show();
        }

        private void button_Ent_Click(object sender, EventArgs e)
        {
            liste.Columns.Add("Nom", "Nom");
            liste.Columns.Add("Adresse", "Adresse");
            liste.Columns.Add("N°Siret", "N°Siret");
            liste.Columns.Add("Contact", "Contact");

            int cpt = 0;
            foreach (Entreprise i in entreprises.liste)
            {
                liste.Rows.Add(i.nom, i.adresse, i.n_siret, i.contact.nom);
                liste.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            button_miss.Hide();
            button_Ent.Hide();
            button_empl.Hide();
            liste.Show();
            button_ajouter.Show();
        }

        private void button_miss_Click(object sender, EventArgs e)
        {
            liste.Columns.Add("Titre", "Titre");
            liste.Columns.Add("Entreprise", "Entreprise");
            liste.Columns.Add("Début", "Début");
            liste.Columns.Add("Fin", "Fin");
            liste.Columns.Add("Avancement", "Avancement");
            liste.Columns.Add("Risque", "Risque");

            int cpt = 0;
            foreach (Mission i in missions.liste)
            {
                liste.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.Avancement.ToString(),i.Risque.ToString());
                liste.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            button_miss.Hide();
            button_Ent.Hide();
            button_empl.Hide();
            liste.Show();
            button_ajouter.Show();
           // button_ajouter_Click(sender, e, "Mission");
        }
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            button_valider.Show();
            //   int nbr_ligne = liste.Rows.Count;
            liste.AllowUserToAddRows = true;
            liste.ReadOnly = false;
           // liste
            /*  liste.row
              int index = liste.Rows.GetLastRow();*/
        }
       

    }
}
