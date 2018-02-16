namespace video_aula_varios_exemplos
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulaçãoDeStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relógioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_data = new System.Windows.Forms.Label();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maskedBoxToolStripMenuItem,
            this.manipulaçãoDeStringsToolStripMenuItem,
            this.funçõesMatematicasToolStripMenuItem,
            this.bancoDeDadosToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // maskedBoxToolStripMenuItem
            // 
            this.maskedBoxToolStripMenuItem.Name = "maskedBoxToolStripMenuItem";
            this.maskedBoxToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.maskedBoxToolStripMenuItem.Text = "Masked Text Box";
            this.maskedBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedBoxToolStripMenuItem_Click);
            // 
            // manipulaçãoDeStringsToolStripMenuItem
            // 
            this.manipulaçãoDeStringsToolStripMenuItem.Name = "manipulaçãoDeStringsToolStripMenuItem";
            this.manipulaçãoDeStringsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.manipulaçãoDeStringsToolStripMenuItem.Text = "Manipulação de Strings";
            this.manipulaçãoDeStringsToolStripMenuItem.Click += new System.EventHandler(this.manipulaçãoDeStringsToolStripMenuItem_Click);
            // 
            // funçõesMatematicasToolStripMenuItem
            // 
            this.funçõesMatematicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.funçõesToolStripMenuItem});
            this.funçõesMatematicasToolStripMenuItem.Name = "funçõesMatematicasToolStripMenuItem";
            this.funçõesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.funçõesMatematicasToolStripMenuItem.Text = "Funções matemáticas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.funçõesToolStripMenuItem.Text = "Funções";
            this.funçõesToolStripMenuItem.Click += new System.EventHandler(this.funçõesMatematicasToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relógioToolStripMenuItem});
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // relógioToolStripMenuItem
            // 
            this.relógioToolStripMenuItem.Name = "relógioToolStripMenuItem";
            this.relógioToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.relógioToolStripMenuItem.Text = "Relógio";
            this.relógioToolStripMenuItem.Click += new System.EventHandler(this.relógioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este programa possui vários exemplos básicos da programação.";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(640, 341);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(41, 18);
            this.lbl_hora.TabIndex = 2;
            this.lbl_hora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(19, 341);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(39, 18);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Data";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bairrosToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            // 
            // bairrosToolStripMenuItem
            // 
            this.bairrosToolStripMenuItem.Name = "bairrosToolStripMenuItem";
            this.bairrosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bairrosToolStripMenuItem.Text = "Bairros";
            this.bairrosToolStripMenuItem.Click += new System.EventHandler(this.bairrosToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 370);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulaçãoDeStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relógioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.ToolStripMenuItem maskedBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçõesMatematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairrosToolStripMenuItem;
    }
}

