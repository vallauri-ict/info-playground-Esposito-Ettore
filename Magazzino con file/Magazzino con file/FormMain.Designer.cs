namespace Magazzino_con_file
{
    partial class FormMain
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
            this.dgvArt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVen = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.txtNomArt = new System.Windows.Forms.TextBox();
            this.sltAzienda = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.NumericUpDown();
            this.txtGiacenza = new System.Windows.Forms.NumericUpDown();
            this.txtScorta = new System.Windows.Forms.NumericUpDown();
            this.btmInserisciArticolo = new System.Windows.Forms.Button();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.sltCodForn = new System.Windows.Forms.ComboBox();
            this.btmInserisciCliente = new System.Windows.Forms.Button();
            this.sltCittà = new System.Windows.Forms.ComboBox();
            this.txtCognCli = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.btnInserisciVendta = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantità = new System.Windows.Forms.NumericUpDown();
            this.sltCodArt = new System.Windows.Forms.ComboBox();
            this.sltCodCli = new System.Windows.Forms.ComboBox();
            this.btmCercaArticoloCodice = new System.Windows.Forms.Button();
            this.btmModArt = new System.Windows.Forms.Button();
            this.btmModCli = new System.Windows.Forms.Button();
            this.btmCercaClienteCodice = new System.Windows.Forms.Button();
            this.btmTotaleVenduto = new System.Windows.Forms.Button();
            this.btmContaVenditiPerArticolo = new System.Windows.Forms.Button();
            this.btmTotaleAcquistiCliente = new System.Windows.Forms.Button();
            this.btmCalcolaAcquistiPerCliente = new System.Windows.Forms.Button();
            this.btmCercaMaxFornitore = new System.Windows.Forms.Button();
            this.btmCercaArtInvenduti = new System.Windows.Forms.Button();
            this.btmCercaVenditeData = new System.Windows.Forms.Button();
            this.btmArtVendutiTraDueDate = new System.Windows.Forms.Button();
            this.btmGiornoPiuVendite = new System.Windows.Forms.Button();
            this.btmDataMaxIncassi = new System.Windows.Forms.Button();
            this.btmCercaClientiArticolo = new System.Windows.Forms.Button();
            this.btmCercaClientinonArticolo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiacenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantità)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.Location = new System.Drawing.Point(12, 25);
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.Size = new System.Drawing.Size(545, 399);
            this.dgvArt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articoli";
            // 
            // dgvCli
            // 
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.Location = new System.Drawing.Point(563, 25);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.Size = new System.Drawing.Size(309, 399);
            this.dgvCli.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clienti";
            // 
            // dgvVen
            // 
            this.dgvVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVen.Location = new System.Drawing.Point(878, 25);
            this.dgvVen.Name = "dgvVen";
            this.dgvVen.Size = new System.Drawing.Size(348, 399);
            this.dgvVen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codice articolo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Azienda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prezzo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Giacenza:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Scorta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Codice fornitore:";
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(119, 430);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(120, 20);
            this.txtCodArt.TabIndex = 13;
            // 
            // txtNomArt
            // 
            this.txtNomArt.Location = new System.Drawing.Point(119, 456);
            this.txtNomArt.Name = "txtNomArt";
            this.txtNomArt.Size = new System.Drawing.Size(120, 20);
            this.txtNomArt.TabIndex = 14;
            // 
            // sltAzienda
            // 
            this.sltAzienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltAzienda.FormattingEnabled = true;
            this.sltAzienda.Items.AddRange(new object[] {
            "Intel",
            "Corsair",
            "HP",
            "Microsoft"});
            this.sltAzienda.Location = new System.Drawing.Point(118, 483);
            this.sltAzienda.Name = "sltAzienda";
            this.sltAzienda.Size = new System.Drawing.Size(121, 21);
            this.sltAzienda.TabIndex = 20;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(118, 510);
            this.txtPrezzo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtPrezzo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(121, 20);
            this.txtPrezzo.TabIndex = 21;
            this.txtPrezzo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGiacenza
            // 
            this.txtGiacenza.Location = new System.Drawing.Point(119, 536);
            this.txtGiacenza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGiacenza.Name = "txtGiacenza";
            this.txtGiacenza.Size = new System.Drawing.Size(120, 20);
            this.txtGiacenza.TabIndex = 22;
            this.txtGiacenza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtScorta
            // 
            this.txtScorta.Location = new System.Drawing.Point(118, 562);
            this.txtScorta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtScorta.Name = "txtScorta";
            this.txtScorta.Size = new System.Drawing.Size(121, 20);
            this.txtScorta.TabIndex = 23;
            this.txtScorta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btmInserisciArticolo
            // 
            this.btmInserisciArticolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserisciArticolo.Location = new System.Drawing.Point(12, 618);
            this.btmInserisciArticolo.Name = "btmInserisciArticolo";
            this.btmInserisciArticolo.Size = new System.Drawing.Size(227, 38);
            this.btmInserisciArticolo.TabIndex = 24;
            this.btmInserisciArticolo.Text = "Inserisci articolo";
            this.btmInserisciArticolo.UseVisualStyleBackColor = true;
            this.btmInserisciArticolo.Click += new System.EventHandler(this.btmInserisciArticolo_Click);
            // 
            // dgvForn
            // 
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Location = new System.Drawing.Point(1232, 25);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.Size = new System.Drawing.Size(247, 399);
            this.dgvForn.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1229, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fornitori";
            // 
            // sltCodForn
            // 
            this.sltCodForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltCodForn.FormattingEnabled = true;
            this.sltCodForn.Items.AddRange(new object[] {
            "Intel",
            "Corsair",
            "HP",
            "Microsoft"});
            this.sltCodForn.Location = new System.Drawing.Point(118, 586);
            this.sltCodForn.Name = "sltCodForn";
            this.sltCodForn.Size = new System.Drawing.Size(121, 21);
            this.sltCodForn.TabIndex = 27;
            // 
            // btmInserisciCliente
            // 
            this.btmInserisciCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserisciCliente.Location = new System.Drawing.Point(560, 536);
            this.btmInserisciCliente.Name = "btmInserisciCliente";
            this.btmInserisciCliente.Size = new System.Drawing.Size(227, 38);
            this.btmInserisciCliente.TabIndex = 41;
            this.btmInserisciCliente.Text = "Inserisci cliente";
            this.btmInserisciCliente.UseVisualStyleBackColor = true;
            this.btmInserisciCliente.Click += new System.EventHandler(this.btmInserisciCliente_Click);
            // 
            // sltCittà
            // 
            this.sltCittà.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltCittà.FormattingEnabled = true;
            this.sltCittà.Items.AddRange(new object[] {
            "Intel",
            "Corsair",
            "HP",
            "Microsoft"});
            this.sltCittà.Location = new System.Drawing.Point(667, 509);
            this.sltCittà.Name = "sltCittà";
            this.sltCittà.Size = new System.Drawing.Size(121, 21);
            this.sltCittà.TabIndex = 37;
            // 
            // txtCognCli
            // 
            this.txtCognCli.Location = new System.Drawing.Point(668, 456);
            this.txtCognCli.Name = "txtCognCli";
            this.txtCognCli.Size = new System.Drawing.Size(120, 20);
            this.txtCognCli.TabIndex = 36;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(668, 430);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(120, 20);
            this.txtCodCli.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(558, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Città:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(559, 484);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Nome:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(559, 457);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "Cognome:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(560, 431);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Codice cliente:";
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(667, 483);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(120, 20);
            this.txtNomCli.TabIndex = 42;
            // 
            // btnInserisciVendta
            // 
            this.btnInserisciVendta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciVendta.Location = new System.Drawing.Point(875, 536);
            this.btnInserisciVendta.Name = "btnInserisciVendta";
            this.btnInserisciVendta.Size = new System.Drawing.Size(227, 38);
            this.btnInserisciVendta.TabIndex = 50;
            this.btnInserisciVendta.Text = "Inserisci vendita";
            this.btnInserisciVendta.UseVisualStyleBackColor = true;
            this.btnInserisciVendta.Click += new System.EventHandler(this.btnInserisciVendta_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(873, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Data:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(874, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Quantità:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(874, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Codice cliente:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(875, 431);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 16);
            this.label19.TabIndex = 43;
            this.label19.Text = "Codice articolo:";
            // 
            // txtDate
            // 
            this.txtDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(982, 510);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(120, 20);
            this.txtDate.TabIndex = 52;
            // 
            // txtQuantità
            // 
            this.txtQuantità.Location = new System.Drawing.Point(981, 484);
            this.txtQuantità.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtQuantità.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantità.Name = "txtQuantità";
            this.txtQuantità.Size = new System.Drawing.Size(121, 20);
            this.txtQuantità.TabIndex = 53;
            this.txtQuantità.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sltCodArt
            // 
            this.sltCodArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltCodArt.FormattingEnabled = true;
            this.sltCodArt.Items.AddRange(new object[] {
            "Intel",
            "Corsair",
            "HP",
            "Microsoft"});
            this.sltCodArt.Location = new System.Drawing.Point(982, 430);
            this.sltCodArt.Name = "sltCodArt";
            this.sltCodArt.Size = new System.Drawing.Size(121, 21);
            this.sltCodArt.TabIndex = 54;
            // 
            // sltCodCli
            // 
            this.sltCodCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltCodCli.FormattingEnabled = true;
            this.sltCodCli.Items.AddRange(new object[] {
            "Intel",
            "Corsair",
            "HP",
            "Microsoft"});
            this.sltCodCli.Location = new System.Drawing.Point(981, 456);
            this.sltCodCli.Name = "sltCodCli";
            this.sltCodCli.Size = new System.Drawing.Size(121, 21);
            this.sltCodCli.TabIndex = 55;
            // 
            // btmCercaArticoloCodice
            // 
            this.btmCercaArticoloCodice.Location = new System.Drawing.Point(245, 427);
            this.btmCercaArticoloCodice.Name = "btmCercaArticoloCodice";
            this.btmCercaArticoloCodice.Size = new System.Drawing.Size(147, 23);
            this.btmCercaArticoloCodice.TabIndex = 56;
            this.btmCercaArticoloCodice.Text = "Cerca articolo col codice";
            this.btmCercaArticoloCodice.UseVisualStyleBackColor = true;
            this.btmCercaArticoloCodice.Click += new System.EventHandler(this.btmCercaArticoloCodice_Click);
            // 
            // btmModArt
            // 
            this.btmModArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModArt.Location = new System.Drawing.Point(13, 662);
            this.btmModArt.Name = "btmModArt";
            this.btmModArt.Size = new System.Drawing.Size(227, 38);
            this.btmModArt.TabIndex = 57;
            this.btmModArt.Text = "Modifica articolo";
            this.btmModArt.UseVisualStyleBackColor = true;
            this.btmModArt.Click += new System.EventHandler(this.btmModArt_Click);
            // 
            // btmModCli
            // 
            this.btmModCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModCli.Location = new System.Drawing.Point(561, 580);
            this.btmModCli.Name = "btmModCli";
            this.btmModCli.Size = new System.Drawing.Size(227, 38);
            this.btmModCli.TabIndex = 58;
            this.btmModCli.Text = "Modifica cliente";
            this.btmModCli.UseVisualStyleBackColor = true;
            this.btmModCli.Click += new System.EventHandler(this.btmModCli_Click);
            // 
            // btmCercaClienteCodice
            // 
            this.btmCercaClienteCodice.Location = new System.Drawing.Point(407, 428);
            this.btmCercaClienteCodice.Name = "btmCercaClienteCodice";
            this.btmCercaClienteCodice.Size = new System.Drawing.Size(147, 23);
            this.btmCercaClienteCodice.TabIndex = 59;
            this.btmCercaClienteCodice.Text = "Cerca cliente col codice";
            this.btmCercaClienteCodice.UseVisualStyleBackColor = true;
            this.btmCercaClienteCodice.Click += new System.EventHandler(this.btmCercaClienteCodice_Click);
            // 
            // btmTotaleVenduto
            // 
            this.btmTotaleVenduto.Location = new System.Drawing.Point(1232, 431);
            this.btmTotaleVenduto.Name = "btmTotaleVenduto";
            this.btmTotaleVenduto.Size = new System.Drawing.Size(147, 23);
            this.btmTotaleVenduto.TabIndex = 60;
            this.btmTotaleVenduto.Text = "Calcola totale venduto\r\n";
            this.btmTotaleVenduto.UseVisualStyleBackColor = true;
            this.btmTotaleVenduto.Click += new System.EventHandler(this.btmTotaleVenduto_Click);
            // 
            // btmContaVenditiPerArticolo
            // 
            this.btmContaVenditiPerArticolo.Location = new System.Drawing.Point(1232, 456);
            this.btmContaVenditiPerArticolo.Name = "btmContaVenditiPerArticolo";
            this.btmContaVenditiPerArticolo.Size = new System.Drawing.Size(147, 23);
            this.btmContaVenditiPerArticolo.TabIndex = 61;
            this.btmContaVenditiPerArticolo.Text = "Conta vendite per articolo";
            this.btmContaVenditiPerArticolo.UseVisualStyleBackColor = true;
            this.btmContaVenditiPerArticolo.Click += new System.EventHandler(this.btmContaVenditiPerArticolo_Click);
            // 
            // btmTotaleAcquistiCliente
            // 
            this.btmTotaleAcquistiCliente.Location = new System.Drawing.Point(1232, 481);
            this.btmTotaleAcquistiCliente.Name = "btmTotaleAcquistiCliente";
            this.btmTotaleAcquistiCliente.Size = new System.Drawing.Size(147, 23);
            this.btmTotaleAcquistiCliente.TabIndex = 62;
            this.btmTotaleAcquistiCliente.Text = "Conta acquisti di un cliente";
            this.btmTotaleAcquistiCliente.UseVisualStyleBackColor = true;
            this.btmTotaleAcquistiCliente.Click += new System.EventHandler(this.btmTotaleAcquistiCliente_Click);
            // 
            // btmCalcolaAcquistiPerCliente
            // 
            this.btmCalcolaAcquistiPerCliente.Location = new System.Drawing.Point(1232, 507);
            this.btmCalcolaAcquistiPerCliente.Name = "btmCalcolaAcquistiPerCliente";
            this.btmCalcolaAcquistiPerCliente.Size = new System.Drawing.Size(147, 23);
            this.btmCalcolaAcquistiPerCliente.TabIndex = 63;
            this.btmCalcolaAcquistiPerCliente.Text = "Conta acquisti di ogni cliente";
            this.btmCalcolaAcquistiPerCliente.UseVisualStyleBackColor = true;
            this.btmCalcolaAcquistiPerCliente.Click += new System.EventHandler(this.btmCalcolaAcquistiPerCliente_Click);
            // 
            // btmCercaMaxFornitore
            // 
            this.btmCercaMaxFornitore.Location = new System.Drawing.Point(1231, 536);
            this.btmCercaMaxFornitore.Name = "btmCercaMaxFornitore";
            this.btmCercaMaxFornitore.Size = new System.Drawing.Size(147, 23);
            this.btmCercaMaxFornitore.TabIndex = 64;
            this.btmCercaMaxFornitore.Text = "Cerca fornitore più forniente";
            this.btmCercaMaxFornitore.UseVisualStyleBackColor = true;
            this.btmCercaMaxFornitore.Click += new System.EventHandler(this.btmCercaMaxFornitore_Click);
            // 
            // btmCercaArtInvenduti
            // 
            this.btmCercaArtInvenduti.Location = new System.Drawing.Point(1231, 565);
            this.btmCercaArtInvenduti.Name = "btmCercaArtInvenduti";
            this.btmCercaArtInvenduti.Size = new System.Drawing.Size(147, 23);
            this.btmCercaArtInvenduti.TabIndex = 65;
            this.btmCercaArtInvenduti.Text = "Cerca articoli invenduti";
            this.btmCercaArtInvenduti.UseVisualStyleBackColor = true;
            this.btmCercaArtInvenduti.Click += new System.EventHandler(this.btmCercaArtInvenduti_Click);
            // 
            // btmCercaVenditeData
            // 
            this.btmCercaVenditeData.Location = new System.Drawing.Point(1232, 594);
            this.btmCercaVenditeData.Name = "btmCercaVenditeData";
            this.btmCercaVenditeData.Size = new System.Drawing.Size(147, 23);
            this.btmCercaVenditeData.TabIndex = 66;
            this.btmCercaVenditeData.Text = "Ceca articoli dopo la data";
            this.btmCercaVenditeData.UseVisualStyleBackColor = true;
            this.btmCercaVenditeData.Click += new System.EventHandler(this.btmCercaVenditeData_Click);
            // 
            // btmArtVendutiTraDueDate
            // 
            this.btmArtVendutiTraDueDate.Location = new System.Drawing.Point(1232, 623);
            this.btmArtVendutiTraDueDate.Name = "btmArtVendutiTraDueDate";
            this.btmArtVendutiTraDueDate.Size = new System.Drawing.Size(147, 23);
            this.btmArtVendutiTraDueDate.TabIndex = 67;
            this.btmArtVendutiTraDueDate.Text = "Ceca articoli tra due date";
            this.btmArtVendutiTraDueDate.UseVisualStyleBackColor = true;
            this.btmArtVendutiTraDueDate.Click += new System.EventHandler(this.btmArtVendutiTraDueDate_Click);
            // 
            // btmGiornoPiuVendite
            // 
            this.btmGiornoPiuVendite.Location = new System.Drawing.Point(1231, 652);
            this.btmGiornoPiuVendite.Name = "btmGiornoPiuVendite";
            this.btmGiornoPiuVendite.Size = new System.Drawing.Size(147, 23);
            this.btmGiornoPiuVendite.TabIndex = 68;
            this.btmGiornoPiuVendite.Text = "Ceca data con più vendite\r\n";
            this.btmGiornoPiuVendite.UseVisualStyleBackColor = true;
            this.btmGiornoPiuVendite.Click += new System.EventHandler(this.btmGiornoPiuVendite_Click);
            // 
            // btmDataMaxIncassi
            // 
            this.btmDataMaxIncassi.Location = new System.Drawing.Point(1232, 681);
            this.btmDataMaxIncassi.Name = "btmDataMaxIncassi";
            this.btmDataMaxIncassi.Size = new System.Drawing.Size(147, 23);
            this.btmDataMaxIncassi.TabIndex = 69;
            this.btmDataMaxIncassi.Text = "Ceca data con più incassi\r\n\r\n";
            this.btmDataMaxIncassi.UseVisualStyleBackColor = true;
            this.btmDataMaxIncassi.Click += new System.EventHandler(this.btmDataMaxIncassi_Click);
            // 
            // btmCercaClientiArticolo
            // 
            this.btmCercaClientiArticolo.Location = new System.Drawing.Point(1232, 710);
            this.btmCercaClientiArticolo.Name = "btmCercaClientiArticolo";
            this.btmCercaClientiArticolo.Size = new System.Drawing.Size(147, 23);
            this.btmCercaClientiArticolo.TabIndex = 70;
            this.btmCercaClientiArticolo.Text = "Ceca clienti che hanno acquistato un articolo";
            this.btmCercaClientiArticolo.UseVisualStyleBackColor = true;
            this.btmCercaClientiArticolo.Click += new System.EventHandler(this.btmCercaClientiArticolo_Click);
            // 
            // btmCercaClientinonArticolo
            // 
            this.btmCercaClientinonArticolo.Location = new System.Drawing.Point(1231, 739);
            this.btmCercaClientinonArticolo.Name = "btmCercaClientinonArticolo";
            this.btmCercaClientinonArticolo.Size = new System.Drawing.Size(147, 23);
            this.btmCercaClientinonArticolo.TabIndex = 71;
            this.btmCercaClientinonArticolo.Text = "Ceca clienti che non hanno acquistato un articolo";
            this.btmCercaClientinonArticolo.UseVisualStyleBackColor = true;
            this.btmCercaClientinonArticolo.Click += new System.EventHandler(this.btmCercaClientinonArticolo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 822);
            this.Controls.Add(this.btmCercaClientinonArticolo);
            this.Controls.Add(this.btmCercaClientiArticolo);
            this.Controls.Add(this.btmDataMaxIncassi);
            this.Controls.Add(this.btmGiornoPiuVendite);
            this.Controls.Add(this.btmArtVendutiTraDueDate);
            this.Controls.Add(this.btmCercaVenditeData);
            this.Controls.Add(this.btmCercaArtInvenduti);
            this.Controls.Add(this.btmCercaMaxFornitore);
            this.Controls.Add(this.btmCalcolaAcquistiPerCliente);
            this.Controls.Add(this.btmTotaleAcquistiCliente);
            this.Controls.Add(this.btmContaVenditiPerArticolo);
            this.Controls.Add(this.btmTotaleVenduto);
            this.Controls.Add(this.btmCercaClienteCodice);
            this.Controls.Add(this.btmModCli);
            this.Controls.Add(this.btmModArt);
            this.Controls.Add(this.btmCercaArticoloCodice);
            this.Controls.Add(this.sltCodCli);
            this.Controls.Add(this.sltCodArt);
            this.Controls.Add(this.txtQuantità);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnInserisciVendta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.btmInserisciCliente);
            this.Controls.Add(this.sltCittà);
            this.Controls.Add(this.txtCognCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.sltCodForn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.btmInserisciArticolo);
            this.Controls.Add(this.txtScorta);
            this.Controls.Add(this.txtGiacenza);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.sltAzienda);
            this.Controls.Add(this.txtNomArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArt);
            this.Name = "FormMain";
            this.Text = "Magazzino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiacenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantità)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.TextBox txtNomArt;
        private System.Windows.Forms.ComboBox sltAzienda;
        private System.Windows.Forms.NumericUpDown txtPrezzo;
        private System.Windows.Forms.NumericUpDown txtGiacenza;
        private System.Windows.Forms.NumericUpDown txtScorta;
        private System.Windows.Forms.Button btmInserisciArticolo;
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sltCodForn;
        private System.Windows.Forms.Button btmInserisciCliente;
        private System.Windows.Forms.ComboBox sltCittà;
        private System.Windows.Forms.TextBox txtCognCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.Button btnInserisciVendta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.NumericUpDown txtQuantità;
        private System.Windows.Forms.ComboBox sltCodArt;
        private System.Windows.Forms.ComboBox sltCodCli;
        private System.Windows.Forms.Button btmCercaArticoloCodice;
        private System.Windows.Forms.Button btmModArt;
        private System.Windows.Forms.Button btmModCli;
        private System.Windows.Forms.Button btmCercaClienteCodice;
        private System.Windows.Forms.Button btmTotaleVenduto;
        private System.Windows.Forms.Button btmContaVenditiPerArticolo;
        private System.Windows.Forms.Button btmTotaleAcquistiCliente;
        private System.Windows.Forms.Button btmCalcolaAcquistiPerCliente;
        private System.Windows.Forms.Button btmCercaMaxFornitore;
        private System.Windows.Forms.Button btmCercaArtInvenduti;
        private System.Windows.Forms.Button btmCercaVenditeData;
        private System.Windows.Forms.Button btmArtVendutiTraDueDate;
        private System.Windows.Forms.Button btmGiornoPiuVendite;
        private System.Windows.Forms.Button btmDataMaxIncassi;
        private System.Windows.Forms.Button btmCercaClientiArticolo;
        private System.Windows.Forms.Button btmCercaClientinonArticolo;
    }
}

