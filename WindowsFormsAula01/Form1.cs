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
            

            if (!txtMensagem.Text.Equals(""))
            {
                MessageBox.Show("Mensagem: " + txtMensagem.Text, "Mensagem Saudação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Preencha o campo!");
            }
            
            
        }
    }
}
