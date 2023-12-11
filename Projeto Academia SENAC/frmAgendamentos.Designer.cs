namespace Projeto_Academia_SENAC
{
    partial class frmAgendamentos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgeCaixa = new System.Windows.Forms.Button();
            this.btnAgeControle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgeCadastro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcAgendamento = new System.Windows.Forms.TabControl();
            this.tbpAgeManutencao = new System.Windows.Forms.TabPage();
            this.mktAgeManData = new System.Windows.Forms.MaskedTextBox();
            this.btnAgeManApagar = new System.Windows.Forms.Button();
            this.btnAgeManLimpar = new System.Windows.Forms.Button();
            this.btnAgeManPesquisar = new System.Windows.Forms.Button();
            this.btnAgeManVoltar = new System.Windows.Forms.Button();
            this.btnAgeManCadastrar = new System.Windows.Forms.Button();
            this.txtAgeManDescricao = new System.Windows.Forms.TextBox();
            this.txtAgeManIdentificacao = new System.Windows.Forms.TextBox();
            this.txtAgeManAparelho = new System.Windows.Forms.TextBox();
            this.txtAgeManCodigo = new System.Windows.Forms.TextBox();
            this.txtAgeManRazaoSocial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpAgeConsulta = new System.Windows.Forms.TabPage();
            this.txtAgeConCodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAgeConProfissional = new System.Windows.Forms.TextBox();
            this.mktAgeConHorario = new System.Windows.Forms.MaskedTextBox();
            this.mktAgeConData = new System.Windows.Forms.MaskedTextBox();
            this.mktAgeConCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtAgeConNome = new System.Windows.Forms.TextBox();
            this.btnAgeConApagar = new System.Windows.Forms.Button();
            this.btnAgeConLimpar = new System.Windows.Forms.Button();
            this.btnAgeConPesquisar = new System.Windows.Forms.Button();
            this.btnAgeConVoltar = new System.Windows.Forms.Button();
            this.btnAgeConCadastrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.erpPreencherCamposMan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mktAgeManCnpj = new System.Windows.Forms.MaskedTextBox();
            this.erpPreencherCamposCon = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcAgendamento.SuspendLayout();
            this.tbpAgeManutencao.SuspendLayout();
            this.tbpAgeConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCamposMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCamposCon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 61);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Projeto_Academia_SENAC.Properties.Resources.x;
            this.btnClose.Location = new System.Drawing.Point(898, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.btnAgeCaixa);
            this.panel3.Controls.Add(this.btnAgeControle);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnAgeCadastro);
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 589);
            this.panel3.TabIndex = 3;
            // 
            // btnAgeCaixa
            // 
            this.btnAgeCaixa.FlatAppearance.BorderSize = 0;
            this.btnAgeCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgeCaixa.Image = global::Projeto_Academia_SENAC.Properties.Resources.MONEY;
            this.btnAgeCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgeCaixa.Location = new System.Drawing.Point(3, 220);
            this.btnAgeCaixa.Name = "btnAgeCaixa";
            this.btnAgeCaixa.Size = new System.Drawing.Size(197, 66);
            this.btnAgeCaixa.TabIndex = 6;
            this.btnAgeCaixa.Text = "CAIXA";
            this.btnAgeCaixa.UseVisualStyleBackColor = true;
            this.btnAgeCaixa.Click += new System.EventHandler(this.btnAgeCaixa_Click);
            // 
            // btnAgeControle
            // 
            this.btnAgeControle.FlatAppearance.BorderSize = 0;
            this.btnAgeControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgeControle.Image = global::Projeto_Academia_SENAC.Properties.Resources.clipboard_120024__1_;
            this.btnAgeControle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgeControle.Location = new System.Drawing.Point(0, 148);
            this.btnAgeControle.Name = "btnAgeControle";
            this.btnAgeControle.Size = new System.Drawing.Size(200, 66);
            this.btnAgeControle.TabIndex = 5;
            this.btnAgeControle.Text = "   CONTROLE";
            this.btnAgeControle.UseVisualStyleBackColor = true;
            this.btnAgeControle.Click += new System.EventHandler(this.btnAgeControle_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Projeto_Academia_SENAC.Properties.Resources.Calendario__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "AGENDAMENTOS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgeCadastro
            // 
            this.btnAgeCadastro.FlatAppearance.BorderSize = 0;
            this.btnAgeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgeCadastro.Image = global::Projeto_Academia_SENAC.Properties.Resources.Cadastro__1_;
            this.btnAgeCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgeCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnAgeCadastro.Name = "btnAgeCadastro";
            this.btnAgeCadastro.Size = new System.Drawing.Size(197, 66);
            this.btnAgeCadastro.TabIndex = 3;
            this.btnAgeCadastro.Text = "          CADASTROS";
            this.btnAgeCadastro.UseVisualStyleBackColor = true;
            this.btnAgeCadastro.Click += new System.EventHandler(this.btnAgeCadastro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Home / Agendamentos";
            // 
            // tbcAgendamento
            // 
            this.tbcAgendamento.Controls.Add(this.tbpAgeManutencao);
            this.tbcAgendamento.Controls.Add(this.tbpAgeConsulta);
            this.tbcAgendamento.Location = new System.Drawing.Point(210, 133);
            this.tbcAgendamento.Name = "tbcAgendamento";
            this.tbcAgendamento.SelectedIndex = 0;
            this.tbcAgendamento.Size = new System.Drawing.Size(728, 498);
            this.tbcAgendamento.TabIndex = 8;
            // 
            // tbpAgeManutencao
            // 
            this.tbpAgeManutencao.Controls.Add(this.mktAgeManCnpj);
            this.tbpAgeManutencao.Controls.Add(this.mktAgeManData);
            this.tbpAgeManutencao.Controls.Add(this.btnAgeManApagar);
            this.tbpAgeManutencao.Controls.Add(this.btnAgeManLimpar);
            this.tbpAgeManutencao.Controls.Add(this.btnAgeManPesquisar);
            this.tbpAgeManutencao.Controls.Add(this.btnAgeManVoltar);
            this.tbpAgeManutencao.Controls.Add(this.btnAgeManCadastrar);
            this.tbpAgeManutencao.Controls.Add(this.txtAgeManDescricao);
            this.tbpAgeManutencao.Controls.Add(this.txtAgeManIdentificacao);
            this.tbpAgeManutencao.Controls.Add(this.txtAgeManAparelho);
            this.tbpAgeManutencao.Controls.Add(this.txtAgeManCodigo);
            this.tbpAgeManutencao.Controls.Add(this.txtAgeManRazaoSocial);
            this.tbpAgeManutencao.Controls.Add(this.label9);
            this.tbpAgeManutencao.Controls.Add(this.label7);
            this.tbpAgeManutencao.Controls.Add(this.label6);
            this.tbpAgeManutencao.Controls.Add(this.label5);
            this.tbpAgeManutencao.Controls.Add(this.label4);
            this.tbpAgeManutencao.Controls.Add(this.label3);
            this.tbpAgeManutencao.Controls.Add(this.label2);
            this.tbpAgeManutencao.Location = new System.Drawing.Point(4, 22);
            this.tbpAgeManutencao.Name = "tbpAgeManutencao";
            this.tbpAgeManutencao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgeManutencao.Size = new System.Drawing.Size(720, 472);
            this.tbpAgeManutencao.TabIndex = 0;
            this.tbpAgeManutencao.Text = "AGENDAMENTO PARA MANUTENÇÃO";
            this.tbpAgeManutencao.UseVisualStyleBackColor = true;
            // 
            // mktAgeManData
            // 
            this.mktAgeManData.Location = new System.Drawing.Point(527, 78);
            this.mktAgeManData.Mask = "00/00/0000";
            this.mktAgeManData.Name = "mktAgeManData";
            this.mktAgeManData.Size = new System.Drawing.Size(163, 20);
            this.mktAgeManData.TabIndex = 3;
            // 
            // btnAgeManApagar
            // 
            this.btnAgeManApagar.Location = new System.Drawing.Point(45, 412);
            this.btnAgeManApagar.Name = "btnAgeManApagar";
            this.btnAgeManApagar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeManApagar.TabIndex = 85;
            this.btnAgeManApagar.Text = "Apagar";
            this.btnAgeManApagar.UseVisualStyleBackColor = true;
            // 
            // btnAgeManLimpar
            // 
            this.btnAgeManLimpar.Location = new System.Drawing.Point(602, 412);
            this.btnAgeManLimpar.Name = "btnAgeManLimpar";
            this.btnAgeManLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeManLimpar.TabIndex = 83;
            this.btnAgeManLimpar.Text = "Limpar";
            this.btnAgeManLimpar.UseVisualStyleBackColor = true;
            this.btnAgeManLimpar.Click += new System.EventHandler(this.btnAgeManLimpar_Click);
            // 
            // btnAgeManPesquisar
            // 
            this.btnAgeManPesquisar.Location = new System.Drawing.Point(602, 353);
            this.btnAgeManPesquisar.Name = "btnAgeManPesquisar";
            this.btnAgeManPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeManPesquisar.TabIndex = 8;
            this.btnAgeManPesquisar.Text = "Pesquisar";
            this.btnAgeManPesquisar.UseVisualStyleBackColor = true;
            this.btnAgeManPesquisar.Click += new System.EventHandler(this.btnAgeManPesquisar_Click);
            // 
            // btnAgeManVoltar
            // 
            this.btnAgeManVoltar.Location = new System.Drawing.Point(328, 412);
            this.btnAgeManVoltar.Name = "btnAgeManVoltar";
            this.btnAgeManVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeManVoltar.TabIndex = 81;
            this.btnAgeManVoltar.Text = "Voltar";
            this.btnAgeManVoltar.UseVisualStyleBackColor = true;
            this.btnAgeManVoltar.Click += new System.EventHandler(this.btnAgeManVoltar_Click);
            // 
            // btnAgeManCadastrar
            // 
            this.btnAgeManCadastrar.Location = new System.Drawing.Point(45, 353);
            this.btnAgeManCadastrar.Name = "btnAgeManCadastrar";
            this.btnAgeManCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeManCadastrar.TabIndex = 7;
            this.btnAgeManCadastrar.Text = "Cadastrar";
            this.btnAgeManCadastrar.UseVisualStyleBackColor = true;
            this.btnAgeManCadastrar.Click += new System.EventHandler(this.btnAgeManCadastrar_Click);
            // 
            // txtAgeManDescricao
            // 
            this.txtAgeManDescricao.Location = new System.Drawing.Point(110, 176);
            this.txtAgeManDescricao.Multiline = true;
            this.txtAgeManDescricao.Name = "txtAgeManDescricao";
            this.txtAgeManDescricao.Size = new System.Drawing.Size(580, 112);
            this.txtAgeManDescricao.TabIndex = 6;
            // 
            // txtAgeManIdentificacao
            // 
            this.txtAgeManIdentificacao.Location = new System.Drawing.Point(527, 123);
            this.txtAgeManIdentificacao.Name = "txtAgeManIdentificacao";
            this.txtAgeManIdentificacao.Size = new System.Drawing.Size(163, 20);
            this.txtAgeManIdentificacao.TabIndex = 5;
            // 
            // txtAgeManAparelho
            // 
            this.txtAgeManAparelho.Location = new System.Drawing.Point(109, 123);
            this.txtAgeManAparelho.Name = "txtAgeManAparelho";
            this.txtAgeManAparelho.Size = new System.Drawing.Size(277, 20);
            this.txtAgeManAparelho.TabIndex = 4;
            // 
            // txtAgeManCodigo
            // 
            this.txtAgeManCodigo.Location = new System.Drawing.Point(110, 78);
            this.txtAgeManCodigo.Name = "txtAgeManCodigo";
            this.txtAgeManCodigo.Size = new System.Drawing.Size(260, 20);
            this.txtAgeManCodigo.TabIndex = 2;
            // 
            // txtAgeManRazaoSocial
            // 
            this.txtAgeManRazaoSocial.Location = new System.Drawing.Point(109, 32);
            this.txtAgeManRazaoSocial.Name = "txtAgeManRazaoSocial";
            this.txtAgeManRazaoSocial.Size = new System.Drawing.Size(294, 20);
            this.txtAgeManRazaoSocial.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nº de Identificação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Aparelho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNPJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razão Social:";
            // 
            // tbpAgeConsulta
            // 
            this.tbpAgeConsulta.Controls.Add(this.txtAgeConCodigo);
            this.tbpAgeConsulta.Controls.Add(this.label15);
            this.tbpAgeConsulta.Controls.Add(this.txtAgeConProfissional);
            this.tbpAgeConsulta.Controls.Add(this.mktAgeConHorario);
            this.tbpAgeConsulta.Controls.Add(this.mktAgeConData);
            this.tbpAgeConsulta.Controls.Add(this.mktAgeConCPF);
            this.tbpAgeConsulta.Controls.Add(this.txtAgeConNome);
            this.tbpAgeConsulta.Controls.Add(this.btnAgeConApagar);
            this.tbpAgeConsulta.Controls.Add(this.btnAgeConLimpar);
            this.tbpAgeConsulta.Controls.Add(this.btnAgeConPesquisar);
            this.tbpAgeConsulta.Controls.Add(this.btnAgeConVoltar);
            this.tbpAgeConsulta.Controls.Add(this.btnAgeConCadastrar);
            this.tbpAgeConsulta.Controls.Add(this.label14);
            this.tbpAgeConsulta.Controls.Add(this.label13);
            this.tbpAgeConsulta.Controls.Add(this.label12);
            this.tbpAgeConsulta.Controls.Add(this.label11);
            this.tbpAgeConsulta.Controls.Add(this.label10);
            this.tbpAgeConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAgeConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpAgeConsulta.Name = "tbpAgeConsulta";
            this.tbpAgeConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgeConsulta.Size = new System.Drawing.Size(720, 472);
            this.tbpAgeConsulta.TabIndex = 1;
            this.tbpAgeConsulta.Text = "AGENDAMENTO PARA CONSULTA";
            this.tbpAgeConsulta.UseVisualStyleBackColor = true;
            // 
            // txtAgeConCodigo
            // 
            this.txtAgeConCodigo.Location = new System.Drawing.Point(89, 150);
            this.txtAgeConCodigo.Name = "txtAgeConCodigo";
            this.txtAgeConCodigo.Size = new System.Drawing.Size(204, 20);
            this.txtAgeConCodigo.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 96;
            this.label15.Text = "Código:";
            // 
            // txtAgeConProfissional
            // 
            this.txtAgeConProfissional.Location = new System.Drawing.Point(541, 100);
            this.txtAgeConProfissional.Name = "txtAgeConProfissional";
            this.txtAgeConProfissional.Size = new System.Drawing.Size(150, 20);
            this.txtAgeConProfissional.TabIndex = 4;
            // 
            // mktAgeConHorario
            // 
            this.mktAgeConHorario.Location = new System.Drawing.Point(330, 101);
            this.mktAgeConHorario.Mask = "00:00";
            this.mktAgeConHorario.Name = "mktAgeConHorario";
            this.mktAgeConHorario.Size = new System.Drawing.Size(126, 20);
            this.mktAgeConHorario.TabIndex = 3;
            // 
            // mktAgeConData
            // 
            this.mktAgeConData.Location = new System.Drawing.Point(89, 101);
            this.mktAgeConData.Mask = "00/00/0000";
            this.mktAgeConData.Name = "mktAgeConData";
            this.mktAgeConData.Size = new System.Drawing.Size(168, 20);
            this.mktAgeConData.TabIndex = 2;
            // 
            // mktAgeConCPF
            // 
            this.mktAgeConCPF.Location = new System.Drawing.Point(526, 37);
            this.mktAgeConCPF.Mask = "000.000.000-00";
            this.mktAgeConCPF.Name = "mktAgeConCPF";
            this.mktAgeConCPF.Size = new System.Drawing.Size(165, 20);
            this.mktAgeConCPF.TabIndex = 1;
            // 
            // txtAgeConNome
            // 
            this.txtAgeConNome.Location = new System.Drawing.Point(89, 37);
            this.txtAgeConNome.Name = "txtAgeConNome";
            this.txtAgeConNome.Size = new System.Drawing.Size(381, 20);
            this.txtAgeConNome.TabIndex = 0;
            // 
            // btnAgeConApagar
            // 
            this.btnAgeConApagar.Location = new System.Drawing.Point(44, 419);
            this.btnAgeConApagar.Name = "btnAgeConApagar";
            this.btnAgeConApagar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeConApagar.TabIndex = 90;
            this.btnAgeConApagar.Text = "Apagar";
            this.btnAgeConApagar.UseVisualStyleBackColor = true;
            // 
            // btnAgeConLimpar
            // 
            this.btnAgeConLimpar.Location = new System.Drawing.Point(601, 419);
            this.btnAgeConLimpar.Name = "btnAgeConLimpar";
            this.btnAgeConLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeConLimpar.TabIndex = 89;
            this.btnAgeConLimpar.Text = "Limpar";
            this.btnAgeConLimpar.UseVisualStyleBackColor = true;
            this.btnAgeConLimpar.Click += new System.EventHandler(this.btnAgeConLimpar_Click);
            // 
            // btnAgeConPesquisar
            // 
            this.btnAgeConPesquisar.Location = new System.Drawing.Point(601, 360);
            this.btnAgeConPesquisar.Name = "btnAgeConPesquisar";
            this.btnAgeConPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeConPesquisar.TabIndex = 7;
            this.btnAgeConPesquisar.Text = "Pesquisar";
            this.btnAgeConPesquisar.UseVisualStyleBackColor = true;
            this.btnAgeConPesquisar.Click += new System.EventHandler(this.btnAgeConPesquisar_Click);
            // 
            // btnAgeConVoltar
            // 
            this.btnAgeConVoltar.Location = new System.Drawing.Point(327, 419);
            this.btnAgeConVoltar.Name = "btnAgeConVoltar";
            this.btnAgeConVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeConVoltar.TabIndex = 87;
            this.btnAgeConVoltar.Text = "Voltar";
            this.btnAgeConVoltar.UseVisualStyleBackColor = true;
            this.btnAgeConVoltar.Click += new System.EventHandler(this.btnAgeConVoltar_Click);
            // 
            // btnAgeConCadastrar
            // 
            this.btnAgeConCadastrar.Location = new System.Drawing.Point(44, 360);
            this.btnAgeConCadastrar.Name = "btnAgeConCadastrar";
            this.btnAgeConCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnAgeConCadastrar.TabIndex = 6;
            this.btnAgeConCadastrar.Text = "Cadastrar";
            this.btnAgeConCadastrar.UseVisualStyleBackColor = true;
            this.btnAgeConCadastrar.Click += new System.EventHandler(this.btnAgeConCadastrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(464, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Profissional:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(272, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Horário:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Data:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "CPF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome:";
            // 
            // erpPreencherCamposMan
            // 
            this.erpPreencherCamposMan.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mktAgeManCnpj
            // 
            this.mktAgeManCnpj.Location = new System.Drawing.Point(474, 28);
            this.mktAgeManCnpj.Mask = "00.000.000/0000-00";
            this.mktAgeManCnpj.Name = "mktAgeManCnpj";
            this.mktAgeManCnpj.Size = new System.Drawing.Size(216, 20);
            this.mktAgeManCnpj.TabIndex = 1;
            // 
            // erpPreencherCamposCon
            // 
            this.erpPreencherCamposCon.ContainerControl = this;
            // 
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.tbcAgendamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgendamentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tbcAgendamento.ResumeLayout(false);
            this.tbpAgeManutencao.ResumeLayout(false);
            this.tbpAgeManutencao.PerformLayout();
            this.tbpAgeConsulta.ResumeLayout(false);
            this.tbpAgeConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCamposMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCamposCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgeCaixa;
        private System.Windows.Forms.Button btnAgeControle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgeCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tbcAgendamento;
        private System.Windows.Forms.TabPage tbpAgeManutencao;
        private System.Windows.Forms.TabPage tbpAgeConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgeManAparelho;
        private System.Windows.Forms.TextBox txtAgeManCodigo;
        private System.Windows.Forms.TextBox txtAgeManRazaoSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgeManDescricao;
        private System.Windows.Forms.TextBox txtAgeManIdentificacao;
        private System.Windows.Forms.Button btnAgeManApagar;
        private System.Windows.Forms.Button btnAgeManLimpar;
        private System.Windows.Forms.Button btnAgeManVoltar;
        private System.Windows.Forms.Button btnAgeManCadastrar;
        private System.Windows.Forms.Button btnAgeManPesquisar;
        private System.Windows.Forms.MaskedTextBox mktAgeConData;
        private System.Windows.Forms.MaskedTextBox mktAgeConCPF;
        private System.Windows.Forms.TextBox txtAgeConNome;
        private System.Windows.Forms.Button btnAgeConApagar;
        private System.Windows.Forms.Button btnAgeConLimpar;
        private System.Windows.Forms.Button btnAgeConPesquisar;
        private System.Windows.Forms.Button btnAgeConVoltar;
        private System.Windows.Forms.Button btnAgeConCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAgeConProfissional;
        private System.Windows.Forms.MaskedTextBox mktAgeConHorario;
        private System.Windows.Forms.MaskedTextBox mktAgeManData;
        private System.Windows.Forms.TextBox txtAgeConCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider erpPreencherCamposMan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mktAgeManCnpj;
        private System.Windows.Forms.ErrorProvider erpPreencherCamposCon;
    }
}