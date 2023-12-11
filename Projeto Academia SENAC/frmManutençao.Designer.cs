namespace Projeto_Academia_SENAC
{
    partial class frmManutençao
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RazaoSocialMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AparelhoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificacaoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCadClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 7;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Home / Agendamento / Manutenção";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazaoSocialMan,
            this.CNPJMan,
            this.CodigoMan,
            this.DataMan,
            this.AparelhoMan,
            this.IdentificacaoMan,
            this.DescricaoMan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 524);
            this.dataGridView1.TabIndex = 10;
            // 
            // RazaoSocialMan
            // 
            this.RazaoSocialMan.HeaderText = "Razão Social";
            this.RazaoSocialMan.Name = "RazaoSocialMan";
            // 
            // CNPJMan
            // 
            this.CNPJMan.HeaderText = "CNPJ";
            this.CNPJMan.Name = "CNPJMan";
            // 
            // CodigoMan
            // 
            this.CodigoMan.HeaderText = "Código";
            this.CodigoMan.Name = "CodigoMan";
            // 
            // DataMan
            // 
            this.DataMan.HeaderText = "Data";
            this.DataMan.Name = "DataMan";
            // 
            // AparelhoMan
            // 
            this.AparelhoMan.HeaderText = "Aparelho";
            this.AparelhoMan.Name = "AparelhoMan";
            // 
            // IdentificacaoMan
            // 
            this.IdentificacaoMan.HeaderText = "Nº de Identificação";
            this.IdentificacaoMan.Name = "IdentificacaoMan";
            // 
            // DescricaoMan
            // 
            this.DescricaoMan.HeaderText = "Descrição";
            this.DescricaoMan.Name = "DescricaoMan";
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
            // frmManutençao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManutençao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManutençao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocialMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AparelhoMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificacaoMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoMan;
    }
}