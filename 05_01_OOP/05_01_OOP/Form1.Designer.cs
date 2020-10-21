namespace _05_01_OOP
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
            this.btmCrea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmCrea
            // 
            this.btmCrea.Location = new System.Drawing.Point(13, 13);
            this.btmCrea.Name = "btmCrea";
            this.btmCrea.Size = new System.Drawing.Size(75, 23);
            this.btmCrea.TabIndex = 0;
            this.btmCrea.Text = "Crea";
            this.btmCrea.UseVisualStyleBackColor = true;
            this.btmCrea.Click += new System.EventHandler(this.btmCrea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(64, 43);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 2;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(64, 72);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altezza:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 111);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCrea);
            this.Name = "Form1";
            this.Text = "Rettangolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmCrea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
    }
}

