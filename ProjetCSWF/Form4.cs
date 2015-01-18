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
            f4add = new Form4_addMiss(entreprises, interimaires);

        }

        private void button_Ajouter_Click_1(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = true;
            liste1.ReadOnly = false;
            button_Valider.Show();
            f4add.Show();
        }

        private void button_Valider_Click_1(object sender, EventArgs e)
        {
            missions.liste.Add(f4add.getMission());
            this.Close();
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
            f4av = new Form4_Avancement();
            f4av.Progression(50);
            f4av.Show();

        }
    }
}
