
namespace _04_01_Ereditarietà
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
            this.btmMostro = new System.Windows.Forms.Button();
            this.btmMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmMostro
            // 
            this.btmMostro.Location = new System.Drawing.Point(13, 13);
            this.btmMostro.Name = "btmMostro";
            this.btmMostro.Size = new System.Drawing.Size(145, 73);
            this.btmMostro.TabIndex = 0;
            this.btmMostro.Text = "Mostro";
            this.btmMostro.UseVisualStyleBackColor = true;
            this.btmMostro.Click += new System.EventHandler(this.btmMostro_Click);
            // 
            // btmMannaro
            // 
            this.btmMannaro.Location = new System.Drawing.Point(164, 12);
            this.btmMannaro.Name = "btmMannaro";
            this.btmMannaro.Size = new System.Drawing.Size(145, 73);
            this.btmMannaro.TabIndex = 1;
            this.btmMannaro.Text = "Mannaro";
            this.btmMannaro.UseVisualStyleBackColor = true;
            this.btmMannaro.Click += new System.EventHandler(this.btmMannaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 96);
            this.Controls.Add(this.btmMannaro);
            this.Controls.Add(this.btmMostro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmMostro;
        private System.Windows.Forms.Button btmMannaro;
    }
}

