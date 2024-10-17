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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuocPhi));
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkBox2 = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            chkDongKiem = new CheckBox();
            label10 = new Label();
            chkBaoHiem = new CheckBox();
            btnXacNhan = new Button();
            btnHuyBo = new Button();
            label13 = new Label();
            txtTongTien = new TextBox();
            txtGhichu = new TextBox();
            label14 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 34);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 34);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(300, 199);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 9;
            label7.Text = "216.000 đ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(300, 131);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 8;
            label6.Text = "38.500 đ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(300, 65);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 7;
            label5.Text = "31.000 đ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(97, 229);
            label4.Name = "label4";
            label4.Size = new Size(193, 19);
            label4.TabIndex = 6;
            label4.Text = "Thời gian giao dự kiến: 2 ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(97, 156);
            label3.Name = "label3";
            label3.Size = new Size(193, 19);
            label3.TabIndex = 5;
            label3.Text = "Thời gian giao dự kiến: 3 ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(97, 97);
            label2.Name = "label2";
            label2.Size = new Size(204, 19);
            label2.TabIndex = 4;
            label2.Text = "Thời gian giao dự kiến: 4.5 ngày";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton3.Location = new Point(71, 197);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(178, 29);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Hỏa tốc, hẹn giờ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton2.Location = new Point(71, 129);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(150, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "TMDT Nhanh";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton1.Location = new Point(71, 65);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(174, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "TMDT Tiết Kiệm";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(97, 30);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Dịch vụ vận chuyển";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(508, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(71, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(164, 29);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Hàng giá trị cao";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(300, 78);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 13;
            label9.Text = "4.999 đ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(44, 27);
            label8.Name = "label8";
            label8.Size = new Size(330, 32);
            label8.TabIndex = 13;
            label8.Text = "Tính chất hàng hóa đặc biệt";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(chkDongKiem);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(chkBaoHiem);
            groupBox3.Location = new Point(508, 168);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(448, 177);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(300, 132);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 17;
            label12.Text = "16.500 đ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(300, 85);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 16;
            label11.Text = "4.999 đ";
            // 
            // chkDongKiem
            // 
            chkDongKiem.AutoSize = true;
            chkDongKiem.Location = new Point(71, 132);
            chkDongKiem.Name = "chkDongKiem";
            chkDongKiem.Size = new Size(126, 29);
            chkDongKiem.TabIndex = 16;
            chkDongKiem.Text = "Đồng kiểm";
            chkDongKiem.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(44, 27);
            label10.Name = "label10";
            label10.Size = new Size(268, 32);
            label10.TabIndex = 15;
            label10.Text = "Dịch vụ cộng thêm (0)";
            // 
            // chkBaoHiem
            // 
            chkBaoHiem.AutoSize = true;
            chkBaoHiem.Location = new Point(71, 81);
            chkBaoHiem.Name = "chkBaoHiem";
            chkBaoHiem.Size = new Size(201, 29);
            chkBaoHiem.TabIndex = 14;
            chkBaoHiem.Text = "Bảo hiểm và khai giá";
            chkBaoHiem.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.Location = new Point(537, 395);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(157, 65);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;

            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Location = new Point(761, 395);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(153, 65);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(12, 428);
            label13.Name = "label13";
            label13.Size = new Size(129, 32);
            label13.TabIndex = 5;
            label13.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(183, 431);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(150, 31);
            txtTongTien.TabIndex = 6;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(183, 297);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(300, 100);
            txtGhichu.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(12, 313);
            label14.Name = "label14";
            label14.Size = new Size(152, 32);
            label14.TabIndex = 8;
            label14.Text = "Ghi chú đơn";
            // 
            // toolTip1
            // 

            // 
            // Cuocphi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 716);
            Controls.Add(label14);
            Controls.Add(txtGhichu);
            Controls.Add(txtTongTien);
            Controls.Add(label13);
            Controls.Add(btnHuyBo);
            Controls.Add(btnXacNhan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Cuocphi";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox chkBaoHiem;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox checkBox2;
        private Label label12;
        private Label label11;
        private CheckBox chkDongKiem;
        private Button btnXacNhan;
        private Button btnHuyBo;
        private Label label13;
        private TextBox txtTongTien;
        private TextBox txtGhichu;
        private Label label14;
        private ToolTip toolTip1;
    }
}