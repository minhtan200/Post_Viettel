using System;
using System.Windows.Forms;


namespace Post_Nhanh
{
    partial class DiaChi
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
            this.senderGroup = new System.Windows.Forms.GroupBox();
            this.senderPhoneLabel = new System.Windows.Forms.Label();
            this.senderPhoneTextBox = new System.Windows.Forms.TextBox();
            this.senderNameLabel = new System.Windows.Forms.Label();
            this.senderNameTextBox = new System.Windows.Forms.TextBox();
            this.senderAddressLabel = new System.Windows.Forms.Label();
            this.senderAddressTextBox = new System.Windows.Forms.TextBox();
            this.receiverGroup = new System.Windows.Forms.GroupBox();
            this.receiverPhoneLabel = new System.Windows.Forms.Label();
            this.receiverPhoneTextBox = new System.Windows.Forms.TextBox();
            this.receiverNameLabel = new System.Windows.Forms.Label();
            this.receiverNameTextBox = new System.Windows.Forms.TextBox();
            this.receiverAddressLabel = new System.Windows.Forms.Label();
            this.receiverAddressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.senderGroup.SuspendLayout();
            this.receiverGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderGroup
            // 
            this.senderGroup.Controls.Add(this.senderPhoneLabel);
            this.senderGroup.Controls.Add(this.senderPhoneTextBox);
            this.senderGroup.Controls.Add(this.senderNameLabel);
            this.senderGroup.Controls.Add(this.senderNameTextBox);
            this.senderGroup.Controls.Add(this.senderAddressLabel);
            this.senderGroup.Controls.Add(this.senderAddressTextBox);
            this.senderGroup.Location = new System.Drawing.Point(10, 41);
            this.senderGroup.Name = "senderGroup";
            this.senderGroup.Size = new System.Drawing.Size(380, 150);
            this.senderGroup.TabIndex = 1;
            this.senderGroup.TabStop = false;
            this.senderGroup.Text = "Người gửi";
            // 
            // senderPhoneLabel
            // 
            this.senderPhoneLabel.AutoSize = true;
            this.senderPhoneLabel.Location = new System.Drawing.Point(10, 30);
            this.senderPhoneLabel.Name = "senderPhoneLabel";
            this.senderPhoneLabel.Size = new System.Drawing.Size(88, 16);
            this.senderPhoneLabel.TabIndex = 0;
            this.senderPhoneLabel.Text = "Số điện thoại:";
            // 
            // senderPhoneTextBox
            // 
            this.senderPhoneTextBox.Location = new System.Drawing.Point(130, 30);
            this.senderPhoneTextBox.Name = "senderPhoneTextBox";
            this.senderPhoneTextBox.Size = new System.Drawing.Size(230, 22);
            this.senderPhoneTextBox.TabIndex = 1;
            // 
            // senderNameLabel
            // 
            this.senderNameLabel.AutoSize = true;
            this.senderNameLabel.Location = new System.Drawing.Point(10, 60);
            this.senderNameLabel.Name = "senderNameLabel";
            this.senderNameLabel.Size = new System.Drawing.Size(49, 16);
            this.senderNameLabel.TabIndex = 2;
            this.senderNameLabel.Text = "Họ tên:";
            // 
            // senderNameTextBox
            // 
            this.senderNameTextBox.Location = new System.Drawing.Point(130, 60);
            this.senderNameTextBox.Name = "senderNameTextBox";
            this.senderNameTextBox.Size = new System.Drawing.Size(230, 22);
            this.senderNameTextBox.TabIndex = 3;
            // 
            // senderAddressLabel
            // 
            this.senderAddressLabel.AutoSize = true;
            this.senderAddressLabel.Location = new System.Drawing.Point(10, 90);
            this.senderAddressLabel.Name = "senderAddressLabel";
            this.senderAddressLabel.Size = new System.Drawing.Size(50, 16);
            this.senderAddressLabel.TabIndex = 4;
            this.senderAddressLabel.Text = "Địa chỉ:";
            // 
            // senderAddressTextBox
            // 
            this.senderAddressTextBox.Location = new System.Drawing.Point(130, 90);
            this.senderAddressTextBox.Name = "senderAddressTextBox";
            this.senderAddressTextBox.Size = new System.Drawing.Size(230, 22);
            this.senderAddressTextBox.TabIndex = 5;
            // 
            // receiverGroup
            // 
            this.receiverGroup.Controls.Add(this.receiverPhoneLabel);
            this.receiverGroup.Controls.Add(this.receiverPhoneTextBox);
            this.receiverGroup.Controls.Add(this.receiverNameLabel);
            this.receiverGroup.Controls.Add(this.receiverNameTextBox);
            this.receiverGroup.Controls.Add(this.receiverAddressLabel);
            this.receiverGroup.Controls.Add(this.receiverAddressTextBox);
            this.receiverGroup.Location = new System.Drawing.Point(4, 230);
            this.receiverGroup.Name = "receiverGroup";
            this.receiverGroup.Size = new System.Drawing.Size(380, 150);
            this.receiverGroup.TabIndex = 2;
            this.receiverGroup.TabStop = false;
            this.receiverGroup.Text = "Người nhận";
            // 
            // receiverPhoneLabel
            // 
            this.receiverPhoneLabel.AutoSize = true;
            this.receiverPhoneLabel.Location = new System.Drawing.Point(10, 30);
            this.receiverPhoneLabel.Name = "receiverPhoneLabel";
            this.receiverPhoneLabel.Size = new System.Drawing.Size(88, 16);
            this.receiverPhoneLabel.TabIndex = 0;
            this.receiverPhoneLabel.Text = "Số điện thoại:";
            // 
            // receiverPhoneTextBox
            // 
            this.receiverPhoneTextBox.Location = new System.Drawing.Point(130, 30);
            this.receiverPhoneTextBox.Name = "receiverPhoneTextBox";
            this.receiverPhoneTextBox.Size = new System.Drawing.Size(230, 22);
            this.receiverPhoneTextBox.TabIndex = 1;
            // 
            // receiverNameLabel
            // 
            this.receiverNameLabel.AutoSize = true;
            this.receiverNameLabel.Location = new System.Drawing.Point(10, 60);
            this.receiverNameLabel.Name = "receiverNameLabel";
            this.receiverNameLabel.Size = new System.Drawing.Size(49, 16);
            this.receiverNameLabel.TabIndex = 2;
            this.receiverNameLabel.Text = "Họ tên:";
            // 
            // receiverNameTextBox
            // 
            this.receiverNameTextBox.Location = new System.Drawing.Point(130, 60);
            this.receiverNameTextBox.Name = "receiverNameTextBox";
            this.receiverNameTextBox.Size = new System.Drawing.Size(230, 22);
            this.receiverNameTextBox.TabIndex = 3;
            // 
            // receiverAddressLabel
            // 
            this.receiverAddressLabel.AutoSize = true;
            this.receiverAddressLabel.Location = new System.Drawing.Point(10, 90);
            this.receiverAddressLabel.Name = "receiverAddressLabel";
            this.receiverAddressLabel.Size = new System.Drawing.Size(50, 16);
            this.receiverAddressLabel.TabIndex = 4;
            this.receiverAddressLabel.Text = "Địa chỉ:";
            // 
            // receiverAddressTextBox
            // 
            this.receiverAddressTextBox.Location = new System.Drawing.Point(130, 90);
            this.receiverAddressTextBox.Name = "receiverAddressTextBox";
            this.receiverAddressTextBox.Size = new System.Drawing.Size(230, 22);
            this.receiverAddressTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(95, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiaChi
            // 
            this.ClientSize = new System.Drawing.Size(396, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiverGroup);
            this.Controls.Add(this.senderGroup);
            this.Name = "DiaChi";
            this.Text = "Địa Chỉ";
            this.senderGroup.ResumeLayout(false);
            this.senderGroup.PerformLayout();
            this.receiverGroup.ResumeLayout(false);
            this.receiverGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox senderGroup;
        private Label senderPhoneLabel;
        private TextBox senderPhoneTextBox;
        private Label senderNameLabel;
        private TextBox senderNameTextBox;
        private Label senderAddressLabel;
        private TextBox senderAddressTextBox;
        private GroupBox receiverGroup;
        private Label receiverPhoneLabel;
        private TextBox receiverPhoneTextBox;
        private Label receiverNameLabel;
        private TextBox receiverNameTextBox;
        private Label receiverAddressLabel;
        private TextBox receiverAddressTextBox;
        private Button button1;
    }
}