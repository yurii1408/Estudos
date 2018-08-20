namespace GridList
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.gridlist = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_endereco = new System.Windows.Forms.TextBox();
            this.tbx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_sair.Location = new System.Drawing.Point(439, 230);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sai&r";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridlist
            // 
            this.gridlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Endereço,
            this.Telefone});
            this.gridlist.FullRowSelect = true;
            this.gridlist.GridLines = true;
            this.gridlist.Location = new System.Drawing.Point(12, 53);
            this.gridlist.Name = "gridlist";
            this.gridlist.Size = new System.Drawing.Size(502, 171);
            this.gridlist.TabIndex = 4;
            this.gridlist.UseCompatibleStateImageBehavior = false;
            this.gridlist.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 171;
            // 
            // Endereço
            // 
            this.Endereço.Text = "Endereço";
            this.Endereço.Width = 185;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 144;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(15, 25);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome.TabIndex = 0;
            this.tbx_nome.Text = "Yuri";
            // 
            // tbx_endereco
            // 
            this.tbx_endereco.Location = new System.Drawing.Point(121, 25);
            this.tbx_endereco.Name = "tbx_endereco";
            this.tbx_endereco.Size = new System.Drawing.Size(219, 20);
            this.tbx_endereco.TabIndex = 1;
            this.tbx_endereco.Text = "Rua A 5";
            // 
            // tbx_telefone
            // 
            this.tbx_telefone.Location = new System.Drawing.Point(347, 25);
            this.tbx_telefone.Mask = "(00) 0000-0000";
            this.tbx_telefone.Name = "tbx_telefone";
            this.tbx_telefone.Size = new System.Drawing.Size(85, 20);
            this.tbx_telefone.TabIndex = 2;
            this.tbx_telefone.Text = "6635214067";
            this.tbx_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(439, 23);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "&Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(12, 230);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_exportar.TabIndex = 5;
            this.btn_exportar.Text = "&Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_sair;
            this.ClientSize = new System.Drawing.Size(525, 260);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_telefone);
            this.Controls.Add(this.tbx_endereco);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.gridlist);
            this.Controls.Add(this.btn_sair);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListView gridlist;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_endereco;
        private System.Windows.Forms.MaskedTextBox tbx_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereço;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.Button btn_exportar;
    }
}

