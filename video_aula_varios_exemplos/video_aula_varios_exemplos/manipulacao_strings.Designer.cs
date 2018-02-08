namespace video_aula_varios_exemplos
{
    partial class manipulacao_strings
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
            this.components = new System.ComponentModel.Container();
            this.tbx_info = new System.Windows.Forms.TextBox();
            this.btn_maiuscula = new System.Windows.Forms.Button();
            this.btn_minuscula = new System.Windows.Forms.Button();
            this.btn_substring = new System.Windows.Forms.Button();
            this.btn_indexof = new System.Windows.Forms.Button();
            this.btn_startwith = new System.Windows.Forms.Button();
            this.btn_endwith = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PadLeft = new System.Windows.Forms.Button();
            this.btn_PadRight = new System.Windows.Forms.Button();
            this.btn_trim = new System.Windows.Forms.Button();
            this.btn_TrimStart = new System.Windows.Forms.Button();
            this.btn_TrimEnd = new System.Windows.Forms.Button();
            this.ToolTip_____ = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Split = new System.Windows.Forms.Button();
            this.btn_Join = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_Format = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SFIE = new System.Windows.Forms.Button();
            this.btn_formatDeH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_info
            // 
            this.tbx_info.AllowDrop = true;
            this.tbx_info.Location = new System.Drawing.Point(58, 11);
            this.tbx_info.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_info.Name = "tbx_info";
            this.tbx_info.Size = new System.Drawing.Size(323, 20);
            this.tbx_info.TabIndex = 0;
            this.tbx_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_maiuscula
            // 
            this.btn_maiuscula.Location = new System.Drawing.Point(11, 42);
            this.btn_maiuscula.Margin = new System.Windows.Forms.Padding(2);
            this.btn_maiuscula.Name = "btn_maiuscula";
            this.btn_maiuscula.Size = new System.Drawing.Size(68, 24);
            this.btn_maiuscula.TabIndex = 1;
            this.btn_maiuscula.Text = "Maiúscula";
            this.ToolTip_____.SetToolTip(this.btn_maiuscula, "Transforma a string inserida em letras maiúsculas.");
            this.btn_maiuscula.UseVisualStyleBackColor = true;
            this.btn_maiuscula.Click += new System.EventHandler(this.btn_maiuscula_Click);
            // 
            // btn_minuscula
            // 
            this.btn_minuscula.Location = new System.Drawing.Point(83, 42);
            this.btn_minuscula.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minuscula.Name = "btn_minuscula";
            this.btn_minuscula.Size = new System.Drawing.Size(76, 24);
            this.btn_minuscula.TabIndex = 2;
            this.btn_minuscula.Text = "Minúscula";
            this.ToolTip_____.SetToolTip(this.btn_minuscula, "Transforma a string inserida em letras minúsculas.");
            this.btn_minuscula.UseVisualStyleBackColor = true;
            this.btn_minuscula.Click += new System.EventHandler(this.btn_minuscula_Click);
            // 
            // btn_substring
            // 
            this.btn_substring.Location = new System.Drawing.Point(163, 42);
            this.btn_substring.Margin = new System.Windows.Forms.Padding(2);
            this.btn_substring.Name = "btn_substring";
            this.btn_substring.Size = new System.Drawing.Size(66, 24);
            this.btn_substring.TabIndex = 3;
            this.btn_substring.Text = "Substring";
            this.ToolTip_____.SetToolTip(this.btn_substring, "Com a substring vc pode definir a partir de qual valor a string será lida. No mom" +
        "ento está definido o valor 4 .");
            this.btn_substring.UseVisualStyleBackColor = true;
            this.btn_substring.Click += new System.EventHandler(this.btn_substring_Click);
            // 
            // btn_indexof
            // 
            this.btn_indexof.Location = new System.Drawing.Point(234, 42);
            this.btn_indexof.Margin = new System.Windows.Forms.Padding(2);
            this.btn_indexof.Name = "btn_indexof";
            this.btn_indexof.Size = new System.Drawing.Size(56, 24);
            this.btn_indexof.TabIndex = 4;
            this.btn_indexof.Text = "IndexOf";
            this.ToolTip_____.SetToolTip(this.btn_indexof, "IndexOf serve para procurar um valor dentro de uma string. Atualmente está defini" +
        "do o valor \"Yuri\".");
            this.btn_indexof.UseVisualStyleBackColor = true;
            this.btn_indexof.Click += new System.EventHandler(this.btn_indexof_Click);
            // 
            // btn_startwith
            // 
            this.btn_startwith.Location = new System.Drawing.Point(294, 42);
            this.btn_startwith.Margin = new System.Windows.Forms.Padding(2);
            this.btn_startwith.Name = "btn_startwith";
            this.btn_startwith.Size = new System.Drawing.Size(56, 24);
            this.btn_startwith.TabIndex = 5;
            this.btn_startwith.Text = "StartWith";
            this.ToolTip_____.SetToolTip(this.btn_startwith, "Verifica se a string começa com determinado valor. O valor definido atualmente é " +
        "\"Yuri\".");
            this.btn_startwith.UseVisualStyleBackColor = true;
            this.btn_startwith.Click += new System.EventHandler(this.btn_startwith_Click);
            // 
            // btn_endwith
            // 
            this.btn_endwith.Location = new System.Drawing.Point(355, 42);
            this.btn_endwith.Margin = new System.Windows.Forms.Padding(2);
            this.btn_endwith.Name = "btn_endwith";
            this.btn_endwith.Size = new System.Drawing.Size(56, 24);
            this.btn_endwith.TabIndex = 6;
            this.btn_endwith.Text = "EndWith";
            this.ToolTip_____.SetToolTip(this.btn_endwith, "Verifica se a string termina com determinado valor. Atualmente o valor definido é" +
        " \".txt\".");
            this.btn_endwith.UseVisualStyleBackColor = true;
            this.btn_endwith.Click += new System.EventHandler(this.btn_endwith_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(2, 20);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 39);
            this.lbl_info.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 81);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado:";
            // 
            // btn_PadLeft
            // 
            this.btn_PadLeft.Location = new System.Drawing.Point(11, 70);
            this.btn_PadLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PadLeft.Name = "btn_PadLeft";
            this.btn_PadLeft.Size = new System.Drawing.Size(68, 24);
            this.btn_PadLeft.TabIndex = 9;
            this.btn_PadLeft.Text = "PadLeft";
            this.ToolTip_____.SetToolTip(this.btn_PadLeft, "Insere caracteres à esquerda da string.");
            this.btn_PadLeft.UseVisualStyleBackColor = true;
            this.btn_PadLeft.Click += new System.EventHandler(this.btn_PadLeft_Click);
            // 
            // btn_PadRight
            // 
            this.btn_PadRight.Location = new System.Drawing.Point(85, 70);
            this.btn_PadRight.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PadRight.Name = "btn_PadRight";
            this.btn_PadRight.Size = new System.Drawing.Size(74, 24);
            this.btn_PadRight.TabIndex = 10;
            this.btn_PadRight.Text = "PadRight";
            this.ToolTip_____.SetToolTip(this.btn_PadRight, "Insere caracteres à direita da string.");
            this.btn_PadRight.UseVisualStyleBackColor = true;
            this.btn_PadRight.Click += new System.EventHandler(this.btn_PadRight_Click);
            // 
            // btn_trim
            // 
            this.btn_trim.Location = new System.Drawing.Point(163, 70);
            this.btn_trim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_trim.Name = "btn_trim";
            this.btn_trim.Size = new System.Drawing.Size(66, 24);
            this.btn_trim.TabIndex = 11;
            this.btn_trim.Text = "Trim";
            this.ToolTip_____.SetToolTip(this.btn_trim, "Remove espaços de uma string.");
            this.btn_trim.UseVisualStyleBackColor = true;
            this.btn_trim.Click += new System.EventHandler(this.btn_Trim_Click);
            // 
            // btn_TrimStart
            // 
            this.btn_TrimStart.Location = new System.Drawing.Point(233, 70);
            this.btn_TrimStart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TrimStart.Name = "btn_TrimStart";
            this.btn_TrimStart.Size = new System.Drawing.Size(57, 24);
            this.btn_TrimStart.TabIndex = 12;
            this.btn_TrimStart.Text = "TrimStart";
            this.ToolTip_____.SetToolTip(this.btn_TrimStart, "Remove somente os espaços do começo de uma string.");
            this.btn_TrimStart.UseVisualStyleBackColor = true;
            this.btn_TrimStart.Click += new System.EventHandler(this.btn_TrimStart_Click);
            // 
            // btn_TrimEnd
            // 
            this.btn_TrimEnd.Location = new System.Drawing.Point(293, 70);
            this.btn_TrimEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TrimEnd.Name = "btn_TrimEnd";
            this.btn_TrimEnd.Size = new System.Drawing.Size(57, 24);
            this.btn_TrimEnd.TabIndex = 13;
            this.btn_TrimEnd.Text = "TrimEnd";
            this.ToolTip_____.SetToolTip(this.btn_TrimEnd, "Remove somente os espaços do final de uma string.");
            this.btn_TrimEnd.UseVisualStyleBackColor = true;
            this.btn_TrimEnd.Click += new System.EventHandler(this.btn_TrimEnd_Click);
            // 
            // ToolTip_____
            // 
            this.ToolTip_____.AutoPopDelay = 10000;
            this.ToolTip_____.InitialDelay = 500;
            this.ToolTip_____.IsBalloon = true;
            this.ToolTip_____.ReshowDelay = 100;
            this.ToolTip_____.Tag = "ToolTip de ajuda ao usuário.";
            this.ToolTip_____.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_____.ToolTipTitle = "Info";
            // 
            // btn_Split
            // 
            this.btn_Split.Location = new System.Drawing.Point(355, 70);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(56, 24);
            this.btn_Split.TabIndex = 14;
            this.btn_Split.Text = "Split";
            this.ToolTip_____.SetToolTip(this.btn_Split, "Ideal para transformar strings em arrays, no momento o codigo está configurado pa" +
        "ra identificar 1 array a cada \" \" (espaço)");
            this.btn_Split.UseVisualStyleBackColor = true;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // btn_Join
            // 
            this.btn_Join.Location = new System.Drawing.Point(11, 99);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(68, 23);
            this.btn_Join.TabIndex = 14;
            this.btn_Join.Text = "Join";
            this.ToolTip_____.SetToolTip(this.btn_Join, "O método Join faz o contrário do Split, ele printa na tela um conjunto de array j" +
        "á pré definido.");
            this.btn_Join.UseVisualStyleBackColor = true;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.Color.Black;
            this.btn_clean.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clean.Location = new System.Drawing.Point(386, 11);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(24, 20);
            this.btn_clean.TabIndex = 15;
            this.ToolTip_____.SetToolTip(this.btn_clean, "Borracha");
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_Format
            // 
            this.btn_Format.Location = new System.Drawing.Point(85, 99);
            this.btn_Format.Name = "btn_Format";
            this.btn_Format.Size = new System.Drawing.Size(78, 23);
            this.btn_Format.TabIndex = 14;
            this.btn_Format.Text = "String.Format";
            this.ToolTip_____.SetToolTip(this.btn_Format, "Pode-se pré definir palavras ou numeros para inserir no meio de uma string.");
            this.btn_Format.UseVisualStyleBackColor = true;
            this.btn_Format.Click += new System.EventHandler(this.btn_Format_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Entrada:";
            // 
            // btn_SFIE
            // 
            this.btn_SFIE.Location = new System.Drawing.Point(170, 99);
            this.btn_SFIE.Name = "btn_SFIE";
            this.btn_SFIE.Size = new System.Drawing.Size(242, 23);
            this.btn_SFIE.TabIndex = 17;
            this.btn_SFIE.Text = "String Format Inteiros e espaços";
            this.ToolTip_____.SetToolTip(this.btn_SFIE, "O mesmo do string format, apenas com formatações diferentes.");
            this.btn_SFIE.UseVisualStyleBackColor = true;
            this.btn_SFIE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_formatDeH
            // 
            this.btn_formatDeH.Location = new System.Drawing.Point(11, 128);
            this.btn_formatDeH.Name = "btn_formatDeH";
            this.btn_formatDeH.Size = new System.Drawing.Size(111, 23);
            this.btn_formatDeH.TabIndex = 18;
            this.btn_formatDeH.Text = "Format Data e Hora";
            this.ToolTip_____.SetToolTip(this.btn_formatDeH, "O mesmo do string format, apenas com formatando datas.");
            this.btn_formatDeH.UseVisualStyleBackColor = true;
            this.btn_formatDeH.Click += new System.EventHandler(this.btn_formatDeH_Click);
            // 
            // manipulacao_strings
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 249);
            this.Controls.Add(this.btn_formatDeH);
            this.Controls.Add(this.btn_SFIE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_Format);
            this.Controls.Add(this.btn_Join);
            this.Controls.Add(this.btn_Split);
            this.Controls.Add(this.tbx_info);
            this.Controls.Add(this.btn_TrimEnd);
            this.Controls.Add(this.btn_TrimStart);
            this.Controls.Add(this.btn_trim);
            this.Controls.Add(this.btn_PadRight);
            this.Controls.Add(this.btn_PadLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_endwith);
            this.Controls.Add(this.btn_startwith);
            this.Controls.Add(this.btn_indexof);
            this.Controls.Add(this.btn_substring);
            this.Controls.Add(this.btn_minuscula);
            this.Controls.Add(this.btn_maiuscula);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "manipulacao_strings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos de manipulação de Strings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_info;
        private System.Windows.Forms.Button btn_maiuscula;
        private System.Windows.Forms.Button btn_minuscula;
        private System.Windows.Forms.Button btn_substring;
        private System.Windows.Forms.Button btn_indexof;
        private System.Windows.Forms.Button btn_startwith;
        private System.Windows.Forms.Button btn_endwith;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PadLeft;
        private System.Windows.Forms.Button btn_PadRight;
        private System.Windows.Forms.Button btn_trim;
        private System.Windows.Forms.Button btn_TrimStart;
        private System.Windows.Forms.Button btn_TrimEnd;
        private System.Windows.Forms.ToolTip ToolTip_____;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Format;
        private System.Windows.Forms.Button btn_SFIE;
        private System.Windows.Forms.Button btn_formatDeH;
    }
}