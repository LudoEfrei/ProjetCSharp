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
    public partial class Form1 : Form
    {
        public Interimaires interimaires;
        public Entreprises entreprises;
        public Missions missions;

        public Form1(Interimaires interimaires,Entreprises entreprises, Missions missions)
        {
            InitializeComponent();
            this.interimaires = interimaires;
            this.entreprises = entreprises;
            this.missions = missions;

        }


        private void button_empl_Click(object sender, EventArgs e)
        {   
            Form2 f2 = new Form2(interimaires);
            f2.Show();
        }

        private void button_Ent_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(entreprises);
            f3.Show();
        }

        private void button_miss_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(missions,entreprises,interimaires);
            f4.Show();
        }
          
    }
}
