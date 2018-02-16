namespace video_aula_varios_exemplos
{
    partial class Bairros
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
            this.dgv_painel = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.tbx_nome_bairro = new System.Windows.Forms.TextBox();
            this.tbx_codigo_bairro = new System.Windows.Forms.TextBox();
            this.tbx_pesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_painel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_painel
            // 
            this.dgv_painel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_painel.Location = new System.Drawing.Point(17, 176);
            this.dgv_painel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_painel.Name = "dgv_painel";
            this.dgv_painel.Size = new System.Drawing.Size(504, 209);
            this.dgv_painel.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pesquisa:";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(341, 140);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(100, 28);
            this.btn_alterar.TabIndex = 21;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(233, 140);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 28);
            this.btn_excluir.TabIndex = 20;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(125, 140);
            this.btn_gravar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 28);
            this.btn_gravar.TabIndex = 19;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(17, 140);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 28);
            this.btn_novo.TabIndex = 18;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(421, 16);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 28);
            this.btn_pesquisar.TabIndex = 15;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // tbx_nome_bairro
            // 
            this.tbx_nome_bairro.Location = new System.Drawing.Point(215, 63);
            this.tbx_nome_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_nome_bairro.Name = "tbx_nome_bairro";
            this.tbx_nome_bairro.Size = new System.Drawing.Size(305, 22);
            this.tbx_nome_bairro.TabIndex = 17;
            // 
            // tbx_codigo_bairro
            // 
            this.tbx_codigo_bairro.Location = new System.Drawing.Point(79, 63);
            this.tbx_codigo_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_codigo_bairro.Name = "tbx_codigo_bairro";
            this.tbx_codigo_bairro.Size = new System.Drawing.Size(68, 22);
            this.tbx_codigo_bairro.TabIndex = 16;
            // 
            // tbx_pesquisa
            // 
            this.tbx_pesquisa.Location = new System.Drawing.Point(95, 19);
            this.tbx_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_pesquisa.Name = "tbx_pesquisa";
            this.tbx_pesquisa.Size = new System.Drawing.Size(316, 22);
            this.tbx_pesquisa.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "F5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bairros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_painel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tbx_nome_bairro);
            this.Controls.Add(this.tbx_codigo_bairro);
            this.Controls.Add(this.tbx_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bairros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bairros";
            this.Load += new System.EventHandler(this.Bairros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_painel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_painel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tbx_nome_bairro;
        private System.Windows.Forms.TextBox tbx_codigo_bairro;
        private System.Windows.Forms.TextBox tbx_pesquisa;
        private System.Windows.Forms.Button button1;
    }
}