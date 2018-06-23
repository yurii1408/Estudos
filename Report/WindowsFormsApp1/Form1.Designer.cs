namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gerar = new System.Windows.Forms.Button();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_nacionalidade = new System.Windows.Forms.TextBox();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.tbx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tbx_datanasc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(351, 98);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_gerar.TabIndex = 6;
            this.btn_gerar.Text = "&Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(49, 12);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(241, 20);
            this.tbx_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nasc.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nacionalidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço";
            // 
            // tbx_nacionalidade
            // 
            this.tbx_nacionalidade.Location = new System.Drawing.Point(257, 42);
            this.tbx_nacionalidade.Name = "tbx_nacionalidade";
            this.tbx_nacionalidade.Size = new System.Drawing.Size(169, 20);
            this.tbx_nacionalidade.TabIndex = 3;
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Location = new System.Drawing.Point(70, 68);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(356, 20);
            this.tbx_endereco.TabIndex = 4;
            // 
            // tbx_cpf
            // 
            this.tbx_cpf.Location = new System.Drawing.Point(330, 13);
            this.tbx_cpf.Mask = "000,000,000-00";
            this.tbx_cpf.Name = "tbx_cpf";
            this.tbx_cpf.Size = new System.Drawing.Size(96, 20);
            this.tbx_cpf.TabIndex = 1;
            this.tbx_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_datanasc
            // 
            this.tbx_datanasc.Location = new System.Drawing.Point(88, 42);
            this.tbx_datanasc.Mask = "00/00/0000";
            this.tbx_datanasc.Name = "tbx_datanasc";
            this.tbx_datanasc.Size = new System.Drawing.Size(82, 20);
            this.tbx_datanasc.TabIndex = 2;
            this.tbx_datanasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefone";
            // 
            // tbx_telefone
            // 
            this.tbx_telefone.Location = new System.Drawing.Point(70, 98);
            this.tbx_telefone.Mask = "(00) 0000-0000";
            this.tbx_telefone.Name = "tbx_telefone";
            this.tbx_telefone.Size = new System.Drawing.Size(82, 20);
            this.tbx_telefone.TabIndex = 5;
            this.tbx_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(270, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Sai&r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_gerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(451, 138);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_telefone);
            this.Controls.Add(this.tbx_datanasc);
            this.Controls.Add(this.tbx_cpf);
            this.Controls.Add(this.tbx_endereco);
            this.Controls.Add(this.tbx_nacionalidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.btn_gerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termo de entrega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_nacionalidade;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.MaskedTextBox tbx_cpf;
        private System.Windows.Forms.MaskedTextBox tbx_datanasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbx_telefone;
        private System.Windows.Forms.Button button1;
    }
}

