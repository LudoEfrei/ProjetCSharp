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

            if (liste1.Rows[i-1].Cells[0].Value == null || f3add == null ||
                liste1.Rows[i-1].Cells[2].Value == null || f3cont == null)
            {
                MessageBox.Show(
                    "Saisie incomplète");
            }
            else
            {
                nom = liste1.Rows[i - 1].Cells[0].Value.ToString();
                adresse = f3add.getAdresse();
                n_siret = liste1.Rows[i - 1].Cells[2].Value.ToString();
                contact = f3cont.getContact();
                Entreprise nouvelle_ent = (new Entreprise(nom, adresse, n_siret, contact));
                entreprises.liste.Add(nouvelle_ent);
            }

            // Refresh

            liste1.Rows.Clear();

            int cpt = 0;
            foreach (Entreprise interim in entreprises.liste)
            {
                liste1.Rows.Add(interim.nom, interim.adresse, interim.n_siret, interim.contact.nom);
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            button_adresse.Hide();
            button_contact.Hide();
            button_Valider.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rechercher_TextChanged(object sender, EventArgs e)
        {
            liste1.Rows.Clear();
            if (textBox_rechercher.Text == "")
            {
                int cpt = 0;
                foreach (Entreprise i in entreprises.liste)
                {
                    liste1.Rows.Add(i.nom, i.adresse, i.n_siret, i.contact.nom);
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
            else
            {
                Entreprises trouvailles = entreprises.search(textBox_rechercher.Text);
                int cpt = 0;
                foreach (Entreprise i in trouvailles.liste)
                {
                    liste1.Rows.Add(i.nom, i.adresse, i.n_siret, i.contact.nom);
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
        }

        // Plus

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Etes-vous sur de vouloir supprimer ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index_supp = liste1.CurrentRow.Index;
                int cpt = 0;
                foreach (Entreprise i in entreprises.liste)
                {
                    if (cpt == index_supp)
                    {
                        entreprises.liste.Remove(i);
                        liste1.Rows.Clear();
                        int cpt1 = 0;
                        foreach (Entreprise i2 in entreprises.liste)
                        {
                            liste1.Rows.Add(i2.nom, i2.adresse, i2.n_siret, i2.contact.nom);
                            liste1.Rows[cpt1].HeaderCell.Value = (cpt1 + 1).ToString();
                            cpt1++;
                        }

                        return;
                    }
                    cpt++;

                }
            }

        }

        private void liste1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }  


    }
}
