using System.Drawing;
using System.Windows.Forms;

namespace Post_Nhanh
{
    partial class CuocPhi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkDongKiem = new System.Windows.Forms.CheckBox();
            this.chkBaoHiem = new System.Windows.Forms.CheckBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxTietKiem = new System.Windows.Forms.TextBox();
            this.textBoxNhanh = new System.Windows.Forms.TextBox();
            this.textBoxHoaToc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHoaToc);
            this.groupBox1.Controls.Add(this.textBoxNhanh);
            this.groupBox1.Controls.Add(this.textBoxTietKiem);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ vận chuyển";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(20, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(80, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian dự kiến: 2 ngày";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời gian dự kiến: 3 ngày";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(80, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian dự kiến: 4.5 ngày";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(60, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 28);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Hỏa tốc";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(60, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 28);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "TMDT Nhanh";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(60, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 28);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "TMDT Tiết Kiệm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(450, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính chất hàng hóa";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(30, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Hàng giá trị cao";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(250, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "4.999 đ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(30, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hàng hóa đặc biệt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.chkDongKiem);
            this.groupBox3.Controls.Add(this.chkBaoHiem);
            this.groupBox3.Location = new System.Drawing.Point(450, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ cộng thêm";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(250, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "16.500 đ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(250, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "4.999 đ";
            // 
            // chkDongKiem
            // 
            this.chkDongKiem.Location = new System.Drawing.Point(30, 100);
            this.chkDongKiem.Name = "chkDongKiem";
            this.chkDongKiem.Size = new System.Drawing.Size(104, 24);
            this.chkDongKiem.TabIndex = 2;
            this.chkDongKiem.Text = "Đồng kiểm";
            // 
            // chkBaoHiem
            // 
            this.chkBaoHiem.Location = new System.Drawing.Point(30, 60);
            this.chkBaoHiem.Name = "chkBaoHiem";
            this.chkBaoHiem.Size = new System.Drawing.Size(220, 24);
            this.chkBaoHiem.TabIndex = 3;
            this.chkBaoHiem.Text = "Bảo hiểm và khai giá";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(480, 295);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(141, 90);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Red;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.Location = new System.Drawing.Point(680, 302);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(130, 83);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(20, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 90);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tổng tiền:";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(178, 270);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(250, 80);
            this.txtGhichu.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(20, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 80);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ghi chú đơn hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(176, 388);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(150, 45);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "0 đ";
            // 
            // textBoxTietKiem
            // 
            this.textBoxTietKiem.Enabled = false;
            this.textBoxTietKiem.Location = new System.Drawing.Point(291, 50);
            this.textBoxTietKiem.Name = "textBoxTietKiem";
            this.textBoxTietKiem.Size = new System.Drawing.Size(89, 30);
            this.textBoxTietKiem.TabIndex = 12;
            // 
            // textBoxNhanh
            // 
            this.textBoxNhanh.Enabled = false;
            this.textBoxNhanh.Location = new System.Drawing.Point(291, 103);
            this.textBoxNhanh.Name = "textBoxNhanh";
            this.textBoxNhanh.Size = new System.Drawing.Size(89, 30);
            this.textBoxNhanh.TabIndex = 13;
            // 
            // textBoxHoaToc
            // 
            this.textBoxHoaToc.Enabled = false;
            this.textBoxHoaToc.Location = new System.Drawing.Point(291, 163);
            this.textBoxHoaToc.Name = "textBoxHoaToc";
            this.textBoxHoaToc.Size = new System.Drawing.Size(89, 30);
            this.textBoxHoaToc.TabIndex = 14;
            // 
            // CuocPhi
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label14);
            this.Name = "CuocPhi";
            this.Text = "Tính Phí Giao Hàng";
            this.Load += new System.EventHandler(this.CuocPhi_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox chkBaoHiem;
        private Label label8;
        private Label label9;
        private CheckBox checkBox2;
        private Label label12;
        private Label label11;
        private CheckBox chkDongKiem;
        private Button btnXacNhan;
        private Button btnHuyBo;
        private Label label13;
        private TextBox txtGhichu;
        private Label label14;
        private ToolTip toolTip1;
        private Label lblTongTien;
        private TextBox textBoxHoaToc;
        private TextBox textBoxNhanh;
        private TextBox textBoxTietKiem;
    }
}