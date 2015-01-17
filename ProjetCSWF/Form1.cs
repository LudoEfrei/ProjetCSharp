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

        public Form1(Interimaires interimaires)
        {
            InitializeComponent();
            this.interimaires = interimaires;
        }


        private void Employés_Click(object sender, EventArgs e)
        {
            foreach (EmployeInterim i in interimaires.liste)
            {
                //Console.WriteLine(i);
                liste_emp.Columns.Add(i.nom,i.nom);
                liste_emp.Rows.Add("salut");
                
            }
           // liste_emp.Columns.Add("coucou", "coucou");
            //liste_emp.Rows.Add("salut", 4);
            
            Missions.Hide();
            Entreprises.Hide();
            Employés.Hide();
        }


        






    }
}
