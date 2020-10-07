namespace _03_MultiformMid
{
    partial class FormModale
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.btmOk = new System.Windows.Forms.Button();
            this.btmCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Età:";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(67, 42);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 6;
            // 
            // btmOk
            // 
            this.btmOk.Location = new System.Drawing.Point(12, 68);
            this.btmOk.Name = "btmOk";
            this.btmOk.Size = new System.Drawing.Size(75, 23);
            this.btmOk.TabIndex = 10;
            this.btmOk.Text = "Ok";
            this.btmOk.UseVisualStyleBackColor = true;
            // 
            // btmCanc
            // 
            this.btmCanc.Location = new System.Drawing.Point(93, 68);
            this.btmCanc.Name = "btmCanc";
            this.btmCanc.Size = new System.Drawing.Size(75, 23);
            this.btmCanc.TabIndex = 11;
            this.btmCanc.Text = "!Ok";
            this.btmCanc.UseVisualStyleBackColor = true;
            // 
            // FormModale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 116);
            this.Controls.Add(this.btmCanc);
            this.Controls.Add(this.btmOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEta);
            this.Name = "FormModale";
            this.Text = "FormModale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Button btmOk;
        private System.Windows.Forms.Button btmCanc;
    }
}