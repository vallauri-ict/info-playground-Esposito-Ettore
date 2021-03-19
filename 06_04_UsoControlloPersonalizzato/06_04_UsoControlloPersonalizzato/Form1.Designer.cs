
namespace _06_04_UsoControlloPersonalizzato
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
            this.chkNumeri = new System.Windows.Forms.CheckBox();
            this.txtDecimali = new System.Windows.Forms.NumericUpDown();
            this.myTextBox = new _06_03_ControlliPersonalizzato.MyTextBox();
            this.btmPulisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // chkNumeri
            // 
            this.chkNumeri.AutoSize = true;
            this.chkNumeri.Location = new System.Drawing.Point(18, 61);
            this.chkNumeri.Name = "chkNumeri";
            this.chkNumeri.Size = new System.Drawing.Size(119, 17);
            this.chkNumeri.TabIndex = 1;
            this.chkNumeri.Text = "Accetta solo numeri";
            this.chkNumeri.UseVisualStyleBackColor = true;
            this.chkNumeri.CheckedChanged += new System.EventHandler(this.chkNumeri_CheckedChanged);
            // 
            // txtDecimali
            // 
            this.txtDecimali.Location = new System.Drawing.Point(201, 61);
            this.txtDecimali.Name = "txtDecimali";
            this.txtDecimali.Size = new System.Drawing.Size(58, 20);
            this.txtDecimali.TabIndex = 2;
            this.txtDecimali.ValueChanged += new System.EventHandler(this.txtDecimali_ValueChanged);
            // 
            // myTextBox
            // 
            this.myTextBox.Decimali = 0;
            this.myTextBox.Location = new System.Drawing.Point(18, 12);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Numero = false;
            this.myTextBox.Size = new System.Drawing.Size(100, 22);
            this.myTextBox.TabIndex = 3;
            this.myTextBox.Testo = "";
            // 
            // btmPulisci
            // 
            this.btmPulisci.Location = new System.Drawing.Point(315, 57);
            this.btmPulisci.Name = "btmPulisci";
            this.btmPulisci.Size = new System.Drawing.Size(75, 21);
            this.btmPulisci.TabIndex = 4;
            this.btmPulisci.Text = "Pulisci";
            this.btmPulisci.UseVisualStyleBackColor = true;
            this.btmPulisci.Click += new System.EventHandler(this.btmPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 95);
            this.Controls.Add(this.btmPulisci);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.txtDecimali);
            this.Controls.Add(this.chkNumeri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNumeri;
        private System.Windows.Forms.NumericUpDown txtDecimali;
        private _06_03_ControlliPersonalizzato.MyTextBox myTextBox;
        private System.Windows.Forms.Button btmPulisci;
    }
}

