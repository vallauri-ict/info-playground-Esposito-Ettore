namespace _03_MultiformMid
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
            this.btmMostraFormPadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmMostraFormPadre
            // 
            this.btmMostraFormPadre.Location = new System.Drawing.Point(12, 12);
            this.btmMostraFormPadre.Name = "btmMostraFormPadre";
            this.btmMostraFormPadre.Size = new System.Drawing.Size(117, 23);
            this.btmMostraFormPadre.TabIndex = 0;
            this.btmMostraFormPadre.Text = "Mostra form padre";
            this.btmMostraFormPadre.UseVisualStyleBackColor = true;
            this.btmMostraFormPadre.Click += new System.EventHandler(this.btmMostraFormPadre_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 143);
            this.Controls.Add(this.btmMostraFormPadre);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmMostraFormPadre;
    }
}