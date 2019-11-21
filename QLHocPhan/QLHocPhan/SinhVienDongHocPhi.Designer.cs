namespace QLHocPhan
{
    partial class ChinhSuaThongTinSinhVien
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_Search = new System.Windows.Forms.Button();
            this.DanhSachMonDataGridView = new System.Windows.Forms.DataGridView();
            this.txb_TongSoTien = new System.Windows.Forms.TextBox();
            this.btn_DongTien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnHuyMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bnt_Search
            // 
            this.bnt_Search.Location = new System.Drawing.Point(252, 14);
            this.bnt_Search.Name = "bnt_Search";
            this.bnt_Search.Size = new System.Drawing.Size(75, 23);
            this.bnt_Search.TabIndex = 3;
            this.bnt_Search.Text = "Tìm kiếm";
            this.bnt_Search.UseVisualStyleBackColor = true;
            // 
            // DanhSachMonDataGridView
            // 
            this.DanhSachMonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachMonDataGridView.Location = new System.Drawing.Point(12, 124);
            this.DanhSachMonDataGridView.Name = "DanhSachMonDataGridView";
            this.DanhSachMonDataGridView.Size = new System.Drawing.Size(776, 289);
            this.DanhSachMonDataGridView.TabIndex = 4;
            // 
            // txb_TongSoTien
            // 
            this.txb_TongSoTien.Location = new System.Drawing.Point(72, 60);
            this.txb_TongSoTien.Name = "txb_TongSoTien";
            this.txb_TongSoTien.Size = new System.Drawing.Size(164, 20);
            this.txb_TongSoTien.TabIndex = 5;
            // 
            // btn_DongTien
            // 
            this.btn_DongTien.Location = new System.Drawing.Point(252, 60);
            this.btn_DongTien.Name = "btn_DongTien";
            this.btn_DongTien.Size = new System.Drawing.Size(75, 23);
            this.btn_DongTien.TabIndex = 6;
            this.btn_DongTien.Text = "Đóng tiền";
            this.btn_DongTien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Môn học";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(429, 16);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbbMonHoc.TabIndex = 8;
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Location = new System.Drawing.Point(593, 16);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(75, 23);
            this.btnHuyMon.TabIndex = 9;
            this.btnHuyMon.Text = "Hủy môn";
            this.btnHuyMon.UseVisualStyleBackColor = true;
            // 
            // ChinhSuaThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuyMon);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DongTien);
            this.Controls.Add(this.txb_TongSoTien);
            this.Controls.Add(this.DanhSachMonDataGridView);
            this.Controls.Add(this.bnt_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChinhSuaThongTinSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_Search;
        private System.Windows.Forms.DataGridView DanhSachMonDataGridView;
        private System.Windows.Forms.TextBox txb_TongSoTien;
        private System.Windows.Forms.Button btn_DongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Button btnHuyMon;
    }
}