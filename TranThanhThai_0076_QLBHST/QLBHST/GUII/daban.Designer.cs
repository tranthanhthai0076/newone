namespace QLBHST.GUII
{
    partial class daban
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
            this.spdaban = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DateTimePicker();
            this.ngaykt = new System.Windows.Forms.DateTimePicker();
            this.tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spdaban)).BeginInit();
            this.SuspendLayout();
            // 
            // spdaban
            // 
            this.spdaban.ColumnHeadersHeight = 29;
            this.spdaban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column5});
            this.spdaban.Location = new System.Drawing.Point(1, 150);
            this.spdaban.Name = "spdaban";
            this.spdaban.RowHeadersWidth = 80;
            this.spdaban.Size = new System.Drawing.Size(858, 181);
            this.spdaban.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng đã bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Giá bán";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // ngaybd
            // 
            this.ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybd.Location = new System.Drawing.Point(139, 64);
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.Size = new System.Drawing.Size(140, 22);
            this.ngaybd.TabIndex = 1;
            // 
            // ngaykt
            // 
            this.ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaykt.Location = new System.Drawing.Point(386, 64);
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.Size = new System.Drawing.Size(140, 22);
            this.ngaykt.TabIndex = 2;
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(553, 63);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(75, 23);
            this.tim.TabIndex = 3;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến ngày";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(580, 362);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(100, 22);
            this.dt.TabIndex = 6;
            this.dt.TextChanged += new System.EventHandler(this.dt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doanh thu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 42;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // daban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.ngaykt);
            this.Controls.Add(this.ngaybd);
            this.Controls.Add(this.spdaban);
            this.Name = "daban";
            this.Text = "daban";
            this.Load += new System.EventHandler(this.daban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spdaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker ngaybd;
        private System.Windows.Forms.DateTimePicker ngaykt;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}