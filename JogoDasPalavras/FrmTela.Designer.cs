namespace JogoDasPalavras
{
    partial class FrmForca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFrase = new System.Windows.Forms.Label();
            this.lbErros = new System.Windows.Forms.Label();
            this.lbLetrasTentadas = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnDesistir = new System.Windows.Forms.Button();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIntroducao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.pnJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFrase
            // 
            this.lbFrase.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrase.Location = new System.Drawing.Point(21, 41);
            this.lbFrase.Name = "lbFrase";
            this.lbFrase.Size = new System.Drawing.Size(540, 101);
            this.lbFrase.TabIndex = 0;
            this.lbFrase.Text = "Frase";
            // 
            // lbErros
            // 
            this.lbErros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbErros.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbErros.Location = new System.Drawing.Point(174, 311);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(387, 40);
            this.lbErros.TabIndex = 1;
            this.lbErros.Text = "Erros: 0/0";
            this.lbErros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLetrasTentadas
            // 
            this.lbLetrasTentadas.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLetrasTentadas.Location = new System.Drawing.Point(3, 142);
            this.lbLetrasTentadas.Name = "lbLetrasTentadas";
            this.lbLetrasTentadas.Size = new System.Drawing.Size(558, 169);
            this.lbLetrasTentadas.TabIndex = 2;
            this.lbLetrasTentadas.Text = "Letras tentadas:\r\nA - B - C - D - E - F - G - H - I - J - K - L - M - N - O - P -" +
    " Q - R - S - T - U - V - W - X - Y - Z";
            this.lbLetrasTentadas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoJogo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoJogo.Location = new System.Drawing.Point(565, 12);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(223, 72);
            this.btnNovoJogo.TabIndex = 3;
            this.btnNovoJogo.Text = "Novo jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnDesistir
            // 
            this.btnDesistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesistir.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesistir.Location = new System.Drawing.Point(345, 12);
            this.btnDesistir.Name = "btnDesistir";
            this.btnDesistir.Size = new System.Drawing.Size(172, 72);
            this.btnDesistir.TabIndex = 4;
            this.btnDesistir.Text = "Desistir";
            this.btnDesistir.UseVisualStyleBackColor = true;
            this.btnDesistir.Visible = false;
            this.btnDesistir.Click += new System.EventHandler(this.btnDesistir_Click);
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.lbFrase);
            this.pnJogo.Controls.Add(this.lbLetrasTentadas);
            this.pnJogo.Controls.Add(this.lbErros);
            this.pnJogo.Location = new System.Drawing.Point(227, 90);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(573, 360);
            this.pnJogo.TabIndex = 5;
            this.pnJogo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JogoDasPalavras.Properties.Resources.jv_Forca;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 426);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnIntroducao
            // 
            this.btnIntroducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIntroducao.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIntroducao.Location = new System.Drawing.Point(565, 90);
            this.btnIntroducao.Name = "btnIntroducao";
            this.btnIntroducao.Size = new System.Drawing.Size(223, 72);
            this.btnIntroducao.TabIndex = 7;
            this.btnIntroducao.Text = "Introdução";
            this.btnIntroducao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(201, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jogo da Forca";
            // 
            // btnCredito
            // 
            this.btnCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredito.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCredito.Location = new System.Drawing.Point(565, 168);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(223, 72);
            this.btnCredito.TabIndex = 9;
            this.btnCredito.Text = "Créditos";
            this.btnCredito.UseVisualStyleBackColor = true;
            // 
            // FrmForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnJogo);
            this.Controls.Add(this.btnDesistir);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnIntroducao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovoJogo);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmForca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.Load += new System.EventHandler(this.FrmForca_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmForca_KeyPress);
            this.pnJogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFrase;
        private Label lbErros;
        private Label lbLetrasTentadas;
        private Button btnNovoJogo;
        private Button btnDesistir;
        private Panel pnJogo;
        private PictureBox pictureBox1;
        private Button btnIntroducao;
        private Label label1;
        private Button btnCredito;
    }
}