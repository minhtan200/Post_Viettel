namespace Post_Nhanh
{
    partial class TraCuuGH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Các thành phần giao diện
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label lblPhoneNumber; // Label cho số điện thoại
        private System.Windows.Forms.TextBox txtPhoneNumber; // TextBox cho số điện thoại
        private System.Windows.Forms.Label lblNote; // Thêm Label cho ghi chú
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dgvTrangThai;
        private System.Windows.Forms.ProgressBar progressBarTraCuu;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label lblTrangThaiThongBao;
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
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
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
            this.lblMaDonHang.Location = new System.Drawing.Point(28, 32);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(122, 20);
            this.lblMaDonHang.TabIndex = 0;
            this.lblMaDonHang.Text = "Mã đơn hàng:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(178, 32);
            this.txtMaDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(267, 26);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.Location = new System.Drawing.Point(28, 80);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(125, 20);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(178, 80);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(267, 26);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblNote.Location = new System.Drawing.Point(178, 112);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(442, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Nhập mã đơn hàng hoặc số điện thoại người gửi để tra cứu";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(504, 51);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(124, 32);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangThai.Location = new System.Drawing.Point(27, 208);
            this.dgvTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.RowHeadersWidth = 62;
            this.dgvTrangThai.RowTemplate.Height = 28;
            this.dgvTrangThai.Size = new System.Drawing.Size(978, 280);
            this.dgvTrangThai.TabIndex = 3;
            this.dgvTrangThai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTrangThai_CellFormatting);
            // 
            // progressBarTraCuu
            // 
            this.progressBarTraCuu.Location = new System.Drawing.Point(27, 176);
            this.progressBarTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTraCuu.Name = "progressBarTraCuu";
            this.progressBarTraCuu.Size = new System.Drawing.Size(978, 16);
            this.progressBarTraCuu.TabIndex = 4;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.lblMaDonHang);
            this.groupBoxThongTin.Controls.Add(this.txtMaDonHang);
            this.groupBoxThongTin.Controls.Add(this.lblPhoneNumber);
            this.groupBoxThongTin.Controls.Add(this.txtPhoneNumber);
            this.groupBoxThongTin.Controls.Add(this.lblNote);
            this.groupBoxThongTin.Controls.Add(this.btnTraCuu);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.Location = new System.Drawing.Point(27, 24);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTin.Size = new System.Drawing.Size(978, 144);
            this.groupBoxThongTin.TabIndex = 7;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin tra cứu đơn hàng";
            // 
            // lblTrangThaiThongBao
            // 
            this.lblTrangThaiThongBao.AutoSize = true;
            this.lblTrangThaiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblTrangThaiThongBao.Location = new System.Drawing.Point(27, 496);
            this.lblTrangThaiThongBao.Name = "lblTrangThaiThongBao";
            this.lblTrangThaiThongBao.Size = new System.Drawing.Size(287, 20);
            this.lblTrangThaiThongBao.TabIndex = 8;
            this.lblTrangThaiThongBao.Text = "Chọn mã đơn hàng để xem trạng thái.";
            // 
            // TraCuuGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 536);
            this.Controls.Add(this.lblTrangThaiThongBao);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.progressBarTraCuu);
            this.Controls.Add(this.dgvTrangThai);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuGH";
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