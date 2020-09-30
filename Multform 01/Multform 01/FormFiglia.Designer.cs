namespace Multform_01
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
            this.owner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // owner
            // 
            this.owner.Location = new System.Drawing.Point(12, 12);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(75, 23);
            this.owner.TabIndex = 0;
            this.owner.Text = "Vedi madre";
            this.owner.UseVisualStyleBackColor = true;
            this.owner.Click += new System.EventHandler(this.owner_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 215);
            this.Controls.Add(this.owner);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button owner;
    }
}