namespace Post_Nhanh
{
    partial class Xemtrangthai
    {
        private System.ComponentModel.IContainer components = null;

        // Các thành phần giao diện
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dgvTrangThai;
        private System.Windows.Forms.ProgressBar progressBarTraCuu;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label lblTrangThaiThongBao;

        /// <summary>
        /// Dọn dẹp các tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">Xác định xem tài nguyên cần được giải phóng hay không.</param>
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
        /// Phương thức bắt buộc cho thiết kế giao diện, không được sửa đổi trực tiếp mã này.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dgvTrangThai = new System.Windows.Forms.DataGridView();
            this.progressBarTraCuu = new System.Windows.Forms.ProgressBar();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiThongBao = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).BeginInit();
            this.groupBoxThongTin.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaDonHang.Location = new System.Drawing.Point(31, 40);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(145, 25);
            this.lblMaDonHang.TabIndex = 0;
            this.lblMaDonHang.Text = "Mã đơn hàng:";

            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(200, 40);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(300, 30);
            this.txtMaDonHang.TabIndex = 1;

            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            //this.btnTraCuu.Image = System.Drawing.Image.FromFile("search_icon.png"); // thêm biểu tượng nút
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(530, 40);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(140, 40);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;

            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangThai.Location = new System.Drawing.Point(30, 260);
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.RowHeadersWidth = 62;
            this.dgvTrangThai.RowTemplate.Height = 28;
            this.dgvTrangThai.Size = new System.Drawing.Size(1100, 350);
            this.dgvTrangThai.TabIndex = 3;

            // 
            // progressBarTraCuu
            // 
            this.progressBarTraCuu.Location = new System.Drawing.Point(30, 220);
            this.progressBarTraCuu.Name = "progressBarTraCuu";
            this.progressBarTraCuu.Size = new System.Drawing.Size(1100, 20);
            this.progressBarTraCuu.TabIndex = 4;

            // 
            // lblTrangThaiThongBao
            // 
            this.lblTrangThaiThongBao.AutoSize = true;
            this.lblTrangThaiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblTrangThaiThongBao.Location = new System.Drawing.Point(30, 620);
            this.lblTrangThaiThongBao.Name = "lblTrangThaiThongBao";
            this.lblTrangThaiThongBao.Size = new System.Drawing.Size(320, 25);
            this.lblTrangThaiThongBao.TabIndex = 8;
            this.lblTrangThaiThongBao.Text = "Chọn mã đơn hàng để xem trạng thái.";

            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.lblMaDonHang);
            this.groupBoxThongTin.Controls.Add(this.txtMaDonHang);
            this.groupBoxThongTin.Controls.Add(this.btnTraCuu);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.Location = new System.Drawing.Point(30, 30);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(1100, 160);
            this.groupBoxThongTin.TabIndex = 7;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin tra cứu đơn hàng";

            // 
            // Xemtrangthai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 670);
            this.Controls.Add(this.lblTrangThaiThongBao);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.progressBarTraCuu);
            this.Controls.Add(this.dgvTrangThai);
            this.Name = "Xemtrangthai";
            this.Text = "Xem trạng thái đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).EndInit();
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
