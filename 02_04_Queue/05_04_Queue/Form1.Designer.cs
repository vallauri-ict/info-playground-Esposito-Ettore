namespace _05_04_Queue
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
            this.txtNuovo = new System.Windows.Forms.TextBox();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.btmStampa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuovo elemento: ";
            // 
            // txtNuovo
            // 
            this.txtNuovo.Location = new System.Drawing.Point(110, 10);
            this.txtNuovo.Name = "txtNuovo";
            this.txtNuovo.Size = new System.Drawing.Size(100, 20);
            this.txtNuovo.TabIndex = 1;
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 36);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(194, 23);
            this.btmAggiungi.TabIndex = 2;
            this.btmAggiungi.Text = "Aggiungi elemento";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // btmStampa
            // 
            this.btmStampa.Location = new System.Drawing.Point(16, 65);
            this.btmStampa.Name = "btmStampa";
            this.btmStampa.Size = new System.Drawing.Size(194, 23);
            this.btmStampa.TabIndex = 3;
            this.btmStampa.Text = "Stampa";
            this.btmStampa.UseVisualStyleBackColor = true;
            this.btmStampa.Click += new System.EventHandler(this.btmStampa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 101);
            this.Controls.Add(this.btmStampa);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.txtNuovo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuovo;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.Button btmStampa;
    }
}

