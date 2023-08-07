namespace QLBHST.GUII
{
    partial class quenmk
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qtk = new System.Windows.Forms.TextBox();
            this.qnlmk = new System.Windows.Forms.TextBox();
            this.qemail = new System.Windows.Forms.TextBox();
            this.qmk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email đã đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quên mật khẩu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quên mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_qmk);
            // 
            // qtk
            // 
            this.qtk.Location = new System.Drawing.Point(162, 184);
            this.qtk.Name = "qtk";
            this.qtk.Size = new System.Drawing.Size(180, 22);
            this.qtk.TabIndex = 7;
            // 
            // qnlmk
            // 
            this.qnlmk.Location = new System.Drawing.Point(162, 310);
            this.qnlmk.Name = "qnlmk";
            this.qnlmk.Size = new System.Drawing.Size(180, 22);
            this.qnlmk.TabIndex = 8;
            // 
            // qemail
            // 
            this.qemail.Location = new System.Drawing.Point(162, 222);
            this.qemail.Name = "qemail";
            this.qemail.Size = new System.Drawing.Size(180, 22);
            this.qemail.TabIndex = 9;
            // 
            // qmk
            // 
            this.qmk.Location = new System.Drawing.Point(162, 265);
            this.qmk.Name = "qmk";
            this.qmk.Size = new System.Drawing.Size(180, 22);
            this.qmk.TabIndex = 10;
            // 
            // quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 453);
            this.Controls.Add(this.qmk);
            this.Controls.Add(this.qemail);
            this.Controls.Add(this.qnlmk);
            this.Controls.Add(this.qtk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "quenmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quenmk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qtk;
        private System.Windows.Forms.TextBox qnlmk;
        private System.Windows.Forms.TextBox qemail;
        private System.Windows.Forms.TextBox qmk;
    }
}