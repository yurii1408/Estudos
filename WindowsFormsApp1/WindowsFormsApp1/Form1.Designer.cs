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
            this.rbt_juridica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_fisica = new System.Windows.Forms.RadioButton();
            this.asdasdasd = new System.Windows.Forms.MaskedTextBox();
            this.tbx_fone2 = new System.Windows.Forms.MaskedTextBox();
            this.tbx_fone1 = new System.Windows.Forms.MaskedTextBox();
            this.tbx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbx_codigo = new System.Windows.Forms.TextBox();
            this.tbx_empresa = new System.Windows.Forms.TextBox();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.tbx_contato = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pessoa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_juridica
            // 
            this.rbt_juridica.AutoSize = true;
            this.rbt_juridica.Location = new System.Drawing.Point(72, 19);
            this.rbt_juridica.Name = "rbt_juridica";
            this.rbt_juridica.Size = new System.Drawing.Size(63, 17);
            this.rbt_juridica.TabIndex = 15;
            this.rbt_juridica.TabStop = true;
            this.rbt_juridica.Text = "Jurídica";
            this.rbt_juridica.UseVisualStyleBackColor = true;
            this.rbt_juridica.CheckedChanged += new System.EventHandler(this.rbt_juridica_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.rbt_juridica);
            this.groupBox1.Controls.Add(this.rbt_fisica);
            this.groupBox1.Location = new System.Drawing.Point(63, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 74);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pessoa";
            // 
            // rbt_fisica
            // 
            this.rbt_fisica.AutoSize = true;
            this.rbt_fisica.Checked = true;
            this.rbt_fisica.Location = new System.Drawing.Point(12, 19);
            this.rbt_fisica.Name = "rbt_fisica";
            this.rbt_fisica.Size = new System.Drawing.Size(54, 17);
            this.rbt_fisica.TabIndex = 15;
            this.rbt_fisica.TabStop = true;
            this.rbt_fisica.Text = "Física";
            this.rbt_fisica.UseVisualStyleBackColor = true;
            // 
            // asdasdasd
            // 
            this.asdasdasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdasdasd.Location = new System.Drawing.Point(850, 355);
            this.asdasdasd.Mask = "(00) 90000-0000";
            this.asdasdasd.Name = "asdasdasd";
            this.asdasdasd.Size = new System.Drawing.Size(96, 21);
            this.asdasdasd.TabIndex = 34;
            this.asdasdasd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_fone2
            // 
            this.tbx_fone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_fone2.Location = new System.Drawing.Point(850, 328);
            this.tbx_fone2.Mask = "(00) 0000-0000";
            this.tbx_fone2.Name = "tbx_fone2";
            this.tbx_fone2.Size = new System.Drawing.Size(96, 21);
            this.tbx_fone2.TabIndex = 33;
            this.tbx_fone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_fone1
            // 
            this.tbx_fone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_fone1.Location = new System.Drawing.Point(850, 301);
            this.tbx_fone1.Mask = "(00) 0000-0000";
            this.tbx_fone1.Name = "tbx_fone1";
            this.tbx_fone1.Size = new System.Drawing.Size(96, 21);
            this.tbx_fone1.TabIndex = 32;
            this.tbx_fone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_cnpj
            // 
            this.tbx_cnpj.Location = new System.Drawing.Point(402, 120);
            this.tbx_cnpj.Mask = "00,000,000/0000-00";
            this.tbx_cnpj.Name = "tbx_cnpj";
            this.tbx_cnpj.Size = new System.Drawing.Size(109, 20);
            this.tbx_cnpj.TabIndex = 27;
            this.tbx_cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_codigo
            // 
            this.tbx_codigo.Location = new System.Drawing.Point(93, 11);
            this.tbx_codigo.Name = "tbx_codigo";
            this.tbx_codigo.Size = new System.Drawing.Size(36, 20);
            this.tbx_codigo.TabIndex = 25;
            this.tbx_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_empresa
            // 
            this.tbx_empresa.Location = new System.Drawing.Point(225, 11);
            this.tbx_empresa.Name = "tbx_empresa";
            this.tbx_empresa.Size = new System.Drawing.Size(248, 20);
            this.tbx_empresa.TabIndex = 26;
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Location = new System.Drawing.Point(618, 235);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(216, 20);
            this.tbx_endereco.TabIndex = 29;
            // 
            // tbx_contato
            // 
            this.tbx_contato.Location = new System.Drawing.Point(610, 287);
            this.tbx_contato.Name = "tbx_contato";
            this.tbx_contato.Size = new System.Drawing.Size(142, 20);
            this.tbx_contato.TabIndex = 31;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(597, 261);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(237, 20);
            this.tbx_email.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "&Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(586, 331);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(667, 331);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 35;
            this.btn_salvar.Text = "&Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empresa/Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fone 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fone 1:";
            // 
            // lbl_pessoa
            // 
            this.lbl_pessoa.AutoSize = true;
            this.lbl_pessoa.Location = new System.Drawing.Point(359, 123);
            this.lbl_pessoa.Name = "lbl_pessoa";
            this.lbl_pessoa.Size = new System.Drawing.Size(37, 13);
            this.lbl_pessoa.TabIndex = 23;
            this.lbl_pessoa.Text = "CNPJ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Contato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.asdasdasd);
            this.Controls.Add(this.tbx_fone2);
            this.Controls.Add(this.tbx_fone1);
            this.Controls.Add(this.tbx_cnpj);
            this.Controls.Add(this.tbx_codigo);
            this.Controls.Add(this.tbx_empresa);
            this.Controls.Add(this.tbx_endereco);
            this.Controls.Add(this.tbx_contato);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_pessoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_juridica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_fisica;
        private System.Windows.Forms.MaskedTextBox asdasdasd;
        private System.Windows.Forms.MaskedTextBox tbx_fone2;
        private System.Windows.Forms.MaskedTextBox tbx_fone1;
        private System.Windows.Forms.MaskedTextBox tbx_cnpj;
        public System.Windows.Forms.TextBox tbx_codigo;
        public System.Windows.Forms.TextBox tbx_empresa;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.TextBox tbx_contato;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_pessoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

