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
    public partial class Form4_addMiss : Form
    {

        public string titre;
        public Entreprise entreprise;
        public EmployeInterim interimaire;
        public DateTime debut;
        public DateTime fin;
        public Entreprises entreprises;
        public Interimaires interimaires;
        public Missions missions;

        public Form4_addMiss(Entreprises entreprises, Interimaires interimaires, Missions missions)
        {
            InitializeComponent();
            this.entreprises = entreprises;
            this.interimaires = interimaires;
            this.missions = missions;
            liste_ent.Columns.Add("Nom", "Nom");

            int cpt = 0;
            foreach (Entreprise i in entreprises.liste)
            {
                liste_ent.Rows.Add(i.nom);
                liste_ent.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

            liste_interim.Columns.Add("Nom", "Nom");

            cpt = 0;
            foreach (EmployeInterim i in interimaires.liste)
            {
                liste_interim.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                liste_interim.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            titre = textBox2.Text;
            string tempEnt = liste_ent.CurrentCell.Value.ToString();    
            foreach (Entreprise i in entreprises.liste)
            {
                if (i.nom == tempEnt)
                {
                    entreprise = i;
                }
            }

            string tempint = liste_interim.CurrentCell.Value.ToString();
            foreach (EmployeInterim i in interimaires.liste)
            {
                if (i.nom == tempint)
                {
                    interimaire = i;
                }
            }
            debut = dateTimePicker1.Value;
            fin = dateTimePicker2.Value;

            Mission missionTest = new Mission(titre, entreprise, interimaire, debut, fin);

            if (missionTest.embaucher(missions, interimaire)) 
            {
                this.Close();
            }  
            else
            {
                MessageBox.Show(
                    "L'intérimaire est déjà pris pour ces dates là.",
                    "Erreur, intérimaire indisponible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        public Mission getMission()
        {
            Mission mission = new Mission(titre, entreprise, interimaire, debut, fin);
            return mission;
        }

    }
}
