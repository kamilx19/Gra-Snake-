namespace Gra_Snake
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.snakeCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.timerGry = new System.Windows.Forms.Timer(this.components);
            this.koniecGryTekst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeCanvas
            // 
            this.snakeCanvas.BackColor = System.Drawing.SystemColors.Info;
            this.snakeCanvas.Location = new System.Drawing.Point(17, 16);
            this.snakeCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.snakeCanvas.Name = "snakeCanvas";
            this.snakeCanvas.Size = new System.Drawing.Size(668, 494);
            this.snakeCanvas.TabIndex = 0;
            this.snakeCanvas.TabStop = false;
            this.snakeCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.snakeCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(715, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik ";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scoreText.Location = new System.Drawing.Point(831, 37);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 43);
            this.scoreText.TabIndex = 2;
            // 
            // koniecGryTekst
            // 
            this.koniecGryTekst.AutoSize = true;
            this.koniecGryTekst.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koniecGryTekst.Location = new System.Drawing.Point(773, 97);
            this.koniecGryTekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koniecGryTekst.Name = "koniecGryTekst";
            this.koniecGryTekst.Size = new System.Drawing.Size(112, 46);
            this.koniecGryTekst.TabIndex = 3;
            this.koniecGryTekst.Text = "label2";
            this.koniecGryTekst.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 554);
            this.Controls.Add(this.koniecGryTekst);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snakeCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gra Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timerGry;
        private System.Windows.Forms.Label koniecGryTekst;
    }
}

