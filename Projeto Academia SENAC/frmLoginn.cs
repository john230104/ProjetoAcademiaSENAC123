using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Academia_SENAC
{
    public partial class frmLoginn : Form
    {
        public frmLoginn()
        {
            InitializeComponent();
        }

        private void btnLoginSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
