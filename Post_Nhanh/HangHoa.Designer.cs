using System.Windows.Forms;

namespace Post_Nhanh
{
    partial class HangHoa
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
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxTotalGT = new System.Windows.Forms.TextBox();
            this.textBoxTotalWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKL = new System.Windows.Forms.Label();
            this.textBoxGT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenSP = new System.Windows.Forms.TextBox();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.groupBoxImageProduct = new System.Windows.Forms.GroupBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonTiepTuc = new System.Windows.Forms.Button();
            this.groupBoxHangHoa = new System.Windows.Forms.GroupBox();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxImageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÀNG HÓA";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxProduct.Controls.Add(this.textBoxTotalGT);
            this.groupBoxProduct.Controls.Add(this.textBoxTotalWeight);
            this.groupBoxProduct.Controls.Add(this.label5);
            this.groupBoxProduct.Controls.Add(this.label4);
            this.groupBoxProduct.Controls.Add(this.labelKL);
            this.groupBoxProduct.Controls.Add(this.textBoxGT);
            this.groupBoxProduct.Controls.Add(this.label3);
            this.groupBoxProduct.Controls.Add(this.textBoxSL);
            this.groupBoxProduct.Controls.Add(this.label2);
            this.groupBoxProduct.Controls.Add(this.textBoxTenSP);
            this.groupBoxProduct.Controls.Add(this.labelTenSP);
            this.groupBoxProduct.Controls.Add(this.groupBoxHangHoa);
            this.groupBoxProduct.Location = new System.Drawing.Point(29, 65);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProduct.Size = new System.Drawing.Size(543, 369);
            this.groupBoxProduct.TabIndex = 1;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Hàng Hóa";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(227, 89);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(141, 25);
            this.buttonAddProduct.TabIndex = 13;
            this.buttonAddProduct.Text = " + Thêm hàng hóa";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxTotalGT
            // 
            this.textBoxTotalGT.Enabled = false;
            this.textBoxTotalGT.Location = new System.Drawing.Point(442, 153);
            this.textBoxTotalGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotalGT.Name = "textBoxTotalGT";
            this.textBoxTotalGT.Size = new System.Drawing.Size(95, 22);
            this.textBoxTotalGT.TabIndex = 12;
            this.textBoxTotalGT.TextChanged += new System.EventHandler(this.textBoxTotalGT_TextChanged);
            // 
            // textBoxTotalWeight
            // 
            this.textBoxTotalWeight.Enabled = false;
            this.textBoxTotalWeight.Location = new System.Drawing.Point(442, 126);
            this.textBoxTotalWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotalWeight.Name = "textBoxTotalWeight";
            this.textBoxTotalWeight.Size = new System.Drawing.Size(95, 22);
            this.textBoxTotalWeight.TabIndex = 11;
            this.textBoxTotalWeight.TextChanged += new System.EventHandler(this.textBoxTotalWeight_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng giá trị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng khối lượng:";
            // 
            // labelKL
            // 
            this.labelKL.AutoSize = true;
            this.labelKL.Location = new System.Drawing.Point(331, 54);
            this.labelKL.Name = "labelKL";
            this.labelKL.Size = new System.Drawing.Size(88, 16);
            this.labelKL.TabIndex = 7;
            this.labelKL.Text = "Khối lượng (g)";
            // 
            // textBoxGT
            // 
            this.textBoxGT.Location = new System.Drawing.Point(109, 49);
            this.textBoxGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGT.Name = "textBoxGT";
            this.textBoxGT.Size = new System.Drawing.Size(196, 22);
            this.textBoxGT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "GIá trị(đ)";
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(414, 16);
            this.textBoxSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(123, 22);
            this.textBoxSL.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.Location = new System.Drawing.Point(109, 16);
            this.textBoxTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.Size = new System.Drawing.Size(196, 22);
            this.textBoxTenSP.TabIndex = 2;
            // 
            // labelTenSP
            // 
            this.labelTenSP.AutoSize = true;
            this.labelTenSP.Location = new System.Drawing.Point(3, 18);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(90, 16);
            this.labelTenSP.TabIndex = 0;
            this.labelTenSP.Text = "Tên hàng hóa";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(471, 119);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(95, 22);
            this.textBoxWeight.TabIndex = 8;
            // 
            // groupBoxImageProduct
            // 
            this.groupBoxImageProduct.Controls.Add(this.textBoxWidth);
            this.groupBoxImageProduct.Controls.Add(this.label7);
            this.groupBoxImageProduct.Controls.Add(this.textBoxLenght);
            this.groupBoxImageProduct.Controls.Add(this.label6);
            this.groupBoxImageProduct.Controls.Add(this.buttonDeleteImage);
            this.groupBoxImageProduct.Controls.Add(this.pictureBox2);
            this.groupBoxImageProduct.Controls.Add(this.pictureBox1);
            this.groupBoxImageProduct.Controls.Add(this.buttonUploadImage);
            this.groupBoxImageProduct.Location = new System.Drawing.Point(606, 81);
            this.groupBoxImageProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxImageProduct.Name = "groupBoxImageProduct";
            this.groupBoxImageProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxImageProduct.Size = new System.Drawing.Size(543, 284);
            this.groupBoxImageProduct.TabIndex = 9;
            this.groupBoxImageProduct.TabStop = false;
            this.groupBoxImageProduct.Text = "Ảnh Hàng Hóa";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(396, 235);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(125, 22);
            this.textBoxWidth.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chiều rộng";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(122, 232);
            this.textBoxLenght.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(125, 22);
            this.textBoxLenght.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chiều dài";
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(412, 183);
            this.buttonDeleteImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteImage.TabIndex = 3;
            this.buttonDeleteImage.Text = "Xóa tất cả ảnh";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(320, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 146);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(121, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(6, 38);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(94, 23);
            this.buttonUploadImage.TabIndex = 0;
            this.buttonUploadImage.Text = "Chọn ảnh";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // buttonTiepTuc
            // 
            this.buttonTiepTuc.BackColor = System.Drawing.Color.Red;
            this.buttonTiepTuc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiepTuc.ForeColor = System.Drawing.Color.White;
            this.buttonTiepTuc.Location = new System.Drawing.Point(519, 451);
            this.buttonTiepTuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTiepTuc.Name = "buttonTiepTuc";
            this.buttonTiepTuc.Size = new System.Drawing.Size(187, 48);
            this.buttonTiepTuc.TabIndex = 10;
            this.buttonTiepTuc.Text = "Tiếp Tục";
            this.buttonTiepTuc.UseVisualStyleBackColor = false;
            this.buttonTiepTuc.Click += new System.EventHandler(this.buttonTiepTuc_Click);
            // 
            // groupBoxHangHoa
            // 
            this.groupBoxHangHoa.Location = new System.Drawing.Point(6, 16);
            this.groupBoxHangHoa.Name = "groupBoxHangHoa";
            this.groupBoxHangHoa.Size = new System.Drawing.Size(531, 102);
            this.groupBoxHangHoa.TabIndex = 11;
            this.groupBoxHangHoa.TabStop = false;
            this.groupBoxHangHoa.Text = "groupBox1";
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 519);
            this.Controls.Add(this.buttonTiepTuc);
            this.Controls.Add(this.groupBoxImageProduct);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HangHoa";
            this.Text = "Product";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxImageProduct.ResumeLayout(false);
            this.groupBoxImageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBoxProduct;
        private Label label3;
        private Label label2;
        private TextBox textBoxTenSP;
        private Label labelTenSP;
        private TextBox textBoxSL;
        private Label labelKL;
        private TextBox textBoxGT;
        private TextBox textBoxWeight;
        private Label label5;
        private Label label4;
        private TextBox textBoxTotalGT;
        private TextBox textBoxTotalWeight;
        private GroupBox groupBoxImageProduct;
        private Button buttonDeleteImage;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonUploadImage;
        private Button buttonTiepTuc;
        private Button buttonAddProduct;
        private TextBox textBoxLenght;
        private Label label6;
        private TextBox textBoxWidth;
        private Label label7;
        private GroupBox groupBoxHangHoa;
    }
}