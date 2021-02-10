namespace _05_01_Interfacce
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
            this.btmConnetti = new System.Windows.Forms.Button();
            this.btmDisconnetti = new System.Windows.Forms.Button();
            this.btmStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmConnetti
            // 
            this.btmConnetti.Location = new System.Drawing.Point(13, 13);
            this.btmConnetti.Name = "btmConnetti";
            this.btmConnetti.Size = new System.Drawing.Size(75, 23);
            this.btmConnetti.TabIndex = 0;
            this.btmConnetti.Text = "Connetti";
            this.btmConnetti.UseVisualStyleBackColor = true;
            this.btmConnetti.Click += new System.EventHandler(this.btmConnetti_Click);
            // 
            // btmDisconnetti
            // 
            this.btmDisconnetti.Location = new System.Drawing.Point(94, 12);
            this.btmDisconnetti.Name = "btmDisconnetti";
            this.btmDisconnetti.Size = new System.Drawing.Size(75, 23);
            this.btmDisconnetti.TabIndex = 1;
            this.btmDisconnetti.Text = "Disconnetti";
            this.btmDisconnetti.UseVisualStyleBackColor = true;
            this.btmDisconnetti.Click += new System.EventHandler(this.btmDisconnetti_Click);
            // 
            // btmStatus
            // 
            this.btmStatus.Location = new System.Drawing.Point(175, 13);
            this.btmStatus.Name = "btmStatus";
            this.btmStatus.Size = new System.Drawing.Size(75, 23);
            this.btmStatus.TabIndex = 2;
            this.btmStatus.Text = "Stato";
            this.btmStatus.UseVisualStyleBackColor = true;
            this.btmStatus.Click += new System.EventHandler(this.btmStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 51);
            this.Controls.Add(this.btmStatus);
            this.Controls.Add(this.btmDisconnetti);
            this.Controls.Add(this.btmConnetti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmConnetti;
        private System.Windows.Forms.Button btmDisconnetti;
        private System.Windows.Forms.Button btmStatus;
    }
}

