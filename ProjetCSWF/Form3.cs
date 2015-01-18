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
    public partial class Form3 : Form
    {
        public Entreprises entreprises;
        public string nom;
        public Adresse adresse;
        public string n_siret;
        public Contact contact;
        public Form3_Adresse f3add;
        public Form3_Contact f3cont;

        public Form3(Entreprises entreprises)
        {
            this.entreprises = entreprises;
            InitializeComponent();
            liste1.Columns.Add("Nom", "Nom");
            liste1.Columns.Add("Adresse", "Adresse");
            liste1.Columns.Add("N°Siret", "N°Siret");
            liste1.Columns.Add("Contact", "Contact");

            int cpt = 0;
            foreach (Entreprise i in entreprises.liste)
            {
                liste1.Rows.Add(i.nom, i.adresse, i.n_siret, i.contact.nom);
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

        }

        private void button_Ajouter_Click_1(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = true;
            liste1.ReadOnly = false;
            button_Valider.Show();
            button_adresse.Show();
            button_contact.Show();
        }

        private void button_Valider_Click_1(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = false;
            liste1.ReadOnly = true;
            int i = liste1.RowCount;
            nom = liste1.Rows[i-1].Cells[0].Value.ToString();
            adresse = f3add.getAdresse();
            n_siret = liste1.Rows[i - 1].Cells[2].Value.ToString();
            contact = f3cont.getContact();
            Entreprise nouvelle_ent=(new Entreprise(nom,adresse,n_siret,contact));
            entreprises.liste.Add(nouvelle_ent);
            
        }

        private void button_adresse_Click(object sender, EventArgs e)
        {
            f3add = new Form3_Adresse();
            f3add.Show();
        }

        private void button_contact_Click(object sender, EventArgs e)
        {
            f3cont = new Form3_Contact();
            f3cont.Show();
        }  


    }
}
