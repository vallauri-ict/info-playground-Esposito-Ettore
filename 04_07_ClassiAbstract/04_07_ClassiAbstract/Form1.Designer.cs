
namespace _04_07_ClassiAbstract
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
            this.btmElenco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmElenco
            // 
            this.btmElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmElenco.Location = new System.Drawing.Point(12, 12);
            this.btmElenco.Name = "btmElenco";
            this.btmElenco.Size = new System.Drawing.Size(368, 142);
            this.btmElenco.TabIndex = 0;
            this.btmElenco.Text = "Report studenti";
            this.btmElenco.UseVisualStyleBackColor = true;
            this.btmElenco.Click += new System.EventHandler(this.btmElenco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 172);
            this.Controls.Add(this.btmElenco);
            this.Name = "Form1";
            this.Text = "Report studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmElenco;
    }
}

