namespace bai05
{
    partial class Form1
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbKv = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbKv = new System.Windows.Forms.ComboBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(949, 192);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "id_area";
            this.Column3.HeaderText = "Khu vực";
            this.Column3.Name = "Column3";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(13, 225);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(27, 17);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(13, 260);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(33, 17);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên";
            // 
            // lbKv
            // 
            this.lbKv.AutoSize = true;
            this.lbKv.Location = new System.Drawing.Point(13, 291);
            this.lbKv.Name = "lbKv";
            this.lbKv.Size = new System.Drawing.Size(59, 17);
            this.lbKv.TabIndex = 1;
            this.lbKv.Text = "Khu vực";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(96, 225);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(153, 22);
            this.tbMa.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 260);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(290, 22);
            this.tbName.TabIndex = 2;
            // 
            // cbKv
            // 
            this.cbKv.FormattingEnabled = true;
            this.cbKv.Location = new System.Drawing.Point(96, 291);
            this.cbKv.Name = "cbKv";
            this.cbKv.Size = new System.Drawing.Size(295, 24);
            this.cbKv.TabIndex = 3;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(289, 372);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(102, 38);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(436, 372);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(102, 38);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(566, 372);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(102, 38);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(710, 372);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(102, 38);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(12, 372);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(108, 38);
            this.btRead.TabIndex = 5;
            this.btRead.Text = "Đọc";
            this.btRead.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 432);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.cbKv);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.lbKv);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbKv;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbKv;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

