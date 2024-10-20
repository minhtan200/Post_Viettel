using System;
using System.Drawing;
using System.Windows.Forms;
namespace Post_Nhanh
{
    partial class QuanLyDH
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
            this.dataGridViewDonHang = new System.Windows.Forms.DataGridView();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDonHang
            // 
            this.dataGridViewDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonHang.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDonHang.Name = "dataGridViewDonHang";
            this.dataGridViewDonHang.RowHeadersWidth = 51;
            this.dataGridViewDonHang.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewDonHang.TabIndex = 0;
            this.dataGridViewDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonHang_CellClick);
            this.dataGridViewDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonHang_CellContentClick);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Location = new System.Drawing.Point(130, 350);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(120, 30);
            this.buttonXacNhan.TabIndex = 1;
            this.buttonXacNhan.Text = "Xác nhận đơn";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(270, 350);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(120, 30);
            this.buttonHuy.TabIndex = 2;
            this.buttonHuy.Text = "Hủy đơn";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(12, 320);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(70, 16);
            this.labelTrangThai.TabIndex = 3;
            this.labelTrangThai.Text = "Trạng thái:";
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Đang xử lý",
            "Hoàn thành"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(130, 320);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTrangThai.TabIndex = 4;
            // 
            // QuanLyDH
            // 
            this.ClientSize = new System.Drawing.Size(615, 392);
            this.Controls.Add(this.comboBoxTrangThai);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.dataGridViewDonHang);
            this.Name = "QuanLyDH";
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Event handling cho chọn đơn hàng trong GridView
       
        // Event handling cho nút Xác nhận đơn hàng
        

        private System.Windows.Forms.DataGridView dataGridViewDonHang;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
    }
}