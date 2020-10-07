namespace _03_MultiformMid
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btmSend = new System.Windows.Forms.Button();
            this.btmformFiglia = new System.Windows.Forms.Button();
            this.btmMostraN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a form1:";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(63, 40);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(100, 20);
            this.txtSend.TabIndex = 2;
            // 
            // btmSend
            // 
            this.btmSend.Location = new System.Drawing.Point(175, 37);
            this.btmSend.Name = "btmSend";
            this.btmSend.Size = new System.Drawing.Size(75, 23);
            this.btmSend.TabIndex = 4;
            this.btmSend.Text = "Manda";
            this.btmSend.UseVisualStyleBackColor = true;
            this.btmSend.Click += new System.EventHandler(this.btmSend_Click);
            // 
            // btmformFiglia
            // 
            this.btmformFiglia.Location = new System.Drawing.Point(3, 86);
            this.btmformFiglia.Name = "btmformFiglia";
            this.btmformFiglia.Size = new System.Drawing.Size(130, 23);
            this.btmformFiglia.TabIndex = 5;
            this.btmformFiglia.Text = "Apri form figlia";
            this.btmformFiglia.UseVisualStyleBackColor = true;
            this.btmformFiglia.Click += new System.EventHandler(this.btmformFiglia_Click);
            // 
            // btmMostraN
            // 
            this.btmMostraN.Location = new System.Drawing.Point(15, 11);
            this.btmMostraN.Name = "btmMostraN";
            this.btmMostraN.Size = new System.Drawing.Size(75, 23);
            this.btmMostraN.TabIndex = 6;
            this.btmMostraN.Text = "Mostra N";
            this.btmMostraN.UseVisualStyleBackColor = true;
            this.btmMostraN.Click += new System.EventHandler(this.btmMostraN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 124);
            this.Controls.Add(this.btmMostraN);
            this.Controls.Add(this.btmformFiglia);
            this.Controls.Add(this.btmSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSend);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btmSend;
        private System.Windows.Forms.Button btmformFiglia;
        private System.Windows.Forms.Button btmMostraN;
    }
}