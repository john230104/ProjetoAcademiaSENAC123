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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        public void LocalizarCEP()
        {
            using(var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mktCadAluCEP.Text);
                    cmbCadAluCidade.Text = resultado.cidade;
                    cmbCadAluEstado.Text = resultado.uf;
                    txtCadAluRua.Text = resultado.end;
                    txtCadAluBairro.Text = resultado.bairro;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                } 
            }
        }

        public void LocalizarCEPFor()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mktCadForCEP.Text);
                    cmbCadForCidade.Text = resultado.cidade;
                    cmbCadForEstado.Text = resultado.uf;
                    txtCadForRua.Text = resultado.end;
                    txtCadForBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public void LocalizarCEPTer()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mktCadTerCEP.Text);
                    cmbCadTerCidade.Text = resultado.cidade;
                    cmbCadTerEstado.Text = resultado.uf;
                    txtCadTerRua.Text = resultado.end;
                    txtCadTerBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public void LocalizarCEPFun()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mktCadFunCEP.Text);
                    cmbCadFunCidade.Text = resultado.cidade;
                    cmbCadFunEstado.Text = resultado.uf;
                    txtCadFunRua.Text = resultado.end;
                    txtCadFunBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void LimparDados()
        {
            // Tbl Alunos
            txtCadAluNome.Clear();
            txtCadAluBairro.Clear();
            txtCadAluComplemento.Clear();
            txtCadAluEmail.Clear();
            txtCadAluNumero.Clear();
            txtCadAluRua.Clear();
            mktCadAluCelular.Clear();
            mktCadAluCEP.Clear();
            mktCadAluCPF.Clear();
            mktCadAluDataCadastro.Clear();
            mktCadAluDataNasc.Clear();
            cmbCadAluCidade.Text = String.Empty;
            cmbCadAluEstado.Text = String.Empty;
            // Tbl Produtos
            txtCadProCodigo.Clear();
            txtCadProDescricao.Clear();
            txtCadProFabricante.Clear();
            txtCadProFornecedor.Clear();
            txtCadProQuantidade.Clear();
            txtCadProValorUni.Clear();
            mktCadProValidade.Clear();
            // TblFornecedores
            txtCadForRazaoSocial.Clear();
            txtCadForCNPJ.Clear();
            txtCadForContato.Clear();
            txtCadForCodigo.Clear();
            txtCadForEmail.Clear();
            mktCadForFone.Clear();
            mktCadForCEP.Clear();
            txtCadForRua.Clear();
            txtCadForNumero.Clear();
            txtCadForComplemento.Clear();
            txtCadForBairro.Clear();
            cmbCadForCidade.Text = String.Empty;
            cmbCadForEstado.Text = String.Empty;
            // Tbl Terceirizados
            txtCadTerRazaoSocial.Clear();
            txtCadTerCNPJ.Clear();
            txtCadTerContato.Clear();
            txtCadTerCodigo.Clear();
            txtCadTerEmail.Clear();
            mktCadTerFone.Clear();
            mktCadTerCEP.Clear();
            txtCadTerRua.Clear();
            txtCadTerNumero.Clear();
            txtCadTerComplemento.Clear();
            txtCadTerBairro.Clear();
            cmbCadTerCidade.Text = String.Empty;
            cmbCadTerEstado.Text = String.Empty;
            // Tbl Funcionarios
            txtCadFunNome.Clear();
            txtCadFunCodigo.Clear();
            txtCadFunEmail.Clear();
            mktCadFunCPF.Clear();
            mktCadFunDataInicio.Clear();
            mktCadFunDataNasc.Clear();
            mktCadFunCelular.Clear();
            mktCadFunCEP.Clear();
            txtCadFunRua.Clear();
            txtCadFunNumero.Clear();
            txtCadFunComplemento.Clear();
            txtCadFunBairro.Clear();
            cmbCadFunCargo.Text = String.Empty;
            cmbCadFunCidade.Text = String.Empty;
            cmbCadFunEstado.Text = String.Empty;
            // Tbl Equipamentos
            txtCadEqIdentificacao.Clear();
            txtCadEqModelo.Clear();
            txtCadEqPeso.Clear();
            txtCadEqFabricante.Clear();
            txtCadEqLinha.Clear();
            txtCadEqSolda.Clear();
            txtCadEqEstofamento.Clear();
            mktCadEqGarantia.Clear();
            txtCadEqEstrutura.Clear();
            txtCadEqDescricao.Clear();
            mktCadEqDataCompra.Clear();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadAluVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();

        }

        private void BtnCadClose_Click(object sender, EventArgs e)
        {
            frmLoginn outroform = new frmLoginn();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadAluLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void PesquisaAlunos(string cpf)
        {

            if (!string.IsNullOrEmpty(cpf))
            {
                Conexao.Conectar();
                string query = "SELECT * FROM Alunos WHERE Alu_CPF = @cpf";

                using (SqlCommand command = new SqlCommand(query, Conexao.conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PreencherAlunos(reader);
                        }
                    }
                }
            }
        }

        private void PesquisaProdutos(string codigo)
        {

            if (!string.IsNullOrEmpty(codigo))
            {
                Conexao.Conectar();
                string query = "SELECT * FROM Produtos WHERE Pro_Codigo = @codigo";

                using (SqlCommand command = new SqlCommand(query, Conexao.conn))
                {
                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PreencherProdutos(reader);
                        }
                    }
                }
            }
        }

        private void PesquisaFornecedores(string codigof)
        {

            if (!string.IsNullOrEmpty(codigof))
            {
                Conexao.Conectar();
                string query = "SELECT * FROM Fornecedores WHERE For_Codigo = @codigof";

                using (SqlCommand command = new SqlCommand(query, Conexao.conn))
                {
                    command.Parameters.AddWithValue("@codigof", codigof);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PreencherFornecedores(reader);
                        }
                    }
                }
            }
        }

        private void PesquisaFuncionarios(string codigofu)
        {

            if (!string.IsNullOrEmpty(codigofu))
            {
                Conexao.Conectar();
                string query = "SELECT * FROM Funcionarios WHERE Fun_Codigo = @codigofu";

                using (SqlCommand command = new SqlCommand(query, Conexao.conn))
                {
                    command.Parameters.AddWithValue("@codigofu", codigofu);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PreencherFuncionarios(reader);
                        }
                    }
                }
            }
        }


        private void PreencherAlunos(SqlDataReader reader)
        {
            txtCadAluNome.Text = reader["Alu_Nome"].ToString();
            mktCadAluDataNasc.Text = reader["Alu_DataNascimento"].ToString();
            mktCadAluDataCadastro.Text = reader["Alu_DataCadastro"].ToString();
            mktCadAluCelular.Text = reader["Alu_Celular"].ToString();
            txtCadAluEmail.Text = reader["Alu_Email"].ToString();
            mktCadAluCEP.Text = reader["Alu_CEP"].ToString();
            txtCadAluRua.Text = reader["Alu_Rua"].ToString();
            txtCadAluComplemento.Text = reader["Alu_Complemento"].ToString();
            txtCadAluNumero.Text = reader["Alu_Numero"].ToString();
            txtCadAluBairro.Text = reader["Alu_Bairro"].ToString();
            cmbCadAluCidade.Text = reader["Alu_Cidade"].ToString();
            cmbCadAluEstado.Text = reader["Alu_Estado"].ToString();
        }

        private void PreencherFuncionarios(SqlDataReader reader)
        {
            txtCadFunNome.Text = reader["Fun_Nome"].ToString();
            mktCadFunCPF.Text = reader["Fun_CPF"].ToString();
            txtCadFunEmail.Text = reader["Fun_Email"].ToString();
            mktCadFunCelular.Text = reader["Fun_Celular"].ToString();
            mktCadFunDataNasc.Text = reader["Fun_DataNascimento"].ToString();
            mktCadFunDataInicio.Text = reader["Fun_DataInicio"].ToString();
            cmbCadFunCargo.Text = reader["Fun_Cargo"].ToString();
            mktCadFunCEP.Text = reader["Fun_CEP"].ToString();
            cmbCadFunEstado.Text = reader["Fun_Estado"].ToString();
            cmbCadFunCidade.Text = reader["Fun_Cidade"].ToString();
            txtCadFunRua.Text = reader["Fun_Rua"].ToString();
            txtCadFunNumero.Text = reader["Fun_Numero"].ToString();
            txtCadFunComplemento.Text = reader["Fun_Complemento"].ToString();
            txtCadFunBairro.Text = reader["Fun_Bairro"].ToString();
        }

        private void PreencherFornecedores(SqlDataReader reader)
        {
            txtCadForRazaoSocial.Text = reader["For_Razao"].ToString();
            txtCadForCNPJ.Text = reader["For_CNPJ"].ToString();
            txtCadForContato.Text = reader["For_Contato"].ToString();
            txtCadForEmail.Text = reader["For_Email"].ToString();
            mktCadForFone.Text = reader["For_Fone"].ToString();
            mktCadForCEP.Text = reader["For_CEP"].ToString();
            cmbCadForEstado.Text = reader["For_Estado"].ToString();
            cmbCadForCidade.Text = reader["For_Cidade"].ToString();
            txtCadForRua.Text = reader["For_Rua"].ToString();
            txtCadForNumero.Text = reader["For_Numero"].ToString();
            txtCadForComplemento.Text = reader["For_Complemento"].ToString();
            txtCadForBairro.Text = reader["For_Bairro"].ToString();
        }

        private void PreencherProdutos(SqlDataReader reader)
        {
            txtCadProQuantidade.Text = reader["Pro_Quantidade"].ToString();
            txtCadProDescricao.Text = reader["Pro_Descricao"].ToString();
            txtCadProFornecedor.Text = reader["Pro_Fornecedor"].ToString();
            txtCadProFabricante.Text = reader["Pro_Fabricante"].ToString();
            mktCadProValidade.Text = reader["Pro_Validade"].ToString();
            txtCadProValorUni.Text = reader["Pro_ValorUnitario"].ToString();
        }
        private void btnCadAluPesquisar_Click(object sender, EventArgs e)
        {   
            if (mktCadAluCPF.Text.Replace(",","").Replace("-","").Replace(" ","") == "")
            {
                frmAlunos outroform = new frmAlunos();
                this.Hide();
                outroform.ShowDialog();
            }
            else
            {
                PesquisaAlunos(mktCadAluCPF.Text);
            }
            //Alunos.Codigo = "";
            //frmCadastro pesq = new frmCadastro();
            //pesq.ShowDialog();
            //if (Alunos.Codigo != "")
            //{
            //    txtCadAluNome.Text = Alunos.Nome;
            //    mktCadAluCPF.Text = Alunos.Email;
            //    mktCadAluCelular.Text = Alunos.Celular;
            //    mktCadAluDataNasc.Text = Alunos.Profissao;
            //    mktCadAluDataCadastro.Text = Alunos.CEP;
            //    mktCadAluCEP.Text = Alunos.Estado;
            //    cmbCadAluEstado.Text = Alunos.Cidade;
            //    cmbCadAluCidade.Text = Alunos.Rua;
            //    txtCadAluRua.Text = Alunos.Numero;
            //    txtCadAluNumero.Text = Alunos.Complemento;
            //    txtCadAluComplemento.Text = Alunos.Bairro;
            //    txtCadAluBairro.Text = Alunos.Bairro;

            //    // Habilitar os botões Alterar e Excluir
            //    btnCadAluAlterar.Enabled = true;
            //    btnCadAluApagar.Enabled = true;
            //    // Desabilita o botão Cadastrar
            //    btnCadAluCadastrar.Enabled = false;
            //}
            

        }

        private void btnCadProVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadProPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCadProCodigo.Text == "")
            {
                frmAlunos outroform = new frmAlunos();
                this.Hide();
                outroform.ShowDialog();
            }
            else
            {
                PesquisaProdutos(txtCadProCodigo.Text);
            }
            
        }

        private void btnCadProLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadForPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCadForCodigo.Text == "")
            {
                frmFornecedores outroform = new frmFornecedores();
                this.Hide();
                outroform.ShowDialog();
            }
            else
            {
                PesquisaFornecedores(txtCadForCodigo.Text);
            }
        }

        private void btnCadForVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadForLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadTerLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadTerVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadTerPesquisar_Click(object sender, EventArgs e)
        {
            frmTerceirizados outroform = new frmTerceirizados();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnCadFunLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadFunPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCadFunCodigo.Text == "")
            {
                frmFuncionarios outroform = new frmFuncionarios();
                this.Hide();
                outroform.ShowDialog();
            }
            else
            {
                PesquisaFuncionarios(txtCadFunCodigo.Text);
            }
        }

        private void btnCadFunVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadEqLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnCadEqPesquisar_Click(object sender, EventArgs e)
        {
            frmEquipamento outroform = new frmEquipamento();
            this.Hide();
            outroform.ShowDialog();
        }

        private void btnCadEqVoltar_Click(object sender, EventArgs e)
        {
            frmMenu outroform = new frmMenu();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendamentos outroform = new frmAgendamentos();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadControle_Click(object sender, EventArgs e)
        {
            frmControle outroform = new frmControle();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void btnCadCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa outroform = new frmCaixa();
            this.Hide();
            outroform.ShowDialog();
            LimparDados();
            Close();
        }

        private void mktCadAluCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void mktCadForCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEPFor();
        }

        private void mktCadTerCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEPTer();
        }

        private void mktCadFunCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEPFun();
        }

        private void btnCadAluCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadAluNome.Text.Trim().Length == 0)
            {
                erpPreencherCamposAlu.SetError(txtCadAluNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposAlu.SetError(txtCadAluNome, "");
            }
            try
            {
                Conexao.Conectar();

  

                string sql = @"insert into Alunos (Alu_CPF,Alu_Nome, Alu_Email, Alu_Celular, Alu_DataNascimento, Alu_DataCadastro, Alu_CEP, Alu_Estado, Alu_Cidade, Alu_Rua, Alu_Numero, Alu_Complemento, Alu_Bairro)
			                    values (@cpf, @nome, @email, @celular, @datanascimento, @datacadastro, @cep, @estado, @cidade, @rua, @numero, @complemento, @bairro)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtCadAluNome.Text);
                cmd.Parameters.AddWithValue("cpf", mktCadAluCPF.Text);
                cmd.Parameters.AddWithValue("email", txtCadAluEmail.Text);
                cmd.Parameters.AddWithValue("celular", mktCadAluCelular.Text);
                cmd.Parameters.AddWithValue("datanascimento", mktCadAluDataNasc.Text);
                cmd.Parameters.AddWithValue("datacadastro", mktCadAluDataCadastro.Text);
                cmd.Parameters.AddWithValue("cep", mktCadAluCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbCadAluEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCadAluCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtCadAluRua.Text);
                cmd.Parameters.AddWithValue("numero", txtCadAluNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtCadAluComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtCadAluBairro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();
        }

        private void btnCadProCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadProDescricao.Text.Trim().Length == 0)
            {
                erpPreencherCamposPro.SetError(txtCadProDescricao, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposPro.SetError(txtCadProDescricao, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into Produtos (Pro_Descricao, Pro_Quantidade, Pro_Fornecedor, Pro_Fabricante, Pro_Validade, Pro_ValorUnitario)
			                    values ( @descricao,@quantidade, @fornecedor, @fabricante, @validade, @valorunitario)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("quantidade", txtCadProQuantidade.Text);
                cmd.Parameters.AddWithValue("descricao", txtCadProDescricao.Text);
                cmd.Parameters.AddWithValue("fornecedor", txtCadProFornecedor.Text);
                cmd.Parameters.AddWithValue("fabricante", txtCadProFabricante.Text);
                cmd.Parameters.AddWithValue("validade", mktCadProValidade.Text);
                cmd.Parameters.AddWithValue("valorunitario", txtCadProValorUni.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();
        }

        private void btnCadForCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadForRazaoSocial.Text.Trim().Length == 0)
            {
                erpPreencherCamposForR.SetError(txtCadForRazaoSocial, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposForR.SetError(txtCadForRazaoSocial, "");
            }

            if (txtCadForCNPJ.Text.Trim().Length == 0)
            {
                erpPreencherCamposForCN.SetError(txtCadForCNPJ, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposForCN.SetError(txtCadForCNPJ, "");
            }


            try
            {
                Conexao.Conectar();

                string sql = @"insert into Fornecedores (For_Razao, For_CNPJ, For_Contato, For_Email, For_Fone, For_CEP, For_Estado, For_Cidade, For_Rua, For_Numero, For_Complemento, For_Bairro)
			values (@razao, @cnpj, @contato, @email, @fone, @cep, @estado, @cidade, @rua, @numero, @complemento, @bairro)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("razao", txtCadForRazaoSocial.Text);
                cmd.Parameters.AddWithValue("cnpj", txtCadForCNPJ.Text);
                cmd.Parameters.AddWithValue("contato", txtCadForContato.Text);
                cmd.Parameters.AddWithValue("email", txtCadForEmail.Text);
                cmd.Parameters.AddWithValue("fone", mktCadForFone.Text);
                cmd.Parameters.AddWithValue("cep", mktCadForCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbCadForEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCadForCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtCadForRua.Text);
                cmd.Parameters.AddWithValue("numero", txtCadForNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtCadForComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtCadForBairro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();
        }

        private void btnCadTerCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadTerRazaoSocial.Text.Trim().Length == 0)
            {
                erpPreencherCamposTerR.SetError(txtCadTerRazaoSocial, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposTerR.SetError(txtCadTerRazaoSocial, "");
            }

            if (txtCadTerCNPJ.Text.Trim().Length == 0)
            {
                erpPreencherCamposTerCN.SetError(txtCadTerCNPJ, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposTerCN.SetError(txtCadTerCNPJ, "");
            }


            try
            {
                Conexao.Conectar();

                string sql = @"insert into Terceirizados (Ter_RazaoSocial, Ter_CNPJ, Ter_Contato, Ter_Email, Ter_Fone, Ter_CEP, Ter_Estado, Ter_Cidade, Ter_Rua, Ter_Numero, Ter_Complemento, Ter_Bairro)
			                    values (@razasocial, @cnpjt, @contatot, @email, @fone, @cep, @estado, @cidade, @rua, @numero, @complemento, @bairro)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("razasocial", txtCadTerRazaoSocial.Text);
                cmd.Parameters.AddWithValue("cnpjt", txtCadTerCNPJ.Text);
                cmd.Parameters.AddWithValue("contatot", txtCadTerContato.Text);
                cmd.Parameters.AddWithValue("email", txtCadTerEmail.Text);
                cmd.Parameters.AddWithValue("fone", mktCadTerFone.Text);
                cmd.Parameters.AddWithValue("cep", mktCadTerCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbCadTerEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCadTerCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtCadTerRua.Text);
                cmd.Parameters.AddWithValue("numero", txtCadTerNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtCadTerComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtCadTerBairro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();
        }

        private void btnCadFunCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadFunNome.Text.Trim().Length == 0)
            {
                erpPreencherCamposFunN.SetError(txtCadFunNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposFunN.SetError(txtCadFunNome, "");
            }

            if (mktCadFunCPF.Text.Trim().Length == 0)
            {
                erpPreencherCamposFunCP.SetError(mktCadFunCPF, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposFunCP.SetError(mktCadFunCPF, "");
            }

            try
            {
                Conexao.Conectar();

                string sql = @"insert into Funcionarios (Fun_Nome, Fun_CPF, Fun_Email, Fun_Celular, Fun_DataNascimento, Fun_DataInicio, Fun_Cargo, Fun_CEP, Fun_Estado, Fun_Cidade, Fun_Rua, Fun_Numero, Fun_Complemento, Fun_Bairro)
			                    values (@nome, @cpf, @email, @celular, @datanascimento, @datainicio, @cargo, @cep, @estado, @cidade, @rua, @numero, @complemento, @bairro)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtCadFunNome.Text);
                cmd.Parameters.AddWithValue("cpf", mktCadFunCPF.Text);
                cmd.Parameters.AddWithValue("email", txtCadFunEmail.Text);
                cmd.Parameters.AddWithValue("celular", mktCadFunCelular.Text);
                cmd.Parameters.AddWithValue("datanascimento", mktCadFunDataNasc.Text);
                cmd.Parameters.AddWithValue("datainicio", mktCadFunDataInicio.Text);
                cmd.Parameters.AddWithValue("cargo", cmbCadFunCargo.Text);
                cmd.Parameters.AddWithValue("cep", mktCadFunCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbCadFunEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCadFunCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtCadFunRua.Text);
                cmd.Parameters.AddWithValue("numero", txtCadFunNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtCadFunComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtCadFunBairro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();
        }

        private void btnCadEqCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadEqModelo.Text.Trim().Length == 0)
            {
                erpPreencherCamposIde.SetError(txtCadEqModelo, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCamposIde.SetError(txtCadEqModelo, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into Equipamento (Eq_Modelo, Eq_Peso, Eq_Fabricante, Eq_Linha, Eq_Solda, Eq_Estofamento, Eq_Garantia, Eq_Estrutura, Eq_DataCompra, Eq_Descricao)
			                    values (@modelo, @peso, @fabricante, @linha, @solda, @estofamento, @garantia, @estrutura, @datacompra, @descricao)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("modelo", txtCadEqModelo.Text);
                cmd.Parameters.AddWithValue("peso", txtCadEqPeso.Text);
                cmd.Parameters.AddWithValue("fabricante", txtCadEqFabricante.Text);
                cmd.Parameters.AddWithValue("linha", txtCadEqLinha.Text);
                cmd.Parameters.AddWithValue("solda", txtCadEqSolda.Text);
                cmd.Parameters.AddWithValue("estofamento", txtCadEqEstofamento.Text);
                cmd.Parameters.AddWithValue("garantia", mktCadEqGarantia.Text);
                cmd.Parameters.AddWithValue("estrutura", txtCadEqEstrutura.Text);
                cmd.Parameters.AddWithValue("datacompra", mktCadEqDataCompra.Text);
                cmd.Parameters.AddWithValue("descricao", txtCadEqDescricao.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            LimparDados();

        }

        private void btnCadAluAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadAluApagar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM Alunos
                      WHERE CODIGO = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CODIGO", Alunos.Codigo);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno excluído com sucesso!");

                //Utils.limparCampos(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void btnCadFunAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE Alunos SET
                      Alu_Nome = @NOME, Alu_Email = @EMAIL,
                      Alu_Celular = @CELULAR, Alu_CPF = @CPF
                      Alu_DataNascimento = @dataNASCIMENTO, Alu_DataCadastro = @dataCADASTRO,
                      Alu_CEP = @CEP, Alu_Estado = @ESTADO,
                      Alu_Cidade = @CIDADE, Alu_Rua = @RUA, Alu_Numero = @NUMERO, 
                      Alu_Complemento = @COMPLEMENTO, Alu_Bairro = @BAIRRO,
                      WHERE Alu_Id = @ID";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("ID", Alunos.Codigo);
                cmd.Parameters.AddWithValue("NOME", txtCadAluNome.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtCadAluEmail.Text);
                cmd.Parameters.AddWithValue("CPF", mktCadAluCPF.Text);
                cmd.Parameters.AddWithValue("CELULAR", mktCadAluCelular.Text);
                cmd.Parameters.AddWithValue("dataNASCIMENTO", mktCadAluDataNasc.Text);
                cmd.Parameters.AddWithValue("dataCADASTRO", mktCadAluDataCadastro.Text);
                cmd.Parameters.AddWithValue("CEP", mktCadAluCEP.Text);
                cmd.Parameters.AddWithValue("ESTADO", cmbCadAluEstado.Text);
                cmd.Parameters.AddWithValue("CIDADE", cmbCadAluCidade.Text);
                cmd.Parameters.AddWithValue("RUA", txtCadAluRua.Text);
                cmd.Parameters.AddWithValue("NUMERO", txtCadAluNumero.Text);
                cmd.Parameters.AddWithValue("COMPLEMENTO", txtCadAluComplemento.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txtCadAluBairro.Text);
                // Adicionar imagem NULL ao banco de dados
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }
    }
}
