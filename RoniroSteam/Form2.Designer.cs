namespace RoniroSteam
{
    partial class Form2
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
            this.tabelinha = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.painelSenha = new System.Windows.Forms.Panel();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.painelSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelinha
            // 
            this.tabelinha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tabelinha.HideSelection = false;
            this.tabelinha.Location = new System.Drawing.Point(12, 12);
            this.tabelinha.Name = "tabelinha";
            this.tabelinha.Size = new System.Drawing.Size(786, 417);
            this.tabelinha.TabIndex = 0;
            this.tabelinha.UseCompatibleStateImageBehavior = false;
            this.tabelinha.View = System.Windows.Forms.View.Details;
            this.tabelinha.SelectedIndexChanged += new System.EventHandler(this.tabelinha_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NumeroCell";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Senha";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 160;
            // 
            // painelSenha
            // 
            this.painelSenha.Controls.Add(this.entrar);
            this.painelSenha.Controls.Add(this.label1);
            this.painelSenha.Controls.Add(this.textSenha);
            this.painelSenha.Location = new System.Drawing.Point(218, 144);
            this.painelSenha.Name = "painelSenha";
            this.painelSenha.Size = new System.Drawing.Size(347, 100);
            this.painelSenha.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(40, 39);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(262, 20);
            this.textSenha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha de Adiministrador";
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(128, 65);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 2;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelSenha);
            this.Controls.Add(this.tabelinha);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.painelSenha.ResumeLayout(false);
            this.painelSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tabelinha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel painelSenha;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSenha;
    }
}