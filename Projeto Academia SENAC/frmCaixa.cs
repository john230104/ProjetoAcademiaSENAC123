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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void LimparDadosCai()
        {
            txtCaiCodigo.Clear();
            txtCaiDescricao.Clear();
            txtCaiNome.Clear();
            txtCaiValorTotal.Clear();
            mktCaiCPF.Clear();
        }
        private void btnCaiCadastros_Click(object sender, EventArgs e)
        {
            frmCadastro outroform = new frmCadastro();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCai();
            Close();
        }

        private void btnCaiAgendamentos_Click(object sender, EventArgs e)
        {
            frmAgendamentos outroform = new frmAgendamentos();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCai();
            Close();
        }

        private void btnCaiControle_Click(object sender, EventArgs e)
        {
            frmControle outroform = new frmControle();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCai();
            Close();
        }

        private void btnCaiVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCai();
            Close();
        }

        private void btnCaiLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosCai();
        }

        private void btnCaiPesquisar_Click(object sender, EventArgs e)
        {
            frmCaixaVisualizador outroform = new frmCaixaVisualizador();
            this.Hide();
            outroform.ShowDialog(); ;
        }

        private void btnCaiClose_Click(object sender, EventArgs e)
        {
            frmLoginn outroform = new frmLoginn();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCai();
            Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCaiRegistrar_Click(object sender, EventArgs e)
        {
            // Lógica de registro aqui
            
        }
    }
}
