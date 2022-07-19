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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double num1, num2, num3;

        private void txtNumDois_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtNumDois.Text);
        }

        private void txtNumTres_TextChanged(object sender, EventArgs e)
        {
            num3 = Convert.ToDouble(txtNumTres.Text);
        }
        private void txtNumUm_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNumUm.Text);
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            var lista = new List<double> { num1, num2, num3 };
            lista.Sort();

            for (int i = 0; i < lista.Count; i++)
            {
                txtResultado.Text += lista[i].ToString() + "\r\n";
            }
        }

      
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
       
          
            
        }      
    }
}
