using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Academia_SENAC
{
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }

        private void LimparDadosCon()
        {
            txtConPonNome.Clear();
            txtConPonCodigo.Clear();
            mktConPonHoraEntrada.Clear();
            mktConPonHoraSaida.Clear();
            mktConPonHorasNegativas.Clear();
            mktConPonHorasPositiva.Clear();
            mktConPonData.Clear();
        }
        private void frmControle_Load(object sender, EventArgs e)
        {

        }

        private void btnContClose_Click(object sender, EventArgs e)
        {
            frmLoginn outroform = new frmLoginn();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCon();
            Close();
        }

        private void btnConPonVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCon();
            Close();
        }

        private void btnConCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro outroform = new frmCadastro();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCon();
            Close();
        }

        private void btnConAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendamentos outroform = new frmAgendamentos();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCon();
            Close();
        }

        private void btnConCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa outroform = new frmCaixa();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosCon();
            Close();
        }

        private void btnConPonLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosCon();
        }

        private void btnConPonPesquisar_Click(object sender, EventArgs e)
        {
            frmControledePonto outroform = new frmControledePonto();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnConAceVisualizar_Click(object sender, EventArgs e)
        {
            frmControledeAcesso outroform = new frmControledeAcesso();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnConPonCadastrar_Click(object sender, EventArgs e)
        {
            if (txtConPonCodigo.Text.Trim().Length == 0)
            {
                erpPreencherCamposMan.SetError(txtConPonCodigo, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposMan.SetError(txtConPonCodigo, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into Manutencao (Pon_Nome, Fun_Codigo, Pon_Data, Pon_HoraEnt, Pon_HoraSai, Pon_HoraPos, Pon_HoraNeg)
			                    values (@nome, @funCodigo, @horaEntrada, @horaSaida, @data, @horaNegativa, @horaPositiva)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtConPonNome.Text);
                cmd.Parameters.AddWithValue("horaEntrada", mktConPonHoraEntrada.Text);
                cmd.Parameters.AddWithValue("horaSaida", mktConPonHoraSaida.Text);
                cmd.Parameters.AddWithValue("data", mktConPonData.Text);
                cmd.Parameters.AddWithValue("horaNegativa", mktConPonHorasNegativas.Text);
                cmd.Parameters.AddWithValue("horaPositiva", mktConPonHorasPositiva.Text);
                cmd.Parameters.AddWithValue("codFuncionario", txtConPonCodigo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
