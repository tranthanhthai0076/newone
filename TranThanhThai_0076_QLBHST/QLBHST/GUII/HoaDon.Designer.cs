namespace QLBHST.GUII
{
    partial class HoaDon
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
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtkh = new System.Windows.Forms.TextBox();
            this.tbtnv = new System.Windows.Forms.TextBox();
            this.tbnm = new System.Windows.Forms.TextBox();
            this.tbhd = new System.Windows.Forms.TextBox();
            this.tbtt = new System.Windows.Forms.TextBox();
            this.cbbmakh = new System.Windows.Forms.ComboBox();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbsdtkh = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbtsp = new System.Windows.Forms.TextBox();
            this.tbgsp = new System.Windows.Forms.TextBox();
            this.tbsl = new System.Windows.Forms.TextBox();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Edithd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbtongtien = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhd
            // 
            this.dgvhd.AllowUserToAddRows = false;
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvhd.Location = new System.Drawing.Point(2, 1);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersWidth = 51;
            this.dgvhd.RowTemplate.Height = 24;
            this.dgvhd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhd.Size = new System.Drawing.Size(848, 150);
            this.dgvhd.TabIndex = 0;
            this.dgvhd.SelectionChanged += new System.EventHandler(this.dgvslectchange);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày mua";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // dgvsp
            // 
            this.dgvsp.AllowUserToAddRows = false;
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column7,
            this.a,
            this.d,
            this.Column9,
            this.Column10,
            this.Column6});
            this.dgvsp.Location = new System.Drawing.Point(2, 577);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(1004, 150);
            this.dgvsp.TabIndex = 1;
            this.dgvsp.SelectionChanged += new System.EventHandler(this.dgvsp_SelectionChanged);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã hóa đơn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // a
            // 
            this.a.HeaderText = "Mã sản phẩm";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 125;
            // 
            // d
            // 
            this.d.HeaderText = "Tên sản phẩm";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Đơn giá";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Mua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 841);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng Tiền";
            // 
            // tbtkh
            // 
            this.tbtkh.Enabled = false;
            this.tbtkh.Location = new System.Drawing.Point(122, 247);
            this.tbtkh.Name = "tbtkh";
            this.tbtkh.Size = new System.Drawing.Size(200, 22);
            this.tbtkh.TabIndex = 10;
            // 
            // tbtnv
            // 
            this.tbtnv.Enabled = false;
            this.tbtnv.Location = new System.Drawing.Point(492, 213);
            this.tbtnv.Name = "tbtnv";
            this.tbtnv.Size = new System.Drawing.Size(200, 22);
            this.tbtnv.TabIndex = 12;
            // 
            // tbnm
            // 
            this.tbnm.Enabled = false;
            this.tbnm.Location = new System.Drawing.Point(492, 256);
            this.tbnm.Name = "tbnm";
            this.tbnm.Size = new System.Drawing.Size(200, 22);
            this.tbnm.TabIndex = 13;
            // 
            // tbhd
            // 
            this.tbhd.Enabled = false;
            this.tbhd.Location = new System.Drawing.Point(122, 175);
            this.tbhd.Name = "tbhd";
            this.tbhd.Size = new System.Drawing.Size(200, 22);
            this.tbhd.TabIndex = 14;
            this.tbhd.TextChanged += new System.EventHandler(this.tbhd_TextChanged);
            // 
            // tbtt
            // 
            this.tbtt.Enabled = false;
            this.tbtt.Location = new System.Drawing.Point(492, 838);
            this.tbtt.Name = "tbtt";
            this.tbtt.Size = new System.Drawing.Size(200, 22);
            this.tbtt.TabIndex = 15;
            this.tbtt.TextChanged += new System.EventHandler(this.tbtt_TextChanged);
            // 
            // cbbmakh
            // 
            this.cbbmakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmakh.FormattingEnabled = true;
            this.cbbmakh.Location = new System.Drawing.Point(122, 211);
            this.cbbmakh.Name = "cbbmakh";
            this.cbbmakh.Size = new System.Drawing.Size(200, 24);
            this.cbbmakh.TabIndex = 16;
            this.cbbmakh.SelectedIndexChanged += new System.EventHandler(this.cbbmakh_SelectedIndexChanged);
            // 
            // cbbmanv
            // 
            this.cbbmanv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(492, 173);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(200, 24);
            this.cbbmanv.TabIndex = 17;
            this.cbbmanv.SelectedIndexChanged += new System.EventHandler(this.cbbmanv_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số DT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 759);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 793);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 830);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tên SP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 802);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số lượng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 862);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Đơn giá";
            // 
            // tbsdtkh
            // 
            this.tbsdtkh.Enabled = false;
            this.tbsdtkh.Location = new System.Drawing.Point(122, 289);
            this.tbsdtkh.Name = "tbsdtkh";
            this.tbsdtkh.Size = new System.Drawing.Size(200, 22);
            this.tbsdtkh.TabIndex = 24;
            // 
            // tbid
            // 
            this.tbid.Enabled = false;
            this.tbid.Location = new System.Drawing.Point(122, 753);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(200, 22);
            this.tbid.TabIndex = 25;
            // 
            // tbtsp
            // 
            this.tbtsp.Enabled = false;
            this.tbtsp.Location = new System.Drawing.Point(122, 815);
            this.tbtsp.Name = "tbtsp";
            this.tbtsp.Size = new System.Drawing.Size(200, 22);
            this.tbtsp.TabIndex = 26;
            // 
            // tbgsp
            // 
            this.tbgsp.Enabled = false;
            this.tbgsp.Location = new System.Drawing.Point(122, 859);
            this.tbgsp.Name = "tbgsp";
            this.tbgsp.Size = new System.Drawing.Size(200, 22);
            this.tbgsp.TabIndex = 27;
            this.tbgsp.TextChanged += new System.EventHandler(this.tdg);
            // 
            // tbsl
            // 
            this.tbsl.Location = new System.Drawing.Point(492, 796);
            this.tbsl.Name = "tbsl";
            this.tbsl.Size = new System.Drawing.Size(200, 22);
            this.tbsl.TabIndex = 28;
            this.tbsl.TextChanged += new System.EventHandler(this.ttt);
            // 
            // cbbmasp
            // 
            this.cbbmasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(122, 785);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(200, 24);
            this.cbbmasp.TabIndex = 29;
            this.cbbmasp.SelectedIndexChanged += new System.EventHandler(this.cbbmasp_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Thêm HĐ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edithd
            // 
            this.Edithd.Location = new System.Drawing.Point(482, 390);
            this.Edithd.Name = "Edithd";
            this.Edithd.Size = new System.Drawing.Size(75, 23);
            this.Edithd.TabIndex = 31;
            this.Edithd.Text = "Sửa HĐ";
            this.Edithd.UseVisualStyleBackColor = true;
            this.Edithd.Click += new System.EventHandler(this.Edithd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 886);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Thêm Sp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(521, 886);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Sửa sản phẩm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(626, 886);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Xóa sản phẩm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(410, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Thành tiền";
            // 
            // tbtongtien
            // 
            this.tbtongtien.Enabled = false;
            this.tbtongtien.Location = new System.Drawing.Point(492, 295);
            this.tbtongtien.Name = "tbtongtien";
            this.tbtongtien.Size = new System.Drawing.Size(200, 22);
            this.tbtongtien.TabIndex = 37;
            this.tbtongtien.TextChanged += new System.EventHandler(this.tbtongtien_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(317, 886);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 38;
            this.clear.Text = "Clear dữ liệu ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // tbtk
            // 
            this.tbtk.Enabled = false;
            this.tbtk.Location = new System.Drawing.Point(492, 759);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(200, 22);
            this.tbtk.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(419, 759);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Tồn kho";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 939);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tbtongtien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Edithd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbmasp);
            this.Controls.Add(this.tbsl);
            this.Controls.Add(this.tbgsp);
            this.Controls.Add(this.tbtsp);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbsdtkh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.cbbmakh);
            this.Controls.Add(this.tbtt);
            this.Controls.Add(this.tbhd);
            this.Controls.Add(this.tbnm);
            this.Controls.Add(this.tbtnv);
            this.Controls.Add(this.tbtkh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.dgvhd);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbtkh;
        private System.Windows.Forms.TextBox tbtnv;
        private System.Windows.Forms.TextBox tbnm;
        private System.Windows.Forms.TextBox tbhd;
        private System.Windows.Forms.TextBox tbtt;
        private System.Windows.Forms.ComboBox cbbmakh;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbsdtkh;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbtsp;
        private System.Windows.Forms.TextBox tbgsp;
        private System.Windows.Forms.TextBox tbsl;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Edithd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbtongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Label label15;
    }
}