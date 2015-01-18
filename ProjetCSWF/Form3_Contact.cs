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
    public partial class Form3_Contact : Form
    {
        public string nom;
        public string prenom;
        public string n_telephone;

        public Form3_Contact()
        {
            InitializeComponent();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            nom = textBox1.Text;
            prenom = textBox2.Text;
            n_telephone = textBox3.Text;
            this.Close();
        }
        public Contact getContact()
        {
            Contact contact = new Contact(nom, prenom, n_telephone);
            return contact;
        }
    }
}
