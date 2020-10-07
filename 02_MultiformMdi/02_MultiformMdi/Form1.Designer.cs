namespace _02_MultiformMdi
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
            this.btmApriF1 = new System.Windows.Forms.Button();
            this.btmApriF2 = new System.Windows.Forms.Button();
            this.btmFinestreAperte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst = new System.Windows.Forms.StatusStrip();
            this.mstlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.mst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmApriF1
            // 
            this.btmApriF1.Location = new System.Drawing.Point(13, 27);
            this.btmApriF1.Name = "btmApriF1";
            this.btmApriF1.Size = new System.Drawing.Size(75, 23);
            this.btmApriF1.TabIndex = 1;
            this.btmApriF1.Text = "Apri f1";
            this.btmApriF1.UseVisualStyleBackColor = true;
            this.btmApriF1.Click += new System.EventHandler(this.btmApriF1_Click);
            // 
            // btmApriF2
            // 
            this.btmApriF2.Location = new System.Drawing.Point(94, 27);
            this.btmApriF2.Name = "btmApriF2";
            this.btmApriF2.Size = new System.Drawing.Size(75, 23);
            this.btmApriF2.TabIndex = 2;
            this.btmApriF2.Text = "Apri f2";
            this.btmApriF2.UseVisualStyleBackColor = true;
            this.btmApriF2.Click += new System.EventHandler(this.btmApriF2_Click);
            // 
            // btmFinestreAperte
            // 
            this.btmFinestreAperte.Location = new System.Drawing.Point(175, 27);
            this.btmFinestreAperte.Name = "btmFinestreAperte";
            this.btmFinestreAperte.Size = new System.Drawing.Size(92, 23);
            this.btmFinestreAperte.TabIndex = 3;
            this.btmFinestreAperte.Text = "Finestre aperte";
            this.btmFinestreAperte.UseVisualStyleBackColor = true;
            this.btmFinestreAperte.Click += new System.EventHandler(this.btmFinestreAperte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apri1ToolStripMenuItem,
            this.apri2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // apri1ToolStripMenuItem
            // 
            this.apri1ToolStripMenuItem.Name = "apri1ToolStripMenuItem";
            this.apri1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri1ToolStripMenuItem.Text = "Apri&1";
            this.apri1ToolStripMenuItem.Click += new System.EventHandler(this.apri1ToolStripMenuItem_Click);
            // 
            // apri2ToolStripMenuItem
            // 
            this.apri2ToolStripMenuItem.Name = "apri2ToolStripMenuItem";
            this.apri2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri2ToolStripMenuItem.Text = "Apri&2";
            this.apri2ToolStripMenuItem.Click += new System.EventHandler(this.apri2ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "In&fo";
            // 
            // mst
            // 
            this.mst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstlbl});
            this.mst.Location = new System.Drawing.Point(0, 428);
            this.mst.Name = "mst";
            this.mst.Size = new System.Drawing.Size(800, 22);
            this.mst.TabIndex = 5;
            this.mst.Text = "statusStrip1";
            // 
            // mstlbl
            // 
            this.mstlbl.Name = "mstlbl";
            this.mstlbl.Size = new System.Drawing.Size(65, 17);
            this.mstlbl.Text = "Ciao a tutti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mst);
            this.Controls.Add(this.btmFinestreAperte);
            this.Controls.Add(this.btmApriF2);
            this.Controls.Add(this.btmApriF1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mst.ResumeLayout(false);
            this.mst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmApriF1;
        private System.Windows.Forms.Button btmApriF2;
        private System.Windows.Forms.Button btmFinestreAperte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mst;
        private System.Windows.Forms.ToolStripStatusLabel mstlbl;
    }
}

