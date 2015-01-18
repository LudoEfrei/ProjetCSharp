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
    public partial class Form3_Adresse : Form
    {
        public string rue;
        public string ville;
        public string CP;
        public string pays;

        public Form3_Adresse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rue = textBox1.Text;
            ville = textBox2.Text;
            CP = textBox3.Text;
            pays = textBox4.Text;
            this.Close();
        }

        public Adresse getAdresse()
        {
            Adresse adresse = new Adresse(pays, ville, rue, CP);
            return adresse;
        }
    }
}
