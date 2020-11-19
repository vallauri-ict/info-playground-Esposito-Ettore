
namespace _03_05_Container
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.btmTogli = new System.Windows.Forms.Button();
            this.txtCodice = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.NumericUpDown();
            this.txtTara = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTara)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tara:";
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 89);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(149, 23);
            this.btmAggiungi.TabIndex = 6;
            this.btmAggiungi.Text = "Aggiungi";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // btmTogli
            // 
            this.btmTogli.Location = new System.Drawing.Point(16, 118);
            this.btmTogli.Name = "btmTogli";
            this.btmTogli.Size = new System.Drawing.Size(149, 23);
            this.btmTogli.TabIndex = 7;
            this.btmTogli.Text = "Togli";
            this.btmTogli.UseVisualStyleBackColor = true;
            this.btmTogli.Click += new System.EventHandler(this.btmTogli_Click);
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(62, 11);
            this.txtCodice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(103, 20);
            this.txtCodice.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.DecimalPlaces = 1;
            this.txtPeso.Location = new System.Drawing.Point(62, 37);
            this.txtPeso.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(77, 20);
            this.txtPeso.TabIndex = 9;
            // 
            // txtTara
            // 
            this.txtTara.DecimalPlaces = 1;
            this.txtTara.Location = new System.Drawing.Point(62, 63);
            this.txtTara.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(77, 20);
            this.txtTara.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 158);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.btmTogli);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.Button btmTogli;
        private System.Windows.Forms.NumericUpDown txtCodice;
        private System.Windows.Forms.NumericUpDown txtPeso;
        private System.Windows.Forms.NumericUpDown txtTara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

