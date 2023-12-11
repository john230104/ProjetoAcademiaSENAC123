namespace Projeto_Academia_SENAC
{
    partial class frmControledeAcesso
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntradaAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSaidaAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 6;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAce,
            this.CPFAce,
            this.HoraEntradaAce,
            this.HoraSaidaAce,
            this.DataAce});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 521);
            this.dataGridView1.TabIndex = 7;
            // 
            // NomeAce
            // 
            this.NomeAce.HeaderText = "Nome";
            this.NomeAce.Name = "NomeAce";
            // 
            // CPFAce
            // 
            this.CPFAce.HeaderText = "CPF";
            this.CPFAce.Name = "CPFAce";
            // 
            // HoraEntradaAce
            // 
            this.HoraEntradaAce.HeaderText = "Hora de Entrada";
            this.HoraEntradaAce.Name = "HoraEntradaAce";
            // 
            // HoraSaidaAce
            // 
            this.HoraSaidaAce.HeaderText = "Hora de Saida";
            this.HoraSaidaAce.Name = "HoraSaidaAce";
            // 
            // DataAce
            // 
            this.DataAce.HeaderText = "Data";
            this.DataAce.Name = "DataAce";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Home / Controle / Acesso";
            // 
            // frmControledeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControledeAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControledeAcesso";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAce;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFAce;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntradaAce;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSaidaAce;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAce;
    }
}