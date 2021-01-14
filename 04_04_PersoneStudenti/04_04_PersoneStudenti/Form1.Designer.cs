
namespace _04_04_PersoneStudenti
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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.ComboBox();
            this.txtEta = new System.Windows.Forms.NumericUpDown();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.txtVoto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btmInserisciVoto = new System.Windows.Forms.Button();
            this.btmMediaStudente = new System.Windows.Forms.Button();
            this.btmVotiStudente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(76, 36);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cognome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sesso: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "età: ";
            // 
            // txtSesso
            // 
            this.txtSesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSesso.FormattingEnabled = true;
            this.txtSesso.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.txtSesso.Location = new System.Drawing.Point(76, 62);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 21);
            this.txtSesso.TabIndex = 7;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(76, 89);
            this.txtEta.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 8;
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 115);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(160, 23);
            this.btmAggiungi.TabIndex = 9;
            this.btmAggiungi.Text = "Aggiungi studente";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(182, 10);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(323, 241);
            this.dgvStudenti.TabIndex = 10;
            this.dgvStudenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellClick);
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(76, 144);
            this.txtVoto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voto: ";
            // 
            // btmInserisciVoto
            // 
            this.btmInserisciVoto.Location = new System.Drawing.Point(16, 170);
            this.btmInserisciVoto.Name = "btmInserisciVoto";
            this.btmInserisciVoto.Size = new System.Drawing.Size(160, 23);
            this.btmInserisciVoto.TabIndex = 13;
            this.btmInserisciVoto.Text = "Inserisci voto";
            this.btmInserisciVoto.UseVisualStyleBackColor = true;
            this.btmInserisciVoto.Click += new System.EventHandler(this.btmInserisciVoto_Click);
            // 
            // btmMediaStudente
            // 
            this.btmMediaStudente.Location = new System.Drawing.Point(16, 228);
            this.btmMediaStudente.Name = "btmMediaStudente";
            this.btmMediaStudente.Size = new System.Drawing.Size(160, 23);
            this.btmMediaStudente.TabIndex = 14;
            this.btmMediaStudente.Text = "Media studente";
            this.btmMediaStudente.UseVisualStyleBackColor = true;
            this.btmMediaStudente.Click += new System.EventHandler(this.btmMediaStudente_Click);
            // 
            // btmVotiStudente
            // 
            this.btmVotiStudente.Location = new System.Drawing.Point(16, 199);
            this.btmVotiStudente.Name = "btmVotiStudente";
            this.btmVotiStudente.Size = new System.Drawing.Size(160, 23);
            this.btmVotiStudente.TabIndex = 15;
            this.btmVotiStudente.Text = "Voti studente";
            this.btmVotiStudente.UseVisualStyleBackColor = true;
            this.btmVotiStudente.Click += new System.EventHandler(this.btmVotiStudente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.Controls.Add(this.btmVotiStudente);
            this.Controls.Add(this.btmMediaStudente);
            this.Controls.Add(this.btmInserisciVoto);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtSesso;
        private System.Windows.Forms.NumericUpDown txtEta;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.NumericUpDown txtVoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmInserisciVoto;
        private System.Windows.Forms.Button btmMediaStudente;
        private System.Windows.Forms.Button btmVotiStudente;
    }
}

