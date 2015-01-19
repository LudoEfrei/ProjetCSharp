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
    public partial class Form4 : Form
    {
        public Missions missions;
        public Entreprises entreprises;
        public Interimaires interimaires;
        public Form4_addMiss f4add;
        public Form4_Avancement f4av;

        public Form4(Missions missions, Entreprises entreprises, Interimaires interimaires)
        {
            this.missions = missions;
            this.entreprises = entreprises;
            this.interimaires = interimaires;

            InitializeComponent();
            liste1.Columns.Add("Titre", "Titre");
            liste1.Columns.Add("Entreprise", "Entreprise");
            liste1.Columns.Add("Début", "Début");
            liste1.Columns.Add("Fin", "Fin");
            liste1.Columns.Add("Avancement", "Avancement");
            liste1.Columns.Add("Risque", "Risque");

            int cpt = 0;
            foreach (Mission i in missions.liste)
            {
                liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            
        }

        private void button_Ajouter_Click_1(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = true;
            liste1.ReadOnly = false;
            f4add = new Form4_addMiss(entreprises, interimaires, missions);
            button_Valider.Show();
            f4add.Show();
        }

        private void button_Valider_Click_1(object sender, EventArgs e)
        {

            liste1.AllowUserToAddRows = false;
            liste1.ReadOnly = true;

            try 
            {
                if (f4add.getMission().titre != null)
                {
                    missions.liste.Add(f4add.getMission());
                
                    //refresh
                    liste1.Rows.Clear();
                    int cpt = 0;
                    foreach (Mission i in missions.liste)
                    {
                        liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                        liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                        cpt++;
                    }
                }
                else
                {
                    MessageBox.Show("Saisie incomplète");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saisie incomplète");
                Console.WriteLine(ex);
            }

            button_Valider.Hide();

        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Etes-vous sur de vouloir supprimer ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index_supp = liste1.CurrentRow.Index;
                int cpt = 0;
                foreach (Mission i in missions.liste)
                {
                    if (cpt == index_supp)
                    {
                        missions.liste.Remove(i);
                        liste1.Rows.Clear();
                        int cpt1 = 0;
                        foreach (Mission i2 in missions.liste)
                        {
                            liste1.Rows.Add(i2.titre, i2.entreprise.nom, i2.debut, i2.fin, i2.avancements.Last(), i2.Risque.ToString() + "%");
                            liste1.Rows[cpt1].HeaderCell.Value = (cpt1 + 1).ToString();
                            cpt1++;
                        }

                        return;
                    }
                    cpt++;

                }
            }
        }

        private void button_editerfiche_Click(object sender, EventArgs e)
        {
            int index_selec = liste1.CurrentRow.Index;
            int cpt = 0;
            foreach (Mission i in missions.liste)
            {
                if (cpt == index_selec)
                {
                    f4av = new Form4_Avancement(i, liste1);
                }
                cpt++;
            }
            f4av.Show();
            this.Refresh();
        }

        // Plus

        private void textBox_rechercher_TextChanged(object sender, EventArgs e)
        {
            liste1.Rows.Clear();
           
            if (textBox_rechercher.Text == "")
            {
                int cpt = 0;
                foreach (Mission i in missions.liste)
                {
                    liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
            else
            {
                if (checkBox_interimaire.Checked == true)
                {
                    Missions trouvailles = missions.searchInterim(textBox_rechercher.Text);
                    int cpt = 0;
                    foreach (Mission i in trouvailles.liste)
                    {
                        liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                        liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                        cpt++;
                    }
                }
                else
                {
                    Missions trouvailles = missions.search(textBox_rechercher.Text);
                    int cpt = 0;
                    foreach (Mission i in trouvailles.liste)
                    {
                        liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                        liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                        cpt++;
                    }
                }
            }
        }

        private void checkBox_interimaire_CheckedChanged(object sender, EventArgs e)
        {
            textBox_rechercher_TextChanged(sender, e);
        }

        private void checkBox_risque_CheckedChanged(object sender, EventArgs e)
        {
            liste1.Rows.Clear();
            if (checkBox_risque.Checked == true)
            {
                Missions trouvailles = missions.searchRisqueGT(25);
                int cpt = 0;
                foreach (Mission i in trouvailles.liste)
                {
                    liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
            else
            {
                int cpt = 0;
                foreach (Mission i in missions.liste)
                {
                    liste1.Rows.Add(i.titre, i.entreprise.nom, i.debut, i.fin, i.avancements.Last(), i.Risque.ToString() + "%");
                    liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                    cpt++;
                }
            }
        }

        private void button_avancements_Click(object sender, EventArgs e)
        {
            int index = liste1.CurrentRow.Index;
            string critere = liste1.Rows[index].Cells[0].Value.ToString();

            Form4_Avancements f4_avancements = new Form4_Avancements(missions.search(critere).liste[0]);
            f4_avancements.Show();
        }

        // Editer une facture
        private void button_facturer_Click(object sender, EventArgs e)
        {
            int index = liste1.CurrentRow.Index;
            string critere = liste1.Rows[index].Cells[0].Value.ToString();
            if (missions.search(critere).liste[0].fin > DateTime.Today)
            {
                MessageBox.Show(
                    "La mission n'est pas terminée, il n'y a pas de facture.",
                    "Facture inexistante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Form4_Facturer f4_facturer = new Form4_Facturer(missions.search(critere).liste[0]);
                f4_facturer.Show();
            } 
        }
    }
}
