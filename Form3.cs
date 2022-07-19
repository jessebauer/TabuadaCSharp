using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            lblPosOuNeg.Text = Convert.ToDouble(txtVisor.Text) > 0 ? "Positivo" : "Negativo";
            String parOuImpar = Convert.ToDouble(txtVisor.Text) % 2 == 0 ? "Par" : "Impar";
            lblPosOuNeg.Text += " e " + parOuImpar;
        }
    }
}
