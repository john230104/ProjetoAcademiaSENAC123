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
    public partial class frmAgendamentos : Form
    {
        public frmAgendamentos()
        {
            InitializeComponent();
        }

        private void LimparDadosAge()
        {
            // Tbl Agendamento
            txtAgeManRazaoSocial.Clear();
            mktAgeManCnpj.Clear();
            txtAgeManCodigo.Clear();
            mktAgeManData.Clear();
            txtAgeManAparelho.Clear();
            txtAgeManIdentificacao.Clear();
            txtAgeManDescricao.Clear();
            // Tbl Consulta
            txtAgeConNome.Clear();
            mktAgeConCPF.Clear();
            mktAgeConData.Clear();
            mktAgeConHorario.Clear();
            txtAgeConProfissional.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoginn outroform = new frmLoginn();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro outroform = new frmCadastro();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeManVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeControle_Click(object sender, EventArgs e)
        {
            frmControle outroform = new frmControle();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa outroform = new frmCaixa();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeManLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosAge();
        }

        private void btnAgeManPesquisar_Click(object sender, EventArgs e)
        {
            frmManutençao outroform = new frmManutençao();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnAgeConVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDadosAge();
            Close();
        }

        private void btnAgeConLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosAge();
        }

        private void btnAgeConPesquisar_Click(object sender, EventArgs e)
        {
            frmConsulta outroform = new frmConsulta();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnAgeManCadastrar_Click(object sender, EventArgs e)
        {
            if (txtAgeManRazaoSocial.Text.Trim().Length == 0)
            {
                erpPreencherCamposMan.SetError(txtAgeManRazaoSocial, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposMan.SetError(txtAgeManRazaoSocial, "");
            }

            if (mktAgeManCnpj.Text.Trim().Length == 0)
            {
                erpPreencherCamposMan.SetError(txtAgeManRazaoSocial, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposMan.SetError(txtAgeManCodigo, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into Manutencao (Man_RazaoSoc, Man_CNPJ, Man_Data, Man_Aparelho, Eq_Identificacao, Man_Descricao)
			                    values (@razaosoc, @cnpj, @data, @aparelho, @identificacao, @descricao)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("razaosoc", txtAgeManRazaoSocial.Text);
                cmd.Parameters.AddWithValue("cnpj", mktAgeManCnpj.Text);
                cmd.Parameters.AddWithValue("data", mktAgeManData.Text);
                cmd.Parameters.AddWithValue("aparelho", txtAgeManAparelho.Text);
                cmd.Parameters.AddWithValue("identificacao", txtAgeManIdentificacao.Text);
                cmd.Parameters.AddWithValue("descricao", txtAgeManDescricao.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAgeConCadastrar_Click(object sender, EventArgs e)
        {
            if (mktAgeConCPF.Text.Trim().Length == 0)
            {
                erpPreencherCamposCon.SetError(mktAgeConCPF, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposCon.SetError(mktAgeConCPF, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into Consulta (Con_Nome, Alu_CPF, Con_Data, Con_Horario, Con_Profissional)
			     values (@nome, @cpf, @data, @horario, @profissional)";

            
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtAgeConNome.Text);
                cmd.Parameters.AddWithValue("cpf", mktAgeConCPF.Text);
                cmd.Parameters.AddWithValue("data", mktAgeConData.Text);
                cmd.Parameters.AddWithValue("horario", mktAgeConHorario.Text);
                cmd.Parameters.AddWithValue("profissional", txtAgeConProfissional.Text);

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
