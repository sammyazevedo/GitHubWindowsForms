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
            string mensagem = txtMensagem.Text;

            MessageBox.Show("Mensagem: " + mensagem,"Mensagem Saudação",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
