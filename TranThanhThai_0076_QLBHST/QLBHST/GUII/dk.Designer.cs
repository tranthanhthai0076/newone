namespace QLBHST.GUII
{
    partial class dk
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ttk = new System.Windows.Forms.TextBox();
            this.tmk = new System.Windows.Forms.TextBox();
            this.tnlmk = new System.Windows.Forms.TextBox();
            this.temail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDk);
            // 
            // ttk
            // 
            this.ttk.Location = new System.Drawing.Point(147, 130);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(125, 22);
            this.ttk.TabIndex = 5;
            // 
            // tmk
            // 
            this.tmk.Location = new System.Drawing.Point(147, 169);
            this.tmk.Name = "tmk";
            this.tmk.Size = new System.Drawing.Size(125, 22);
            this.tmk.TabIndex = 6;
            // 
            // tnlmk
            // 
            this.tnlmk.Location = new System.Drawing.Point(147, 204);
            this.tnlmk.Name = "tnlmk";
            this.tnlmk.Size = new System.Drawing.Size(125, 22);
            this.tnlmk.TabIndex = 7;
            // 
            // temail
            // 
            this.temail.Location = new System.Drawing.Point(147, 236);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(125, 22);
            this.temail.TabIndex = 8;
            // 
            // dk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 453);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.tnlmk);
            this.Controls.Add(this.tmk);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ttk;
        private System.Windows.Forms.TextBox tmk;
        private System.Windows.Forms.TextBox tnlmk;
        private System.Windows.Forms.TextBox temail;
    }
}