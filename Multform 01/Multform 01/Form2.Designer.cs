namespace Multform_01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Leggi = new System.Windows.Forms.Button();
            this.Inviato = new System.Windows.Forms.TextBox();
            this.Invia = new System.Windows.Forms.Button();
            this.FormFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Leggi
            // 
            this.Leggi.Location = new System.Drawing.Point(13, 13);
            this.Leggi.Name = "Leggi";
            this.Leggi.Size = new System.Drawing.Size(75, 23);
            this.Leggi.TabIndex = 0;
            this.Leggi.Text = "Leggi valore";
            this.Leggi.UseVisualStyleBackColor = true;
            this.Leggi.Click += new System.EventHandler(this.Leggi_Click);
            // 
            // Inviato
            // 
            this.Inviato.Location = new System.Drawing.Point(13, 43);
            this.Inviato.Name = "Inviato";
            this.Inviato.Size = new System.Drawing.Size(100, 20);
            this.Inviato.TabIndex = 1;
            // 
            // Invia
            // 
            this.Invia.Location = new System.Drawing.Point(119, 40);
            this.Invia.Name = "Invia";
            this.Invia.Size = new System.Drawing.Size(75, 23);
            this.Invia.TabIndex = 2;
            this.Invia.Text = "Invia";
            this.Invia.UseVisualStyleBackColor = true;
            this.Invia.Click += new System.EventHandler(this.Invia_Click);
            // 
            // FormFiglia
            // 
            this.FormFiglia.Location = new System.Drawing.Point(12, 69);
            this.FormFiglia.Name = "FormFiglia";
            this.FormFiglia.Size = new System.Drawing.Size(101, 23);
            this.FormFiglia.TabIndex = 3;
            this.FormFiglia.Text = "Apri form figlia";
            this.FormFiglia.UseVisualStyleBackColor = true;
            this.FormFiglia.Click += new System.EventHandler(this.FormFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 282);
            this.Controls.Add(this.FormFiglia);
            this.Controls.Add(this.Invia);
            this.Controls.Add(this.Inviato);
            this.Controls.Add(this.Leggi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Leggi;
        private System.Windows.Forms.TextBox Inviato;
        private System.Windows.Forms.Button Invia;
        private System.Windows.Forms.Button FormFiglia;
    }
}