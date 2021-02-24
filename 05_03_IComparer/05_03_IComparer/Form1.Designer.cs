
namespace _05_03_IComparer
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
            this.btmOrdinaCognome = new System.Windows.Forms.Button();
            this.btmOrdinaNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmOrdinaCognome
            // 
            this.btmOrdinaCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOrdinaCognome.Location = new System.Drawing.Point(12, 12);
            this.btmOrdinaCognome.Name = "btmOrdinaCognome";
            this.btmOrdinaCognome.Size = new System.Drawing.Size(765, 201);
            this.btmOrdinaCognome.TabIndex = 0;
            this.btmOrdinaCognome.Text = "Ordina cognome";
            this.btmOrdinaCognome.UseVisualStyleBackColor = true;
            this.btmOrdinaCognome.Click += new System.EventHandler(this.btmOrdinaCognome_Click);
            // 
            // btmOrdinaNome
            // 
            this.btmOrdinaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOrdinaNome.Location = new System.Drawing.Point(12, 219);
            this.btmOrdinaNome.Name = "btmOrdinaNome";
            this.btmOrdinaNome.Size = new System.Drawing.Size(765, 201);
            this.btmOrdinaNome.TabIndex = 1;
            this.btmOrdinaNome.Text = "Ordina nome";
            this.btmOrdinaNome.UseVisualStyleBackColor = true;
            this.btmOrdinaNome.Click += new System.EventHandler(this.btmOrdinaNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 430);
            this.Controls.Add(this.btmOrdinaNome);
            this.Controls.Add(this.btmOrdinaCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmOrdinaCognome;
        private System.Windows.Forms.Button btmOrdinaNome;
    }
}

