namespace Multform_01
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Passata = new System.Windows.Forms.TextBox();
            this.Passa = new System.Windows.Forms.Button();
            this.ApriFormModale = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.Label();
            this.txtNomeOut = new System.Windows.Forms.TextBox();
            this.txtEtaOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "apri form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "apri form b2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Passata
            // 
            this.Passata.Location = new System.Drawing.Point(13, 42);
            this.Passata.Name = "Passata";
            this.Passata.Size = new System.Drawing.Size(100, 20);
            this.Passata.TabIndex = 2;
            // 
            // Passa
            // 
            this.Passa.Location = new System.Drawing.Point(119, 40);
            this.Passa.Name = "Passa";
            this.Passa.Size = new System.Drawing.Size(101, 23);
            this.Passa.TabIndex = 3;
            this.Passa.Text = "Passa txt a txt2";
            this.Passa.UseVisualStyleBackColor = true;
            this.Passa.Click += new System.EventHandler(this.Passa_Click);
            // 
            // ApriFormModale
            // 
            this.ApriFormModale.Location = new System.Drawing.Point(12, 68);
            this.ApriFormModale.Name = "ApriFormModale";
            this.ApriFormModale.Size = new System.Drawing.Size(100, 23);
            this.ApriFormModale.TabIndex = 4;
            this.ApriFormModale.Text = "Apri form modale";
            this.ApriFormModale.UseVisualStyleBackColor = true;
            this.ApriFormModale.Click += new System.EventHandler(this.ApriFormModale_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome: ";
            // 
            // txtEta
            // 
            this.txtEta.AutoSize = true;
            this.txtEta.Location = new System.Drawing.Point(10, 116);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(29, 13);
            this.txtEta.TabIndex = 7;
            this.txtEta.Text = "Età: ";
            // 
            // txtNomeOut
            // 
            this.txtNomeOut.Location = new System.Drawing.Point(57, 91);
            this.txtNomeOut.Name = "txtNomeOut";
            this.txtNomeOut.ReadOnly = true;
            this.txtNomeOut.Size = new System.Drawing.Size(100, 20);
            this.txtNomeOut.TabIndex = 8;
            // 
            // txtEtaOut
            // 
            this.txtEtaOut.Location = new System.Drawing.Point(57, 113);
            this.txtEtaOut.Name = "txtEtaOut";
            this.txtEtaOut.ReadOnly = true;
            this.txtEtaOut.Size = new System.Drawing.Size(100, 20);
            this.txtEtaOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEtaOut);
            this.Controls.Add(this.txtNomeOut);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ApriFormModale);
            this.Controls.Add(this.Passa);
            this.Controls.Add(this.Passata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Passata;
        private System.Windows.Forms.Button Passa;
        private System.Windows.Forms.Button ApriFormModale;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label txtEta;
        private System.Windows.Forms.TextBox txtNomeOut;
        private System.Windows.Forms.TextBox txtEtaOut;
    }
}

