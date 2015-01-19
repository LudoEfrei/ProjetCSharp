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
    public partial class Form4_Facturer : Form
    {
        public Form4_Facturer(Mission mission)
        {
            InitializeComponent();
            dataGridView_mission.Columns.Add("Titre", "Titre");
            dataGridView_mission.Columns.Add("Entreprise", "Entreprise");
            dataGridView_mission.Columns.Add("Début", "Début");
            dataGridView_mission.Columns.Add("Fin", "Fin");
            dataGridView_mission.Columns.Add("Avancement", "Avancement");
            dataGridView_mission.Columns.Add("Risque", "Risque");

            dataGridView_mission.Rows.Add(mission.titre, mission.entreprise.nom, mission.debut, mission.fin, mission.avancements.Last(), mission.Risque.ToString() + "%");
            dataGridView_mission.Rows[0].HeaderCell.Value = (1).ToString();

            int joursTotaux = (int)((mission.fin - mission.debut).TotalDays);

            label_jours.Text = joursTotaux.ToString();

            textBox_salaire.Text = (joursTotaux * mission.interimaire.tarif).ToString();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
