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
       Missions missions;
        public Form4(Missions missions)
        {
            this.missions = missions;
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
            button_Valider.Show();
        }

        private void button_Valider_Click_1(object sender, EventArgs e)
        {
            /* liste1.AllowUserToAddRows = false;
            liste1.ReadOnly = true;
            int i = liste1.RowCount;
            string nom = liste1.Rows[i-1].Cells[0].Value.ToString();
            string prenom = liste1.Rows[i - 1].Cells[1].Value.ToString();
            string n_telephone = liste1.Rows[i - 1].Cells[2].Value.ToString();
            int age = Int32.Parse(liste1.Rows[i - 1].Cells[3].Value.ToString());
            EmployeInterim nouveau_empl=(new EmployeInterim(nom,prenom,n_telephone,age));
            interimaires.liste.Add(nouveau_empl);
            * */
        }
    }
}
