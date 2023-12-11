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
    public partial class frmManutençao : Form
    {
        public frmManutençao()
        {
            InitializeComponent();
        }

        private void BtnCadClose_Click(object sender, EventArgs e)
        {
            frmAgendamentos outroform = new frmAgendamentos();
            this.Hide();
            outroform.ShowDialog();
            Close();
        }
    }
}
