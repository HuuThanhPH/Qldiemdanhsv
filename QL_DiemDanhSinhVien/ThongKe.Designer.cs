﻿namespace QL_DiemDanhSinhVien
{
    partial class ThongKe
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
            this.btn_Thongketheomasv = new System.Windows.Forms.Button();
            this.btn_Thongketheomamonhoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(401, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ ĐIỂM DANH";
            // 
            // btn_Thongketheomasv
            // 
            this.btn_Thongketheomasv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thongketheomasv.Location = new System.Drawing.Point(271, 144);
            this.btn_Thongketheomasv.Name = "btn_Thongketheomasv";
            this.btn_Thongketheomasv.Size = new System.Drawing.Size(162, 150);
            this.btn_Thongketheomasv.TabIndex = 2;
            this.btn_Thongketheomasv.Text = "THỐNG KÊ THEO MÃ SỐ SINH VIÊN";
            this.btn_Thongketheomasv.UseVisualStyleBackColor = true;
            this.btn_Thongketheomasv.Click += new System.EventHandler(this.btn_Thongketheomasv_Click);
            // 
            // btn_Thongketheomamonhoc
            // 
            this.btn_Thongketheomamonhoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thongketheomamonhoc.Location = new System.Drawing.Point(669, 144);
            this.btn_Thongketheomamonhoc.Name = "btn_Thongketheomamonhoc";
            this.btn_Thongketheomamonhoc.Size = new System.Drawing.Size(162, 150);
            this.btn_Thongketheomamonhoc.TabIndex = 3;
            this.btn_Thongketheomamonhoc.Text = "THỐNG KÊ THEO MÃ MÔN HỌC";
            this.btn_Thongketheomamonhoc.UseVisualStyleBackColor = true;
            this.btn_Thongketheomamonhoc.Click += new System.EventHandler(this.btn_Thongketheomamonhoc_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1138, 589);
            this.Controls.Add(this.btn_Thongketheomamonhoc);
            this.Controls.Add(this.btn_Thongketheomasv);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thongketheomasv;
        private System.Windows.Forms.Button btn_Thongketheomamonhoc;
    }
}