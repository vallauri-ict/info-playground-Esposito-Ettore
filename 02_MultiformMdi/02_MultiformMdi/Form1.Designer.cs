﻿namespace _02_MultiformMdi
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
            this.btmApriF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmApriF1
            // 
            this.btmApriF1.Location = new System.Drawing.Point(13, 13);
            this.btmApriF1.Name = "btmApriF1";
            this.btmApriF1.Size = new System.Drawing.Size(75, 23);
            this.btmApriF1.TabIndex = 1;
            this.btmApriF1.Text = "Apri f1";
            this.btmApriF1.UseVisualStyleBackColor = true;
            this.btmApriF1.Click += new System.EventHandler(this.btmApriF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmApriF1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmApriF1;
    }
}

