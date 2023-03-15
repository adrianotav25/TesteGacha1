namespace TesteGacha1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NomePersonagem = new System.Windows.Forms.Label();
            this.Avançar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NomePersonagem
            // 
            this.NomePersonagem.AutoSize = true;
            this.NomePersonagem.Location = new System.Drawing.Point(207, 241);
            this.NomePersonagem.Name = "NomePersonagem";
            this.NomePersonagem.Size = new System.Drawing.Size(40, 15);
            this.NomePersonagem.TabIndex = 1;
            this.NomePersonagem.Text = "Nome";
            // 
            // Avançar
            // 
            this.Avançar.Location = new System.Drawing.Point(362, 135);
            this.Avançar.Name = "Avançar";
            this.Avançar.Size = new System.Drawing.Size(75, 23);
            this.Avançar.TabIndex = 2;
            this.Avançar.Text = "Avançar";
            this.Avançar.UseVisualStyleBackColor = true;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(25, 135);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Avançar);
            this.Controls.Add(this.NomePersonagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label NomePersonagem;
        private Button Avançar;
        private Button Voltar;
    }
}