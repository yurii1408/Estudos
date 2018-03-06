namespace Trocando_informacoes_entre_forms
{
    partial class FormB
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
            this.tbx_formB = new System.Windows.Forms.TextBox();
            this.btn_formB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_formB
            // 
            this.tbx_formB.Location = new System.Drawing.Point(79, 75);
            this.tbx_formB.Name = "tbx_formB";
            this.tbx_formB.Size = new System.Drawing.Size(100, 20);
            this.tbx_formB.TabIndex = 0;
            // 
            // btn_formB
            // 
            this.btn_formB.Location = new System.Drawing.Point(70, 138);
            this.btn_formB.Name = "btn_formB";
            this.btn_formB.Size = new System.Drawing.Size(121, 23);
            this.btn_formB.TabIndex = 1;
            this.btn_formB.Text = "Altera tbx form A";
            this.btn_formB.UseVisualStyleBackColor = true;
            this.btn_formB.Click += new System.EventHandler(this.btn_formB_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_formB);
            this.Controls.Add(this.tbx_formB);
            this.Name = "FormB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_formB;
        private System.Windows.Forms.Button btn_formB;
    }
}