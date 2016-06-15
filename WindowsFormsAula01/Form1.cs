using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            int result = 0; 
               
            if(!string.IsNullOrEmpty(txtMensagem.Text) && !string.IsNullOrEmpty(txtNum1.Text))
            //if (!txtMensagem.Text.Equals(""))
            {
                result = Convert.ToInt32(txtMensagem.Text) + Convert.ToInt32(txtNum1.Text);
                MessageBox.Show("Resultado: " + result.ToString(), "Calcular soma de inteiros", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                lblResultado.Text = result.ToString();
            }

            else
            {
                MessageBox.Show("Preencha o campo!");
            }
            
            
        }
    }
}
