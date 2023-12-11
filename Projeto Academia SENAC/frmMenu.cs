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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoginn outroform = new frmLoginn();
            this.Hide();
            outroform.ShowDialog();
            Close();
        }

       

        private void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro outroform = new frmCadastro();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnMenuAgend_Click(object sender, EventArgs e)
        {
            frmAgendamentos outroform = new frmAgendamentos();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnMenuControle_Click(object sender, EventArgs e)
        {
            frmControle outroform = new frmControle();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnMenuCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa outroform = new frmCaixa();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
