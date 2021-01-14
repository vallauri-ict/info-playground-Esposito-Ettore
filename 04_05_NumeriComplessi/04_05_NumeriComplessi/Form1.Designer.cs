
namespace _04_05_NumeriComplessi
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
            this.txtReale = new System.Windows.Forms.NumericUpDown();
            this.txtI = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btmCreaComplesso = new System.Windows.Forms.Button();
            this.CreaQuaternione = new System.Windows.Forms.Button();
            this.lblComplesso = new System.Windows.Forms.Label();
            this.lblQuaternione = new System.Windows.Forms.Label();
            this.btmModuli = new System.Windows.Forms.Button();
            this.btmConiugati = new System.Windows.Forms.Button();
            this.btmMostraNumeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtReale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reale";
            // 
            // txtReale
            // 
            this.txtReale.DecimalPlaces = 2;
            this.txtReale.Location = new System.Drawing.Point(54, 11);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(63, 20);
            this.txtReale.TabIndex = 1;
            // 
            // txtI
            // 
            this.txtI.DecimalPlaces = 2;
            this.txtI.Location = new System.Drawing.Point(54, 37);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(63, 20);
            this.txtI.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "i";
            // 
            // txtJ
            // 
            this.txtJ.DecimalPlaces = 2;
            this.txtJ.Location = new System.Drawing.Point(54, 63);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(63, 20);
            this.txtJ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "j";
            // 
            // txtK
            // 
            this.txtK.DecimalPlaces = 2;
            this.txtK.Location = new System.Drawing.Point(54, 89);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(63, 20);
            this.txtK.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "k";
            // 
            // btmCreaComplesso
            // 
            this.btmCreaComplesso.Location = new System.Drawing.Point(16, 116);
            this.btmCreaComplesso.Name = "btmCreaComplesso";
            this.btmCreaComplesso.Size = new System.Drawing.Size(100, 23);
            this.btmCreaComplesso.TabIndex = 8;
            this.btmCreaComplesso.Text = "Crea complesso";
            this.btmCreaComplesso.UseVisualStyleBackColor = true;
            this.btmCreaComplesso.Click += new System.EventHandler(this.btmCreaComplesso_Click);
            // 
            // CreaQuaternione
            // 
            this.CreaQuaternione.Location = new System.Drawing.Point(17, 145);
            this.CreaQuaternione.Name = "CreaQuaternione";
            this.CreaQuaternione.Size = new System.Drawing.Size(100, 23);
            this.CreaQuaternione.TabIndex = 9;
            this.CreaQuaternione.Text = "Crea quaternione";
            this.CreaQuaternione.UseVisualStyleBackColor = true;
            this.CreaQuaternione.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblComplesso
            // 
            this.lblComplesso.AutoSize = true;
            this.lblComplesso.Location = new System.Drawing.Point(222, 50);
            this.lblComplesso.Name = "lblComplesso";
            this.lblComplesso.Size = new System.Drawing.Size(0, 13);
            this.lblComplesso.TabIndex = 10;
            // 
            // lblQuaternione
            // 
            this.lblQuaternione.AutoSize = true;
            this.lblQuaternione.Location = new System.Drawing.Point(222, 89);
            this.lblQuaternione.Name = "lblQuaternione";
            this.lblQuaternione.Size = new System.Drawing.Size(0, 13);
            this.lblQuaternione.TabIndex = 11;
            // 
            // btmModuli
            // 
            this.btmModuli.Location = new System.Drawing.Point(226, 145);
            this.btmModuli.Name = "btmModuli";
            this.btmModuli.Size = new System.Drawing.Size(100, 23);
            this.btmModuli.TabIndex = 13;
            this.btmModuli.Text = "Calcola moduli";
            this.btmModuli.UseVisualStyleBackColor = true;
            this.btmModuli.Click += new System.EventHandler(this.btmModuli_Click);
            // 
            // btmConiugati
            // 
            this.btmConiugati.Location = new System.Drawing.Point(225, 116);
            this.btmConiugati.Name = "btmConiugati";
            this.btmConiugati.Size = new System.Drawing.Size(100, 23);
            this.btmConiugati.TabIndex = 12;
            this.btmConiugati.Text = "Calcola coniugati";
            this.btmConiugati.UseVisualStyleBackColor = true;
            this.btmConiugati.Click += new System.EventHandler(this.btmConiugati_Click);
            // 
            // btmMostraNumeri
            // 
            this.btmMostraNumeri.Location = new System.Drawing.Point(332, 145);
            this.btmMostraNumeri.Name = "btmMostraNumeri";
            this.btmMostraNumeri.Size = new System.Drawing.Size(100, 23);
            this.btmMostraNumeri.TabIndex = 14;
            this.btmMostraNumeri.Text = "Mostra numeri";
            this.btmMostraNumeri.UseVisualStyleBackColor = true;
            this.btmMostraNumeri.Click += new System.EventHandler(this.btmMostraNumeri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 175);
            this.Controls.Add(this.btmMostraNumeri);
            this.Controls.Add(this.btmModuli);
            this.Controls.Add(this.btmConiugati);
            this.Controls.Add(this.lblQuaternione);
            this.Controls.Add(this.lblComplesso);
            this.Controls.Add(this.CreaQuaternione);
            this.Controls.Add(this.btmCreaComplesso);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtReale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtReale;
        private System.Windows.Forms.NumericUpDown txtI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmCreaComplesso;
        private System.Windows.Forms.Button CreaQuaternione;
        private System.Windows.Forms.Label lblComplesso;
        private System.Windows.Forms.Label lblQuaternione;
        private System.Windows.Forms.Button btmModuli;
        private System.Windows.Forms.Button btmConiugati;
        private System.Windows.Forms.Button btmMostraNumeri;
    }
}

