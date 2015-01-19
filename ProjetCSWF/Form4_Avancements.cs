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
    public partial class Form4_Avancements : Form
    {
        Mission mission;

        public Form4_Avancements(Mission mission)
        {
            this.mission = mission;
            InitializeComponent();
            dataGridView_avancements.Columns.Add("Avancement (%)", "Avancement (%)");
            dataGridView_avancements.Columns.Add("Date", "Date");

            dateTimePicker_de.Value = mission.debut;
            dateTimePicker_a.Value = mission.fin;

            int cpt = 0;
            foreach (Avancement a in mission.avancements)
            {
                dataGridView_avancements.Rows.Add(a.Pourcentage + "%", a.milestone);
                dataGridView_avancements.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }
        }

        private void dateTimePicker_de_ValueChanged(object sender, EventArgs e)
        {
            List<Avancement> trouvailles = mission.listAvancements(dateTimePicker_de.Value, dateTimePicker_a.Value);

            dataGridView_avancements.Rows.Clear();

            int cpt = 0;
            foreach (Avancement a in trouvailles)
            {
                dataGridView_avancements.Rows.Add(a.Pourcentage + "%", a.milestone);
                dataGridView_avancements.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }
        }

        private void dateTimePicker_a_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_de_ValueChanged(sender, e);
        }
    }
}
