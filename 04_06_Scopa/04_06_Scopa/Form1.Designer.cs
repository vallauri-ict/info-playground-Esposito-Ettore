
namespace _04_06_Scopa
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
            this.dgvMano1 = new System.Windows.Forms.DataGridView();
            this.dgvPrese1 = new System.Windows.Forms.DataGridView();
            this.dgvPrese2 = new System.Windows.Forms.DataGridView();
            this.dgvMano2 = new System.Windows.Forms.DataGridView();
            this.dgvCampo = new System.Windows.Forms.DataGridView();
            this.dgvMazzo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.btmPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMano1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrese1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrese2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMano2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMano1
            // 
            this.dgvMano1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMano1.Location = new System.Drawing.Point(12, 361);
            this.dgvMano1.Name = "dgvMano1";
            this.dgvMano1.Size = new System.Drawing.Size(216, 238);
            this.dgvMano1.TabIndex = 0;
            this.dgvMano1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Giocata);
            // 
            // dgvPrese1
            // 
            this.dgvPrese1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrese1.Location = new System.Drawing.Point(234, 361);
            this.dgvPrese1.Name = "dgvPrese1";
            this.dgvPrese1.Size = new System.Drawing.Size(216, 238);
            this.dgvPrese1.TabIndex = 1;
            // 
            // dgvPrese2
            // 
            this.dgvPrese2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrese2.Location = new System.Drawing.Point(1251, 361);
            this.dgvPrese2.Name = "dgvPrese2";
            this.dgvPrese2.Size = new System.Drawing.Size(216, 238);
            this.dgvPrese2.TabIndex = 2;
            // 
            // dgvMano2
            // 
            this.dgvMano2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMano2.Location = new System.Drawing.Point(1029, 361);
            this.dgvMano2.Name = "dgvMano2";
            this.dgvMano2.Size = new System.Drawing.Size(216, 238);
            this.dgvMano2.TabIndex = 3;
            this.dgvMano2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Giocata);
            // 
            // dgvCampo
            // 
            this.dgvCampo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampo.Location = new System.Drawing.Point(760, 25);
            this.dgvCampo.Name = "dgvCampo";
            this.dgvCampo.Size = new System.Drawing.Size(216, 238);
            this.dgvCampo.TabIndex = 4;
            this.dgvCampo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampo_CellClick);
            // 
            // dgvMazzo
            // 
            this.dgvMazzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMazzo.Location = new System.Drawing.Point(511, 29);
            this.dgvMazzo.Name = "dgvMazzo";
            this.dgvMazzo.Size = new System.Drawing.Size(216, 238);
            this.dgvMazzo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mazzo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Campo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(12, 307);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(62, 13);
            this.lblP1.TabIndex = 8;
            this.lblP1.Text = "Giocatore 1";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mano";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prese";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1026, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mano";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1248, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prese";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(1026, 307);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(62, 13);
            this.lblP2.TabIndex = 13;
            this.lblP2.Text = "Giocatore 2";
            this.lblP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btmPlay
            // 
            this.btmPlay.Location = new System.Drawing.Point(704, 455);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(93, 23);
            this.btmPlay.TabIndex = 14;
            this.btmPlay.Text = "Inizia partita";
            this.btmPlay.UseVisualStyleBackColor = true;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 611);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMazzo);
            this.Controls.Add(this.dgvCampo);
            this.Controls.Add(this.dgvMano2);
            this.Controls.Add(this.dgvPrese2);
            this.Controls.Add(this.dgvPrese1);
            this.Controls.Add(this.dgvMano1);
            this.Name = "Form1";
            this.Text = "Scopa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMano1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrese1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrese2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMano2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMano1;
        private System.Windows.Forms.DataGridView dgvPrese1;
        private System.Windows.Forms.DataGridView dgvPrese2;
        private System.Windows.Forms.DataGridView dgvMano2;
        private System.Windows.Forms.DataGridView dgvCampo;
        private System.Windows.Forms.DataGridView dgvMazzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Button btmPlay;
    }
}

