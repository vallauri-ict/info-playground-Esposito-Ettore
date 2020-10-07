namespace Multform_01
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
            this.btmOk = new System.Windows.Forms.Button();
            this.btmAnnulla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmOk
            // 
            this.btmOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btmOk.Location = new System.Drawing.Point(12, 96);
            this.btmOk.Name = "btmOk";
            this.btmOk.Size = new System.Drawing.Size(75, 23);
            this.btmOk.TabIndex = 0;
            this.btmOk.Text = "Ok";
            this.btmOk.UseVisualStyleBackColor = true;
            this.btmOk.Click += new System.EventHandler(this.btmOk_Click);
            // 
            // btmAnnulla
            // 
            this.btmAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btmAnnulla.Location = new System.Drawing.Point(93, 96);
            this.btmAnnulla.Name = "btmAnnulla";
            this.btmAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btmAnnulla.TabIndex = 1;
            this.btmAnnulla.Text = "!Ok";
            this.btmAnnulla.UseVisualStyleBackColor = true;
            this.btmAnnulla.Click += new System.EventHandler(this.btmAnnulla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(12, 70);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Età:";
            // 
            // FormModale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 130);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmAnnulla);
            this.Controls.Add(this.btmOk);
            this.Name = "FormModale";
            this.Text = "FormModale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmOk;
        private System.Windows.Forms.Button btmAnnulla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
    }
}