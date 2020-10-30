namespace _05_03_ClasseSingleton
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.btmCreaClasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci valore: ";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(102, 10);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 1;
            // 
            // btmCreaClasse
            // 
            this.btmCreaClasse.Location = new System.Drawing.Point(16, 43);
            this.btmCreaClasse.Name = "btmCreaClasse";
            this.btmCreaClasse.Size = new System.Drawing.Size(186, 23);
            this.btmCreaClasse.TabIndex = 2;
            this.btmCreaClasse.Text = "Crea classe";
            this.btmCreaClasse.UseVisualStyleBackColor = true;
            this.btmCreaClasse.Click += new System.EventHandler(this.btmCreaClasse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 87);
            this.Controls.Add(this.btmCreaClasse);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.Button btmCreaClasse;
    }
}

