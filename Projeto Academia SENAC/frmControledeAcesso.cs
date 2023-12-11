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
    public partial class frmControledeAcesso : Form
    {
        public frmControledeAcesso()
        {
            InitializeComponent();
        }

        private void BtnCadClose_Click(object sender, EventArgs e)
        {
            frmControle outroform = new frmControle();
            this.Hide();
            outroform.ShowDialog();
            Close();
        }
    }
}
