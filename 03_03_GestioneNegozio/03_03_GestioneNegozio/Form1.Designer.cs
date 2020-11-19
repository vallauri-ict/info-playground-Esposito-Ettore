
namespace _03_03_GestioneNegozio
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
            this.txtChiave = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.btmVisualizza = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiave: ";
            // 
            // txtChiave
            // 
            this.txtChiave.Location = new System.Drawing.Point(65, 10);
            this.txtChiave.Name = "txtChiave";
            this.txtChiave.Size = new System.Drawing.Size(100, 20);
            this.txtChiave.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:  ";
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 63);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(149, 23);
            this.btmAggiungi.TabIndex = 4;
            this.btmAggiungi.Text = "Aggiungi";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // btmVisualizza
            // 
            this.btmVisualizza.Location = new System.Drawing.Point(16, 92);
            this.btmVisualizza.Name = "btmVisualizza";
            this.btmVisualizza.Size = new System.Drawing.Size(149, 23);
            this.btmVisualizza.TabIndex = 5;
            this.btmVisualizza.Text = "Visualizza";
            this.btmVisualizza.UseVisualStyleBackColor = true;
            this.btmVisualizza.Click += new System.EventHandler(this.btmVisualizza_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(14, 160);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(151, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "------------------------------------------------";
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(16, 121);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(149, 23);
            this.txtCerca.TabIndex = 7;
            this.txtCerca.Text = "Cerca";
            this.txtCerca.UseVisualStyleBackColor = true;
            this.txtCerca.Click += new System.EventHandler(this.txtCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 186);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btmVisualizza);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChiave);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.Button btmVisualizza;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button txtCerca;
    }
}

