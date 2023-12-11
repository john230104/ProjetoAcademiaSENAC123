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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
        }

        private void BtnCadClose_Click(object sender, EventArgs e)
        {
            frmCadastro outroform = new frmCadastro();
            this.Hide();
            outroform.ShowDialog();
            Close();
        }
    }
}
