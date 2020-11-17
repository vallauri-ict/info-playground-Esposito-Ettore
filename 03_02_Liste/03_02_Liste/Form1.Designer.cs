namespace _03_02_Liste
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btmAggiungi = new System.Windows.Forms.Button();
            this.btmVisualizza = new System.Windows.Forms.Button();
            this.VisualizzaObj = new System.Windows.Forms.Button();
            this.btmAggiungiObj = new System.Windows.Forms.Button();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmFindAll = new System.Windows.Forms.Button();
            this.btmFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo: ";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(63, 13);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(63, 39);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(63, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // btmAggiungi
            // 
            this.btmAggiungi.Location = new System.Drawing.Point(16, 92);
            this.btmAggiungi.Name = "btmAggiungi";
            this.btmAggiungi.Size = new System.Drawing.Size(147, 23);
            this.btmAggiungi.TabIndex = 6;
            this.btmAggiungi.Text = "Aggiungi";
            this.btmAggiungi.UseVisualStyleBackColor = true;
            this.btmAggiungi.Click += new System.EventHandler(this.btmAggiungi_Click);
            // 
            // btmVisualizza
            // 
            this.btmVisualizza.Location = new System.Drawing.Point(16, 121);
            this.btmVisualizza.Name = "btmVisualizza";
            this.btmVisualizza.Size = new System.Drawing.Size(147, 23);
            this.btmVisualizza.TabIndex = 7;
            this.btmVisualizza.Text = "Visualizza";
            this.btmVisualizza.UseVisualStyleBackColor = true;
            this.btmVisualizza.Click += new System.EventHandler(this.btmVisualizza_Click);
            // 
            // VisualizzaObj
            // 
            this.VisualizzaObj.Location = new System.Drawing.Point(16, 179);
            this.VisualizzaObj.Name = "VisualizzaObj";
            this.VisualizzaObj.Size = new System.Drawing.Size(147, 23);
            this.VisualizzaObj.TabIndex = 15;
            this.VisualizzaObj.Text = "Visualizza obj";
            this.VisualizzaObj.UseVisualStyleBackColor = true;
            this.VisualizzaObj.Click += new System.EventHandler(this.VisualizzaObj_Click);
            // 
            // btmAggiungiObj
            // 
            this.btmAggiungiObj.Location = new System.Drawing.Point(16, 150);
            this.btmAggiungiObj.Name = "btmAggiungiObj";
            this.btmAggiungiObj.Size = new System.Drawing.Size(147, 23);
            this.btmAggiungiObj.TabIndex = 14;
            this.btmAggiungiObj.Text = "Aggiungi obj";
            this.btmAggiungiObj.UseVisualStyleBackColor = true;
            this.btmAggiungiObj.Click += new System.EventHandler(this.btmAggiungiObj_Click);
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(63, 205);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(100, 20);
            this.txtRicerca.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ricerca: ";
            // 
            // btmFindAll
            // 
            this.btmFindAll.Location = new System.Drawing.Point(16, 260);
            this.btmFindAll.Name = "btmFindAll";
            this.btmFindAll.Size = new System.Drawing.Size(147, 23);
            this.btmFindAll.TabIndex = 19;
            this.btmFindAll.Text = "Find all";
            this.btmFindAll.UseVisualStyleBackColor = true;
            this.btmFindAll.Click += new System.EventHandler(this.btmFindAll_Click);
            // 
            // btmFind
            // 
            this.btmFind.Location = new System.Drawing.Point(16, 231);
            this.btmFind.Name = "btmFind";
            this.btmFind.Size = new System.Drawing.Size(147, 23);
            this.btmFind.TabIndex = 18;
            this.btmFind.Text = "Find";
            this.btmFind.UseVisualStyleBackColor = true;
            this.btmFind.Click += new System.EventHandler(this.btmFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 322);
            this.Controls.Add(this.btmFindAll);
            this.Controls.Add(this.btmFind);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VisualizzaObj);
            this.Controls.Add(this.btmAggiungiObj);
            this.Controls.Add(this.btmVisualizza);
            this.Controls.Add(this.btmAggiungi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Libri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmAggiungi;
        private System.Windows.Forms.Button btmVisualizza;
        private System.Windows.Forms.Button VisualizzaObj;
        private System.Windows.Forms.Button btmAggiungiObj;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmFindAll;
        private System.Windows.Forms.Button btmFind;
    }
}

