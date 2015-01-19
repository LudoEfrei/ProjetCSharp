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
    public partial class Form2 : Form
    {
        Interimaires interimaires;
        public Form2(Interimaires interimaires)
        {
            this.interimaires=interimaires;
            InitializeComponent();
            liste1.Columns.Add("Nom", "Nom");
            liste1.Columns.Add("Prénom", "Prenom");
            liste1.Columns.Add("N°tel", "N°tel");
            liste1.Columns.Add("Age", "Age");
            liste1.Columns.Add("Compétences", "Compétences");

            int cpt = 0;
            foreach (EmployeInterim i in interimaires.liste)
            {
                liste1.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = true;
            liste1.ReadOnly = false;
            button_valider.Show();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = false;
            liste1.ReadOnly = true;
            int i = liste1.RowCount;

            try
            {
                if (liste1.Rows[i - 1].Cells[0].Value == null || liste1.Rows[i - 1].Cells[1].Value == null ||
                liste1.Rows[i - 1].Cells[2].Value == null || liste1.Rows[i - 1].Cells[3].Value == null ||
                liste1.Rows[i].Cells[0].Value == null || liste1.Rows[i].Cells[1].Value == null ||
                liste1.Rows[i].Cells[2].Value == null || liste1.Rows[i].Cells[3].Value == null)
                {
                    MessageBox.Show(
                        "Saisie incomplète");
                }
                else
                {
                    string nom = liste1.Rows[i - 1].Cells[0].Value.ToString();
                    string prenom = liste1.Rows[i - 1].Cells[1].Value.ToString();
                    string n_telephone = liste1.Rows[i - 1].Cells[2].Value.ToString();
                    int age = Int32.Parse(liste1.Rows[i - 1].Cells[3].Value.ToString());
                    EmployeInterim nouveau_empl = (new EmployeInterim(nom, prenom, n_telephone, age));
                    interimaires.liste.Add(nouveau_empl);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(
                        "Saisie incomplète");
            }
            

            // Refresh
            liste1.Rows.Clear();

            int cpt = 0;
            foreach (EmployeInterim interim in interimaires.liste)
            {
                liste1.Rows.Add(interim.nom, interim.prenom, interim.n_telephone, interim.age, interim.listComp());
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            button_valider.Hide();
        }

        private void textBox_rechercher_TextChanged(object sender, EventArgs e)
        {
            liste1.Rows.Clear();
            if (textBox_rechercher.Text == "")
            {
                int cpt = 0;
                foreach (EmployeInterim i in interimaires.liste)
                {
                    liste1.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
            else
            {
                if (checkBox_competences.Checked == true)
                {
                    Interimaires trouvailles = interimaires.searchComp(textBox_rechercher.Text);
                    int cpt = 0;
                    foreach (EmployeInterim i in trouvailles.liste)
                    {
                        liste1.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                        liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                        cpt++;
                    }
                }
                else
                {
                    Interimaires trouvailles = interimaires.search(textBox_rechercher.Text);
                    int cpt = 0;
                    foreach (EmployeInterim i in trouvailles.liste)
                    {
                        liste1.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                        liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                        cpt++;
                    }
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
                foreach (EmployeInterim i in interimaires.liste)
                {
                    if (cpt == index_supp)
                    {
                        interimaires.liste.Remove(i);
                        liste1.Rows.Clear();
                        int cpt1 = 0;
                        foreach (EmployeInterim i2 in interimaires.liste)
                        {
                            liste1.Rows.Add(i2.nom, i2.prenom, i2.n_telephone, i2.age, i2.listComp());
                            liste1.Rows[cpt1].HeaderCell.Value = (cpt1 + 1).ToString();
                            cpt1++;
                        }

                        return;
                    }
                    cpt++;

                }
            }

        }

        private void checkBox_competences_CheckedChanged(object sender, EventArgs e)
        {
            textBox_rechercher_TextChanged(sender, e);
        }
    }
}
