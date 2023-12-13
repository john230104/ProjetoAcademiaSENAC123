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
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LOGINN
                     WHERE Usuario = @usuario 
                     AND Senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                //Verifica se houve retorno de algum registro

                if (dr.HasRows)
                {

                        frmMenu menu = new frmMenu();
                        Visible = false;
                        menu.ShowDialog();
                        Visible = true;             
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos");
                }

                Conexao.Fechar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            //frmMenu outroform = new frmMenu();
            //this.Hide();
            //outroform.ShowDialog();
            //Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
