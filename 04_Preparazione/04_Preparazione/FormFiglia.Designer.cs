namespace _04_Preparazione
{
    partial class FormFiglia
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
            this.btmInvia = new System.Windows.Forms.Button();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmInvia
            // 
            this.btmInvia.Location = new System.Drawing.Point(15, 29);
            this.btmInvia.Name = "btmInvia";
            this.btmInvia.Size = new System.Drawing.Size(75, 23);
            this.btmInvia.TabIndex = 15;
            this.btmInvia.Text = "Invia";
            this.btmInvia.UseVisualStyleBackColor = true;
            this.btmInvia.Click += new System.EventHandler(this.btmInvia_Click);
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(59, 6);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(100, 20);
            this.txtCampo2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Campo: ";
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 76);
            this.Controls.Add(this.btmInvia);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.label3);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmInvia;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.Label label3;
    }
}