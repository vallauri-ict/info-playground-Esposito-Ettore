namespace _04_Preparazione
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlStato = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEtaOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btmInvia = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondariaToolStripMenuItem,
            this.figliaToolStripMenuItem,
            this.mDIToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // secondariaToolStripMenuItem
            // 
            this.secondariaToolStripMenuItem.Name = "secondariaToolStripMenuItem";
            this.secondariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondariaToolStripMenuItem.Text = "Secondaria";
            this.secondariaToolStripMenuItem.Click += new System.EventHandler(this.secondariaToolStripMenuItem_Click);
            // 
            // figliaToolStripMenuItem
            // 
            this.figliaToolStripMenuItem.Name = "figliaToolStripMenuItem";
            this.figliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figliaToolStripMenuItem.Text = "Figlia";
            this.figliaToolStripMenuItem.Click += new System.EventHandler(this.figliaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlStato});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlStato
            // 
            this.stlStato.Name = "stlStato";
            this.stlStato.Size = new System.Drawing.Size(35, 17);
            this.stlStato.Text = "Nulla";
            // 
            // txtEtaOut
            // 
            this.txtEtaOut.Location = new System.Drawing.Point(59, 393);
            this.txtEtaOut.Name = "txtEtaOut";
            this.txtEtaOut.ReadOnly = true;
            this.txtEtaOut.Size = new System.Drawing.Size(100, 20);
            this.txtEtaOut.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Età: ";
            // 
            // txtNomeOut
            // 
            this.txtNomeOut.Location = new System.Drawing.Point(59, 370);
            this.txtNomeOut.Name = "txtNomeOut";
            this.txtNomeOut.ReadOnly = true;
            this.txtNomeOut.Size = new System.Drawing.Size(100, 20);
            this.txtNomeOut.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome: ";
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mDIToolStripMenuItem.Text = "MDI";
            this.mDIToolStripMenuItem.Click += new System.EventHandler(this.mDIToolStripMenuItem_Click);
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(248, 370);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Campo: ";
            // 
            // btmInvia
            // 
            this.btmInvia.Location = new System.Drawing.Point(204, 393);
            this.btmInvia.Name = "btmInvia";
            this.btmInvia.Size = new System.Drawing.Size(75, 23);
            this.btmInvia.TabIndex = 12;
            this.btmInvia.Text = "Invia";
            this.btmInvia.UseVisualStyleBackColor = true;
            this.btmInvia.Click += new System.EventHandler(this.btmInvia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmInvia);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEtaOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlStato;
        private System.Windows.Forms.TextBox txtEtaOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmInvia;
    }
}

