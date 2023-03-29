using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_e_senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "Pedro" && TextBoxSenha.Text == "pedro@14")
            {
                MessageBox.Show("Bem Vindo ao sistema!", "Acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso Negado !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
