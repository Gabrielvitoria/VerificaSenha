namespace VerificarForcaDaSenha
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
            this.lblForcaSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblPontosSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForcaSenha.ForeColor = System.Drawing.Color.Yellow;
            this.lblForcaSenha.Location = new System.Drawing.Point(274, 51);
            this.lblForcaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(224, 32);
            this.lblForcaSenha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informe a senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(29, 56);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(216, 32);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblPontosSenha
            // 
            this.lblPontosSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosSenha.ForeColor = System.Drawing.Color.White;
            this.lblPontosSenha.Location = new System.Drawing.Point(274, 83);
            this.lblPontosSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPontosSenha.Name = "lblPontosSenha";
            this.lblPontosSenha.Size = new System.Drawing.Size(224, 32);
            this.lblPontosSenha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Digite uma senha:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(554, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPontosSenha);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica Força da Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForcaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblPontosSenha;
        private System.Windows.Forms.Label label2;
    }
}