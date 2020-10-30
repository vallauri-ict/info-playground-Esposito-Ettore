namespace _05_02_MetodiFactory
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
            this.txtLato = new System.Windows.Forms.TextBox();
            this.btmCrea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lato: ";
            // 
            // txtLato
            // 
            this.txtLato.Location = new System.Drawing.Point(53, 10);
            this.txtLato.Name = "txtLato";
            this.txtLato.Size = new System.Drawing.Size(100, 20);
            this.txtLato.TabIndex = 1;
            // 
            // btmCrea
            // 
            this.btmCrea.Location = new System.Drawing.Point(16, 36);
            this.btmCrea.Name = "btmCrea";
            this.btmCrea.Size = new System.Drawing.Size(137, 23);
            this.btmCrea.TabIndex = 2;
            this.btmCrea.Text = "Crea quadrato";
            this.btmCrea.UseVisualStyleBackColor = true;
            this.btmCrea.Click += new System.EventHandler(this.btmCrea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmCrea);
            this.Controls.Add(this.txtLato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLato;
        private System.Windows.Forms.Button btmCrea;
    }
}

