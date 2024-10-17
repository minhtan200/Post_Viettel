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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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

            // TabControl
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(380, 150);
            this.tabControl.TabIndex = 0;

            // TabPage1
            this.tabPage1.Text = "Địa Chỉ";
            this.tabPage1.UseVisualStyleBackColor = true;

            

            // Sender GroupBox
            this.senderGroup.Controls.Add(this.senderPhoneLabel);
            this.senderGroup.Controls.Add(this.senderPhoneTextBox);
            this.senderGroup.Controls.Add(this.senderNameLabel);
            this.senderGroup.Controls.Add(this.senderNameTextBox);
            this.senderGroup.Controls.Add(this.senderAddressLabel);
            this.senderGroup.Controls.Add(this.senderAddressTextBox);
            this.senderGroup.Location = new System.Drawing.Point(10, 170);
            this.senderGroup.Name = "senderGroup";
            this.senderGroup.Size = new System.Drawing.Size(380, 150);
            this.senderGroup.TabIndex = 1;
            this.senderGroup.TabStop = false;
            this.senderGroup.Text = "Người gửi";

            // Sender Phone Label
            this.senderPhoneLabel.AutoSize = true;
            this.senderPhoneLabel.Location = new System.Drawing.Point(10, 30);
            this.senderPhoneLabel.Name = "senderPhoneLabel";
            this.senderPhoneLabel.Size = new System.Drawing.Size(110, 17);
            this.senderPhoneLabel.Text = "Số điện thoại:";

            // Sender Phone TextBox
            this.senderPhoneTextBox.Location = new System.Drawing.Point(130, 30);
            this.senderPhoneTextBox.Size = new System.Drawing.Size(230, 22);

            // Sender Name Label
            this.senderNameLabel.AutoSize = true;
            this.senderNameLabel.Location = new System.Drawing.Point(10, 60);
            this.senderNameLabel.Text = "Họ tên:";

            // Sender Name TextBox
            this.senderNameTextBox.Location = new System.Drawing.Point(130, 60);
            this.senderNameTextBox.Size = new System.Drawing.Size(230, 22);

            // Sender Address Label
            this.senderAddressLabel.AutoSize = true;
            this.senderAddressLabel.Location = new System.Drawing.Point(10, 90);
            this.senderAddressLabel.Text = "Địa chỉ:";

            // Sender Address TextBox
            this.senderAddressTextBox.Location = new System.Drawing.Point(130, 90);
            this.senderAddressTextBox.Size = new System.Drawing.Size(230, 22);

            // Receiver GroupBox
            this.receiverGroup.Controls.Add(this.receiverPhoneLabel);
            this.receiverGroup.Controls.Add(this.receiverPhoneTextBox);
            this.receiverGroup.Controls.Add(this.receiverNameLabel);
            this.receiverGroup.Controls.Add(this.receiverNameTextBox);
            this.receiverGroup.Controls.Add(this.receiverAddressLabel);
            this.receiverGroup.Controls.Add(this.receiverAddressTextBox);
            this.receiverGroup.Location = new System.Drawing.Point(10, 330);
            this.receiverGroup.Name = "receiverGroup";
            this.receiverGroup.Size = new System.Drawing.Size(380, 150);
            this.receiverGroup.TabIndex = 2;
            this.receiverGroup.TabStop = false;
            this.receiverGroup.Text = "Người nhận";

            // Receiver Phone Label
            this.receiverPhoneLabel.AutoSize = true;
            this.receiverPhoneLabel.Location = new System.Drawing.Point(10, 30);
            this.receiverPhoneLabel.Text = "Số điện thoại:";

            // Receiver Phone TextBox
            this.receiverPhoneTextBox.Location = new System.Drawing.Point(130, 30);
            this.receiverPhoneTextBox.Size = new System.Drawing.Size(230, 22);

            // Receiver Name Label
            this.receiverNameLabel.AutoSize = true;
            this.receiverNameLabel.Location = new System.Drawing.Point(10, 60);
            this.receiverNameLabel.Text = "Họ tên:";

            // Receiver Name TextBox
            this.receiverNameTextBox.Location = new System.Drawing.Point(130, 60);
            this.receiverNameTextBox.Size = new System.Drawing.Size(230, 22);

            // Receiver Address Label
            this.receiverAddressLabel.AutoSize = true;
            this.receiverAddressLabel.Location = new System.Drawing.Point(10, 90);
            this.receiverAddressLabel.Text = "Địa chỉ:";

            // Receiver Address TextBox
            this.receiverAddressTextBox.Location = new System.Drawing.Point(130, 90);
            this.receiverAddressTextBox.Size = new System.Drawing.Size(230, 22);

            // Button1
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(130, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = false;

            // DiaChi Form
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiverGroup);
            this.Controls.Add(this.senderGroup);
            this.Controls.Add(this.tabControl);
            this.Name = "DiaChi";
            this.Text = "Địa Chỉ";
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
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