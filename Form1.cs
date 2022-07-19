namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int num, tab;
                try
            {
                num = Convert.ToInt32(txtNumero.Text);
                for (int i = 0; i <= 10; i++)
                {
                    tab = i * num;
                    tabuadaAqui.Items.Add(num + " * " + i + " = " + tab);
                }
            } catch { }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            try
            {
                tabuadaAqui.Items.Clear();
            }
            catch { }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }
    }
}