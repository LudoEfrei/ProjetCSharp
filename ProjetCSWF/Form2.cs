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
    public partial class Form2 : Form
    {
        Interimaires interimaires;
        public Form2(Interimaires interimaires)
        {
            this.interimaires=interimaires;
            InitializeComponent();
            liste1.Columns.Add("Nom", "Nom");
            liste1.Columns.Add("Prénom", "Prenom");
            liste1.Columns.Add("N°tel", "N°tel");
            liste1.Columns.Add("Age", "Age");
            liste1.Columns.Add("Compétences", "Compétences");

            int cpt = 0;
            foreach (EmployeInterim i in interimaires.liste)
            {
                liste1.Rows.Add(i.nom, i.prenom, i.n_telephone, i.age, i.listComp());
                liste1.Rows[cpt].HeaderCell.Value = (cpt + 1).ToString();
                cpt++;
            }

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = true;
            liste1.ReadOnly = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            liste1.AllowUserToAddRows = false;
            liste1.ReadOnly = true;
            int i = liste1.RowCount;
            string nom = liste1.Rows[i-1].Cells[0].Value.ToString();
            string prenom = liste1.Rows[i - 1].Cells[1].Value.ToString();
            string n_telephone = liste1.Rows[i - 1].Cells[2].Value.ToString();
            int age = Int32.Parse(liste1.Rows[i - 1].Cells[3].Value.ToString());
            EmployeInterim nouveau_empl=(new EmployeInterim(nom,prenom,n_telephone,age));
            interimaires.liste.Add(nouveau_empl);
        }
            


    }
}
