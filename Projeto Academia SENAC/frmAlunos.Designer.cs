namespace Projeto_Academia_SENAC
{
    partial class frmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCadClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvAlunos = new System.Windows.Forms.DataGridView();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailALuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.BtnCadClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 61);
            this.panel1.TabIndex = 5;
            // 
            // BtnCadClose
            // 
            this.BtnCadClose.FlatAppearance.BorderSize = 0;
            this.BtnCadClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadClose.Image = global::Projeto_Academia_SENAC.Properties.Resources.x;
            this.BtnCadClose.Location = new System.Drawing.Point(882, 12);
            this.BtnCadClose.Name = "BtnCadClose";
            this.BtnCadClose.Size = new System.Drawing.Size(40, 39);
            this.BtnCadClose.TabIndex = 3;
            this.BtnCadClose.UseVisualStyleBackColor = true;
            this.BtnCadClose.Click += new System.EventHandler(this.BtnCadClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 419);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOLDFIT";
            // 
            // dtvAlunos
            // 
            this.dtvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAluno,
            this.CPFAluno,
            this.EmailALuno,
            this.CelularAluno,
            this.DataNascimento,
            this.DataCadastro,
            this.CEPAluno,
            this.EstadoAluno,
            this.CidadeAluno,
            this.RuaAluno,
            this.NumeroAluno,
            this.ComplementoAluno,
            this.BairroAluno});
            this.dtvAlunos.Location = new System.Drawing.Point(12, 121);
            this.dtvAlunos.Name = "dtvAlunos";
            this.dtvAlunos.Size = new System.Drawing.Size(926, 517);
            this.dtvAlunos.TabIndex = 6;
            // 
            // NomeAluno
            // 
            this.NomeAluno.HeaderText = "Nome";
            this.NomeAluno.Name = "NomeAluno";
            // 
            // CPFAluno
            // 
            this.CPFAluno.HeaderText = "CPF";
            this.CPFAluno.Name = "CPFAluno";
            // 
            // EmailALuno
            // 
            this.EmailALuno.HeaderText = "Email";
            this.EmailALuno.Name = "EmailALuno";
            // 
            // CelularAluno
            // 
            this.CelularAluno.HeaderText = "Celular";
            this.CelularAluno.Name = "CelularAluno";
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Data de Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            // 
            // CEPAluno
            // 
            this.CEPAluno.HeaderText = "CEP";
            this.CEPAluno.Name = "CEPAluno";
            // 
            // EstadoAluno
            // 
            this.EstadoAluno.HeaderText = "Estado";
            this.EstadoAluno.Name = "EstadoAluno";
            // 
            // CidadeAluno
            // 
            this.CidadeAluno.HeaderText = "Cidade";
            this.CidadeAluno.Name = "CidadeAluno";
            // 
            // RuaAluno
            // 
            this.RuaAluno.HeaderText = "Rua";
            this.RuaAluno.Name = "RuaAluno";
            // 
            // NumeroAluno
            // 
            this.NumeroAluno.HeaderText = "Nº";
            this.NumeroAluno.Name = "NumeroAluno";
            // 
            // ComplementoAluno
            // 
            this.ComplementoAluno.HeaderText = "Complemento";
            this.ComplementoAluno.Name = "ComplementoAluno";
            // 
            // BairroAluno
            // 
            this.BairroAluno.HeaderText = "Bairro";
            this.BairroAluno.Name = "BairroAluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Home / Cadastros / Alunos\r\n";
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtvAlunos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlunos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvAlunos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailALuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplementoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroAluno;
    }
}