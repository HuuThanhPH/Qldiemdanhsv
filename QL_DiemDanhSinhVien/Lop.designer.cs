namespace QL_DiemDanhSinhVien
{
    partial class Lop
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
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.dgvTTSV = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.lb_lop = new System.Windows.Forms.Label();
            this.lb_malop = new System.Windows.Forms.Label();
            this.gr3 = new System.Windows.Forms.GroupBox();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).BeginInit();
            this.gr2.SuspendLayout();
            this.gr3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.dgvTTSV);
            this.gr1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr1.Location = new System.Drawing.Point(511, 22);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(636, 401);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = false;
            this.gr1.Text = "Danh Sách Lớp";
            // 
            // dgvTTSV
            // 
            this.dgvTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop});
            this.dgvTTSV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTTSV.Location = new System.Drawing.Point(17, 16);
            this.dgvTTSV.Name = "dgvTTSV";
            this.dgvTTSV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTTSV.RowHeadersWidth = 51;
            this.dgvTTSV.RowTemplate.Height = 24;
            this.dgvTTSV.Size = new System.Drawing.Size(605, 368);
            this.dgvTTSV.TabIndex = 0;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 300;
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.txt_malop);
            this.gr2.Controls.Add(this.txt_lop);
            this.gr2.Controls.Add(this.lb_lop);
            this.gr2.Controls.Add(this.lb_malop);
            this.gr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr2.Location = new System.Drawing.Point(48, 22);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(437, 201);
            this.gr2.TabIndex = 1;
            this.gr2.TabStop = false;
            this.gr2.Text = "Thông Tin Lớp";
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_malop.Location = new System.Drawing.Point(169, 68);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(205, 30);
            this.txt_malop.TabIndex = 18;
            // 
            // txt_lop
            // 
            this.txt_lop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_lop.Location = new System.Drawing.Point(169, 132);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(205, 30);
            this.txt_lop.TabIndex = 17;
            // 
            // lb_lop
            // 
            this.lb_lop.AutoSize = true;
            this.lb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_lop.Location = new System.Drawing.Point(32, 135);
            this.lb_lop.Name = "lb_lop";
            this.lb_lop.Size = new System.Drawing.Size(77, 20);
            this.lb_lop.TabIndex = 3;
            this.lb_lop.Text = "Tên Lớp";
            // 
            // lb_malop
            // 
            this.lb_malop.AutoSize = true;
            this.lb_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_malop.Location = new System.Drawing.Point(32, 68);
            this.lb_malop.Name = "lb_malop";
            this.lb_malop.Size = new System.Drawing.Size(71, 20);
            this.lb_malop.TabIndex = 2;
            this.lb_malop.Text = "Mã Lớp";
            // 
            // gr3
            // 
            this.gr3.Controls.Add(this.sua);
            this.gr3.Controls.Add(this.xoa);
            this.gr3.Controls.Add(this.them);
            this.gr3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr3.Location = new System.Drawing.Point(48, 282);
            this.gr3.Name = "gr3";
            this.gr3.Size = new System.Drawing.Size(437, 145);
            this.gr3.TabIndex = 2;
            this.gr3.TabStop = false;
            this.gr3.Text = "Chức Năng";
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
            // them
            // 
            this.them.BackColor = System.Drawing.Color.CadetBlue;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(36, 36);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(108, 46);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1157, 435);
            this.Controls.Add(this.gr3);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.gr1);
            this.Name = "Lop";
            this.Text = "Quản Lý Lớp";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.gr1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSV)).EndInit();
            this.gr2.ResumeLayout(false);
            this.gr2.PerformLayout();
            this.gr3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.GroupBox gr2;
        private System.Windows.Forms.GroupBox gr3;
        private System.Windows.Forms.Label lb_lop;
        private System.Windows.Forms.Label lb_malop;
        private System.Windows.Forms.DataGridView dgvTTSV;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
    }
}

