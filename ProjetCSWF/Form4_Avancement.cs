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
    public partial class Form4_Avancement : Form
    {
        public int risque;
        public DateTime date_edition;
        public Avancement avancement;
        public Mission mission;
        public DataGridView liste1;
        public int progression;

        public Form4_Avancement(Mission mission, DataGridView liste1)
        {
            this.mission = mission;
            this.liste1 = liste1;
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
            progressBar1.Refresh();
            this.Refresh();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            avancement = new Avancement((int)numericUpDown1.Value, dateTimePicker1.Value);
            mission.Risque = (int)numericUpDown3.Value;
            mission.avancements.Add(avancement);
            liste1.Refresh();
            this.Close();
        }
    }
}
