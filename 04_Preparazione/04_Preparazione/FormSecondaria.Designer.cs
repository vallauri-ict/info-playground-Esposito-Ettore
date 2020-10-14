namespace _04_Preparazione
{
    partial class FormSecondaria
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
            this.btmCanc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmOk
            // 
            this.btmOk.Location = new System.Drawing.Point(12, 60);
            this.btmOk.Name = "btmOk";
            this.btmOk.Size = new System.Drawing.Size(75, 23);
            this.btmOk.TabIndex = 0;
            this.btmOk.Text = "Invia";
            this.btmOk.UseVisualStyleBackColor = true;
            this.btmOk.Click += new System.EventHandler(this.btmOk_Click);
            // 
            // btmCanc
            // 
            this.btmCanc.Location = new System.Drawing.Point(93, 60);
            this.btmCanc.Name = "btmCanc";
            this.btmCanc.Size = new System.Drawing.Size(75, 23);
            this.btmCanc.TabIndex = 1;
            this.btmCanc.Text = "Annulla";
            this.btmCanc.UseVisualStyleBackColor = true;
            this.btmCanc.Click += new System.EventHandler(this.btmCanc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(59, 29);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Età: ";
            // 
            // FormSecondaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 99);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCanc);
            this.Controls.Add(this.btmOk);
            this.Name = "FormSecondaria";
            this.Text = "FormSecondaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmOk;
        private System.Windows.Forms.Button btmCanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
    }
}