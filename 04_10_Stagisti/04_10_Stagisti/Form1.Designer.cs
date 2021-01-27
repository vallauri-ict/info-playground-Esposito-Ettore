
namespace _04_10_Stagisti
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
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btmCrea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.NumericUpDown();
            this.btmCerca = new System.Windows.Forms.Button();
            this.dgvStag = new System.Windows.Forms.DataGridView();
            this.btmElimina = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(76, 32);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome: ";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(76, 58);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Città: ";
            // 
            // btmCrea
            // 
            this.btmCrea.Location = new System.Drawing.Point(12, 111);
            this.btmCrea.Name = "btmCrea";
            this.btmCrea.Size = new System.Drawing.Size(334, 53);
            this.btmCrea.TabIndex = 6;
            this.btmCrea.Text = "Crea stagista";
            this.btmCrea.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Classe: ";
            // 
            // cmbClasse
            // 
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(76, 84);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 21);
            this.cmbClasse.TabIndex = 8;
            // 
            // cmbSezione
            // 
            this.cmbSezione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(246, 6);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(100, 21);
            this.cmbSezione.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sezione:  ";
            // 
            // cmbSpec
            // 
            this.cmbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "INF",
            "MEC",
            "ELT",
            "LSSA",
            "AFM"});
            this.cmbSpec.Location = new System.Drawing.Point(246, 32);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(100, 21);
            this.cmbSpec.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Spec: ";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbAzienda.Location = new System.Drawing.Point(246, 58);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(100, 21);
            this.cmbAzienda.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Azienda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ore:";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(246, 85);
            this.txtOre.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 20);
            this.txtOre.TabIndex = 18;
            // 
            // btmCerca
            // 
            this.btmCerca.Location = new System.Drawing.Point(12, 170);
            this.btmCerca.Name = "btmCerca";
            this.btmCerca.Size = new System.Drawing.Size(334, 53);
            this.btmCerca.TabIndex = 19;
            this.btmCerca.Text = "Cerca azienda";
            this.btmCerca.UseVisualStyleBackColor = true;
            // 
            // dgvStag
            // 
            this.dgvStag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStag.Location = new System.Drawing.Point(12, 230);
            this.dgvStag.Name = "dgvStag";
            this.dgvStag.Size = new System.Drawing.Size(334, 191);
            this.dgvStag.TabIndex = 20;
            // 
            // btmElimina
            // 
            this.btmElimina.Location = new System.Drawing.Point(12, 427);
            this.btmElimina.Name = "btmElimina";
            this.btmElimina.Size = new System.Drawing.Size(164, 30);
            this.btmElimina.TabIndex = 21;
            this.btmElimina.Text = "Elimina posizione";
            this.btmElimina.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(246, 434);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Posizione:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 467);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btmElimina);
            this.Controls.Add(this.dgvStag);
            this.Controls.Add(this.btmCerca);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmCrea);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestione stage";
            ((System.ComponentModel.ISupportInitialize)(this.txtOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmCrea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtOre;
        private System.Windows.Forms.Button btmCerca;
        private System.Windows.Forms.DataGridView dgvStag;
        private System.Windows.Forms.Button btmElimina;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

