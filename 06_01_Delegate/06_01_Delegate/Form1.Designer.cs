
namespace _06_01_Delegate
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
            this.btmSomma = new System.Windows.Forms.Button();
            this.btmProdotto = new System.Windows.Forms.Button();
            this.btmDifferenza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmSomma
            // 
            this.btmSomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSomma.Location = new System.Drawing.Point(12, 12);
            this.btmSomma.Name = "btmSomma";
            this.btmSomma.Size = new System.Drawing.Size(221, 131);
            this.btmSomma.TabIndex = 0;
            this.btmSomma.Text = "Somma";
            this.btmSomma.UseVisualStyleBackColor = true;
            this.btmSomma.Click += new System.EventHandler(this.btmSomma_Click);
            // 
            // btmProdotto
            // 
            this.btmProdotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmProdotto.Location = new System.Drawing.Point(239, 12);
            this.btmProdotto.Name = "btmProdotto";
            this.btmProdotto.Size = new System.Drawing.Size(221, 131);
            this.btmProdotto.TabIndex = 1;
            this.btmProdotto.Text = "Prodotto";
            this.btmProdotto.UseVisualStyleBackColor = true;
            this.btmProdotto.Click += new System.EventHandler(this.btmProdotto_Click);
            // 
            // btmDifferenza
            // 
            this.btmDifferenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDifferenza.Location = new System.Drawing.Point(466, 12);
            this.btmDifferenza.Name = "btmDifferenza";
            this.btmDifferenza.Size = new System.Drawing.Size(221, 131);
            this.btmDifferenza.TabIndex = 2;
            this.btmDifferenza.Text = "Differenza";
            this.btmDifferenza.UseVisualStyleBackColor = true;
            this.btmDifferenza.Click += new System.EventHandler(this.btmDifferenza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 156);
            this.Controls.Add(this.btmDifferenza);
            this.Controls.Add(this.btmProdotto);
            this.Controls.Add(this.btmSomma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmSomma;
        private System.Windows.Forms.Button btmProdotto;
        private System.Windows.Forms.Button btmDifferenza;
    }
}

