namespace Trocando_informacoes_entre_forms
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
            this.tbx_formA = new System.Windows.Forms.TextBox();
            this.btn_formA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_formA
            // 
            this.tbx_formA.Location = new System.Drawing.Point(68, 46);
            this.tbx_formA.Name = "tbx_formA";
            this.tbx_formA.Size = new System.Drawing.Size(100, 20);
            this.tbx_formA.TabIndex = 0;
            // 
            // btn_formA
            // 
            this.btn_formA.Location = new System.Drawing.Point(81, 97);
            this.btn_formA.Name = "btn_formA";
            this.btn_formA.Size = new System.Drawing.Size(75, 23);
            this.btn_formA.TabIndex = 1;
            this.btn_formA.Text = "Abre form B";
            this.btn_formA.UseVisualStyleBackColor = true;
            this.btn_formA.Click += new System.EventHandler(this.btn_formA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_formA);
            this.Controls.Add(this.tbx_formA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbx_formA;
        private System.Windows.Forms.Button btn_formA;
    }
}

