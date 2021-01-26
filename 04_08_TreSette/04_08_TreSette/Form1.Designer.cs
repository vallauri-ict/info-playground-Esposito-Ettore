
namespace _04_08_TreSette
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
            this.dgvP1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGiocate = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMazzo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvP2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvP1
            // 
            this.dgvP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP1.Location = new System.Drawing.Point(12, 29);
            this.dgvP1.Name = "dgvP1";
            this.dgvP1.Size = new System.Drawing.Size(190, 367);
            this.dgvP1.TabIndex = 0;
            this.dgvP1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiocaCarta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giocatore 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giocate";
            // 
            // dgvGiocate
            // 
            this.dgvGiocate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiocate.Location = new System.Drawing.Point(273, 29);
            this.dgvGiocate.Name = "dgvGiocate";
            this.dgvGiocate.Size = new System.Drawing.Size(190, 367);
            this.dgvGiocate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mazzo";
            // 
            // dgvMazzo
            // 
            this.dgvMazzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMazzo.Location = new System.Drawing.Point(534, 29);
            this.dgvMazzo.Name = "dgvMazzo";
            this.dgvMazzo.Size = new System.Drawing.Size(190, 367);
            this.dgvMazzo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giocatore 2";
            // 
            // dgvP2
            // 
            this.dgvP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP2.Location = new System.Drawing.Point(779, 29);
            this.dgvP2.Name = "dgvP2";
            this.dgvP2.Size = new System.Drawing.Size(190, 367);
            this.dgvP2.TabIndex = 6;
            this.dgvP2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiocaCarta);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMazzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGiocate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvP1);
            this.Name = "Form1";
            this.Text = "TreSette";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGiocate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMazzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvP2;
    }
}

