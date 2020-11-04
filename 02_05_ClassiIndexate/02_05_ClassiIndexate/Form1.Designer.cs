namespace _02_05_ClassiIndexate
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
            this.btmCrea = new System.Windows.Forms.Button();
            this.btmVisualizza = new System.Windows.Forms.Button();
            this.txtLenght = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // btmCrea
            // 
            this.btmCrea.Location = new System.Drawing.Point(13, 39);
            this.btmCrea.Name = "btmCrea";
            this.btmCrea.Size = new System.Drawing.Size(100, 23);
            this.btmCrea.TabIndex = 0;
            this.btmCrea.Text = "Crea classe";
            this.btmCrea.UseVisualStyleBackColor = true;
            this.btmCrea.Click += new System.EventHandler(this.btmCrea_Click);
            // 
            // btmVisualizza
            // 
            this.btmVisualizza.Location = new System.Drawing.Point(12, 68);
            this.btmVisualizza.Name = "btmVisualizza";
            this.btmVisualizza.Size = new System.Drawing.Size(101, 23);
            this.btmVisualizza.TabIndex = 1;
            this.btmVisualizza.Text = "Visualizza";
            this.btmVisualizza.UseVisualStyleBackColor = true;
            this.btmVisualizza.Click += new System.EventHandler(this.btmVisualizza_Click);
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(13, 13);
            this.txtLenght.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txtLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(98, 20);
            this.txtLenght.TabIndex = 3;
            this.txtLenght.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 104);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.btmVisualizza);
            this.Controls.Add(this.btmCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtLenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmCrea;
        private System.Windows.Forms.Button btmVisualizza;
        private System.Windows.Forms.NumericUpDown txtLenght;
    }
}

