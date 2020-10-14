namespace _04_Preparazione
{
    partial class FormUscita
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
            this.label1 = new System.Windows.Forms.Label();
            this.btmEsci = new System.Windows.Forms.Button();
            this.btmCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi davvero uscire?";
            // 
            // btmEsci
            // 
            this.btmEsci.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btmEsci.Location = new System.Drawing.Point(12, 39);
            this.btmEsci.Name = "btmEsci";
            this.btmEsci.Size = new System.Drawing.Size(75, 23);
            this.btmEsci.TabIndex = 1;
            this.btmEsci.Text = "Sì";
            this.btmEsci.UseVisualStyleBackColor = true;
            // 
            // btmCanc
            // 
            this.btmCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btmCanc.Location = new System.Drawing.Point(144, 39);
            this.btmCanc.Name = "btmCanc";
            this.btmCanc.Size = new System.Drawing.Size(75, 23);
            this.btmCanc.TabIndex = 2;
            this.btmCanc.Text = "No";
            this.btmCanc.UseVisualStyleBackColor = true;
            // 
            // FormUscita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 84);
            this.Controls.Add(this.btmCanc);
            this.Controls.Add(this.btmEsci);
            this.Controls.Add(this.label1);
            this.Name = "FormUscita";
            this.Text = "FormUscita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmEsci;
        private System.Windows.Forms.Button btmCanc;
    }
}