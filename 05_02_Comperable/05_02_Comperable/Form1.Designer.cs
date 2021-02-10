namespace _05_02_Comperable
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmOridna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmOridna
            // 
            this.btmOridna.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOridna.Location = new System.Drawing.Point(12, 12);
            this.btmOridna.Name = "btmOridna";
            this.btmOridna.Size = new System.Drawing.Size(776, 426);
            this.btmOridna.TabIndex = 0;
            this.btmOridna.Text = "Ordina";
            this.btmOridna.UseVisualStyleBackColor = true;
            this.btmOridna.Click += new System.EventHandler(this.btmOridna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmOridna);
            this.Name = "Form1";
            this.Text = "Ordina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmOridna;
    }
}

