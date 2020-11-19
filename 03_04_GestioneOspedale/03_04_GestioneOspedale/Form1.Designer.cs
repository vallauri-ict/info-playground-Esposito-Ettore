
namespace _03_04_GestioneOspedale
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriorita = new System.Windows.Forms.ComboBox();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.btmChiedi = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.NumericUpDown();
            this.btmTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(63, 36);
            this.txtEta.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Età: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Priorità: ";
            // 
            // txtPriorita
            // 
            this.txtPriorita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPriorita.FormattingEnabled = true;
            this.txtPriorita.Items.AddRange(new object[] {
            "Bianco",
            "Verde",
            "Giallo",
            "Rosso"});
            this.txtPriorita.Location = new System.Drawing.Point(63, 62);
            this.txtPriorita.Name = "txtPriorita";
            this.txtPriorita.Size = new System.Drawing.Size(100, 21);
            this.txtPriorita.TabIndex = 5;
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 115);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(147, 23);
            this.btmAggiungi.TabIndex = 6;
            this.btmAggiungi.Text = "Aggiungi";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // btmChiedi
            // 
            this.btmChiedi.Location = new System.Drawing.Point(16, 144);
            this.btmChiedi.Name = "btmChiedi";
            this.btmChiedi.Size = new System.Drawing.Size(147, 23);
            this.btmChiedi.TabIndex = 7;
            this.btmChiedi.Text = "Chiedi paziente";
            this.btmChiedi.UseVisualStyleBackColor = true;
            this.btmChiedi.Click += new System.EventHandler(this.btmChiedi_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 207);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(148, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "-----------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temp.: ";
            // 
            // txtTemp
            // 
            this.txtTemp.DecimalPlaces = 1;
            this.txtTemp.Location = new System.Drawing.Point(63, 89);
            this.txtTemp.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.txtTemp.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 9;
            this.txtTemp.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // btmTemp
            // 
            this.btmTemp.Location = new System.Drawing.Point(16, 173);
            this.btmTemp.Name = "btmTemp";
            this.btmTemp.Size = new System.Drawing.Size(147, 23);
            this.btmTemp.TabIndex = 11;
            this.btmTemp.Text = "Dati temperature";
            this.btmTemp.UseVisualStyleBackColor = true;
            this.btmTemp.Click += new System.EventHandler(this.btmTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 233);
            this.Controls.Add(this.btmTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btmChiedi);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.txtPriorita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown txtEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtPriorita;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.Button btmChiedi;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTemp;
        private System.Windows.Forms.Button btmTemp;
    }
}

