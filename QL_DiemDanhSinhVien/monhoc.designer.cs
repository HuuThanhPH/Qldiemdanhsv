namespace QL_DiemDanhSinhVien
{
    partial class MonHoc
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
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.gr3 = new System.Windows.Forms.GroupBox();
            this.them = new System.Windows.Forms.Button();
            this.txt_mmonhoc = new System.Windows.Forms.TextBox();
            this.lb_monhoc = new System.Windows.Forms.Label();
            this.lb_maGV = new System.Windows.Forms.Label();
            this.dgvTTSV = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.txt_monhoc = new System.Windows.Forms.TextBox();
            this.lb_tenmh = new System.Windows.Forms.Label();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.gr3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).BeginInit();
            this.gr2.SuspendLayout();
            this.gr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.LightCyan;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sua.Location = new System.Drawing.Point(299, 36);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(108, 46);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.xoa.Location = new System.Drawing.Point(169, 36);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(108, 46);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // gr3
            // 
            this.gr3.Controls.Add(this.sua);
            this.gr3.Controls.Add(this.xoa);
            this.gr3.Controls.Add(this.them);
            this.gr3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr3.Location = new System.Drawing.Point(12, 373);
            this.gr3.Name = "gr3";
            this.gr3.Size = new System.Drawing.Size(437, 145);
            this.gr3.TabIndex = 6;
            this.gr3.TabStop = false;
            this.gr3.Text = "Chức Năng";
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.CadetBlue;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.them.Location = new System.Drawing.Point(36, 36);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(108, 46);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txt_mmonhoc
            // 
            this.txt_mmonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_mmonhoc.Location = new System.Drawing.Point(191, 62);
            this.txt_mmonhoc.Name = "txt_mmonhoc";
            this.txt_mmonhoc.Size = new System.Drawing.Size(205, 30);
            this.txt_mmonhoc.TabIndex = 17;
            // 
            // lb_monhoc
            // 
            this.lb_monhoc.AutoSize = true;
            this.lb_monhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_monhoc.Location = new System.Drawing.Point(29, 70);
            this.lb_monhoc.Name = "lb_monhoc";
            this.lb_monhoc.Size = new System.Drawing.Size(115, 20);
            this.lb_monhoc.TabIndex = 3;
            this.lb_monhoc.Text = "Mã Môn Học";
            // 
            // lb_maGV
            // 
            this.lb_maGV.AutoSize = true;
            this.lb_maGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_maGV.Location = new System.Drawing.Point(25, 195);
            this.lb_maGV.Name = "lb_maGV";
            this.lb_maGV.Size = new System.Drawing.Size(132, 20);
            this.lb_maGV.TabIndex = 2;
            this.lb_maGV.Text = "Mã Giảng Viên";
            // 
            // dgvTTSV
            // 
            this.dgvTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.MaGV});
            this.dgvTTSV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTTSV.Location = new System.Drawing.Point(19, 25);
            this.dgvTTSV.Name = "dgvTTSV";
            this.dgvTTSV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTTSV.RowHeadersWidth = 51;
            this.dgvTTSV.RowTemplate.Height = 24;
            this.dgvTTSV.Size = new System.Drawing.Size(734, 425);
            this.dgvTTSV.TabIndex = 0;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 300;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.cboMaGV);
            this.gr2.Controls.Add(this.txt_monhoc);
            this.gr2.Controls.Add(this.lb_tenmh);
            this.gr2.Controls.Add(this.txt_mmonhoc);
            this.gr2.Controls.Add(this.lb_monhoc);
            this.gr2.Controls.Add(this.lb_maGV);
            this.gr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr2.Location = new System.Drawing.Point(12, 56);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(437, 260);
            this.gr2.TabIndex = 5;
            this.gr2.TabStop = false;
            this.gr2.Text = "Thông Tin Môn Học";
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(191, 191);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(205, 28);
            this.cboMaGV.TabIndex = 22;
            // 
            // txt_monhoc
            // 
            this.txt_monhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_monhoc.Location = new System.Drawing.Point(191, 123);
            this.txt_monhoc.Name = "txt_monhoc";
            this.txt_monhoc.Size = new System.Drawing.Size(205, 30);
            this.txt_monhoc.TabIndex = 20;
            // 
            // lb_tenmh
            // 
            this.lb_tenmh.AutoSize = true;
            this.lb_tenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lb_tenmh.Location = new System.Drawing.Point(25, 131);
            this.lb_tenmh.Name = "lb_tenmh";
            this.lb_tenmh.Size = new System.Drawing.Size(121, 20);
            this.lb_tenmh.TabIndex = 19;
            this.lb_tenmh.Text = "Tên Môn Học";
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.dgvTTSV);
            this.gr1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr1.Location = new System.Drawing.Point(477, 56);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(768, 462);
            this.gr1.TabIndex = 4;
            this.gr1.TabStop = false;
            this.gr1.Text = "Danh Sách Môn Học";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1262, 532);
            this.Controls.Add(this.gr3);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.gr1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MonHoc";
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.monhoc_Load);
            this.gr3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).EndInit();
            this.gr2.ResumeLayout(false);
            this.gr2.PerformLayout();
            this.gr1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.GroupBox gr3;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txt_mmonhoc;
        private System.Windows.Forms.Label lb_monhoc;
        private System.Windows.Forms.Label lb_maGV;
        private System.Windows.Forms.DataGridView dgvTTSV;
        private System.Windows.Forms.GroupBox gr2;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.TextBox txt_monhoc;
        private System.Windows.Forms.Label lb_tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.ComboBox cboMaGV;
    }
}