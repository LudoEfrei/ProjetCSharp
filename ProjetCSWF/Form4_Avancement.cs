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
        public Form4_Avancement()
        {
            InitializeComponent();
        }
        public void Progression(int valeurprogression)
        {
            progressBar1.Value = valeurprogression;//(int)numericUpDown1.Value;
        }
    }
}
