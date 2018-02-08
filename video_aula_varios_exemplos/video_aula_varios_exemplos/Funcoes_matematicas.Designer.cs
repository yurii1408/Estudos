namespace video_aula_varios_exemplos
{
    partial class Funcoes_matematicas
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
            this.btn_absoluto = new System.Windows.Forms.Button();
            this.btn_ceiling = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_floor = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_pow = new System.Windows.Forms.Button();
            this.btn_raizq = new System.Windows.Forms.Button();
            this.btn_round = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_absoluto
            // 
            this.btn_absoluto.Location = new System.Drawing.Point(45, 37);
            this.btn_absoluto.Name = "btn_absoluto";
            this.btn_absoluto.Size = new System.Drawing.Size(74, 23);
            this.btn_absoluto.TabIndex = 0;
            this.btn_absoluto.Text = "Abs";
            this.toolTip1.SetToolTip(this.btn_absoluto, "Retorna um valor absoluto.");
            this.btn_absoluto.UseVisualStyleBackColor = true;
            this.btn_absoluto.Click += new System.EventHandler(this.btn_absoluto_Click);
            // 
            // btn_ceiling
            // 
            this.btn_ceiling.Location = new System.Drawing.Point(125, 37);
            this.btn_ceiling.Name = "btn_ceiling";
            this.btn_ceiling.Size = new System.Drawing.Size(74, 23);
            this.btn_ceiling.TabIndex = 1;
            this.btn_ceiling.Text = "Ceiling";
            this.toolTip1.SetToolTip(this.btn_ceiling, "Retorna um valor aproximado.");
            this.btn_ceiling.UseVisualStyleBackColor = true;
            this.btn_ceiling.Click += new System.EventHandler(this.btn_ceiling_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 400;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // btn_floor
            // 
            this.btn_floor.Location = new System.Drawing.Point(205, 37);
            this.btn_floor.Name = "btn_floor";
            this.btn_floor.Size = new System.Drawing.Size(75, 23);
            this.btn_floor.TabIndex = 2;
            this.btn_floor.Text = "Floor";
            this.toolTip1.SetToolTip(this.btn_floor, "O Floor faz o contrário do Ceiling, retorna um valor anterior exato.");
            this.btn_floor.UseVisualStyleBackColor = true;
            this.btn_floor.Click += new System.EventHandler(this.btn_floor_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(286, 37);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 23);
            this.btn_min.TabIndex = 3;
            this.btn_min.Text = "Min";
            this.toolTip1.SetToolTip(this.btn_min, "Retorna o valor mínimo entre dois números.");
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(45, 66);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 4;
            this.btn_max.Text = "Max";
            this.toolTip1.SetToolTip(this.btn_max, "Retorna o valor máximo entre dois números.");
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_pow
            // 
            this.btn_pow.Location = new System.Drawing.Point(126, 66);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Size = new System.Drawing.Size(73, 23);
            this.btn_pow.TabIndex = 5;
            this.btn_pow.Text = "Pow";
            this.toolTip1.SetToolTip(this.btn_pow, "Função usada para calcular expoentes.");
            this.btn_pow.UseVisualStyleBackColor = true;
            this.btn_pow.Click += new System.EventHandler(this.btn_pow_Click);
            // 
            // btn_raizq
            // 
            this.btn_raizq.Location = new System.Drawing.Point(205, 66);
            this.btn_raizq.Name = "btn_raizq";
            this.btn_raizq.Size = new System.Drawing.Size(75, 23);
            this.btn_raizq.TabIndex = 6;
            this.btn_raizq.Text = "Sqrt";
            this.toolTip1.SetToolTip(this.btn_raizq, "Função usada para tirar raiz quadrada.");
            this.btn_raizq.UseVisualStyleBackColor = true;
            this.btn_raizq.Click += new System.EventHandler(this.btn_raizq_Click);
            // 
            // btn_round
            // 
            this.btn_round.Location = new System.Drawing.Point(286, 66);
            this.btn_round.Name = "btn_round";
            this.btn_round.Size = new System.Drawing.Size(75, 23);
            this.btn_round.TabIndex = 7;
            this.btn_round.Text = "Round";
            this.toolTip1.SetToolTip(this.btn_round, "Função usada para arredondar valores.");
            this.btn_round.UseVisualStyleBackColor = true;
            this.btn_round.Click += new System.EventHandler(this.btn_round_Click);
            // 
            // Funcoes_matematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 132);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_pow);
            this.Controls.Add(this.btn_raizq);
            this.Controls.Add(this.btn_round);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_floor);
            this.Controls.Add(this.btn_ceiling);
            this.Controls.Add(this.btn_absoluto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Funcoes_matematicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funções matemáticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_absoluto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ceiling;
        private System.Windows.Forms.Button btn_floor;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_pow;
        private System.Windows.Forms.Button btn_raizq;
        private System.Windows.Forms.Button btn_round;
    }
}