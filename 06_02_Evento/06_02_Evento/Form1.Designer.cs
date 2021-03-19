
namespace _06_02_Evento
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btmCrea = new System.Windows.Forms.Button();
            this.btmIncrementa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(13, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btmCrea
            // 
            this.btmCrea.Location = new System.Drawing.Point(13, 39);
            this.btmCrea.Name = "btmCrea";
            this.btmCrea.Size = new System.Drawing.Size(100, 23);
            this.btmCrea.TabIndex = 1;
            this.btmCrea.Text = "Crea";
            this.btmCrea.UseVisualStyleBackColor = true;
            this.btmCrea.Click += new System.EventHandler(this.btmCrea_Click);
            // 
            // btmIncrementa
            // 
            this.btmIncrementa.Location = new System.Drawing.Point(12, 68);
            this.btmIncrementa.Name = "btmIncrementa";
            this.btmIncrementa.Size = new System.Drawing.Size(100, 23);
            this.btmIncrementa.TabIndex = 2;
            this.btmIncrementa.Text = "Incrementa";
            this.btmIncrementa.UseVisualStyleBackColor = true;
            this.btmIncrementa.Click += new System.EventHandler(this.btmIncrementa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(130, 107);
            this.Controls.Add(this.btmIncrementa);
            this.Controls.Add(this.btmCrea);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btmCrea;
        private System.Windows.Forms.Button btmIncrementa;
    }
}

