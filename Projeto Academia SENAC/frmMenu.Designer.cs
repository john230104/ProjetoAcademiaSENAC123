namespace Projeto_Academia_SENAC
{
    partial class frmMenu
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
            this.btnMenuClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenuCaixa = new System.Windows.Forms.Button();
            this.btnMenuControle = new System.Windows.Forms.Button();
            this.btnMenuAgend = new System.Windows.Forms.Button();
            this.btnMenuCadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnMenuClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnMenuClose
            // 
            this.btnMenuClose.FlatAppearance.BorderSize = 0;
            this.btnMenuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClose.Image = global::Projeto_Academia_SENAC.Properties.Resources.x;
            this.btnMenuClose.Location = new System.Drawing.Point(898, 14);
            this.btnMenuClose.Name = "btnMenuClose";
            this.btnMenuClose.Size = new System.Drawing.Size(40, 39);
            this.btnMenuClose.TabIndex = 3;
            this.btnMenuClose.UseVisualStyleBackColor = true;
            this.btnMenuClose.Click += new System.EventHandler(this.button5_Click);
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
            this.panel3.Controls.Add(this.btnMenuCaixa);
            this.panel3.Controls.Add(this.btnMenuControle);
            this.panel3.Controls.Add(this.btnMenuAgend);
            this.panel3.Controls.Add(this.btnMenuCadastro);
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 589);
            this.panel3.TabIndex = 2;
            // 
            // btnMenuCaixa
            // 
            this.btnMenuCaixa.FlatAppearance.BorderSize = 0;
            this.btnMenuCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCaixa.Image = global::Projeto_Academia_SENAC.Properties.Resources.MONEY;
            this.btnMenuCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCaixa.Location = new System.Drawing.Point(0, 220);
            this.btnMenuCaixa.Name = "btnMenuCaixa";
            this.btnMenuCaixa.Size = new System.Drawing.Size(200, 66);
            this.btnMenuCaixa.TabIndex = 6;
            this.btnMenuCaixa.Text = "CAIXA";
            this.btnMenuCaixa.UseVisualStyleBackColor = true;
            this.btnMenuCaixa.Click += new System.EventHandler(this.btnMenuCaixa_Click);
            // 
            // btnMenuControle
            // 
            this.btnMenuControle.FlatAppearance.BorderSize = 0;
            this.btnMenuControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuControle.Image = global::Projeto_Academia_SENAC.Properties.Resources.clipboard_120024__1_;
            this.btnMenuControle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuControle.Location = new System.Drawing.Point(0, 148);
            this.btnMenuControle.Name = "btnMenuControle";
            this.btnMenuControle.Size = new System.Drawing.Size(200, 66);
            this.btnMenuControle.TabIndex = 5;
            this.btnMenuControle.Text = "   CONTROLE";
            this.btnMenuControle.UseVisualStyleBackColor = true;
            this.btnMenuControle.Click += new System.EventHandler(this.btnMenuControle_Click);
            // 
            // btnMenuAgend
            // 
            this.btnMenuAgend.FlatAppearance.BorderSize = 0;
            this.btnMenuAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAgend.Image = global::Projeto_Academia_SENAC.Properties.Resources.Calendario__1_;
            this.btnMenuAgend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAgend.Location = new System.Drawing.Point(0, 72);
            this.btnMenuAgend.Name = "btnMenuAgend";
            this.btnMenuAgend.Size = new System.Drawing.Size(197, 66);
            this.btnMenuAgend.TabIndex = 4;
            this.btnMenuAgend.Text = "AGENDAMENTOS";
            this.btnMenuAgend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuAgend.UseVisualStyleBackColor = true;
            this.btnMenuAgend.Click += new System.EventHandler(this.btnMenuAgend_Click);
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.FlatAppearance.BorderSize = 0;
            this.btnMenuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.Image = global::Projeto_Academia_SENAC.Properties.Resources.Cadastro__1_;
            this.btnMenuCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Size = new System.Drawing.Size(197, 66);
            this.btnMenuCadastro.TabIndex = 3;
            this.btnMenuCadastro.Text = "          CADASTROS";
            this.btnMenuCadastro.UseVisualStyleBackColor = true;
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Academia_SENAC.Properties.Resources.goldfit__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(392, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMenuCadastro;
        private System.Windows.Forms.Button btnMenuCaixa;
        private System.Windows.Forms.Button btnMenuControle;
        private System.Windows.Forms.Button btnMenuAgend;
        private System.Windows.Forms.Button btnMenuClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}