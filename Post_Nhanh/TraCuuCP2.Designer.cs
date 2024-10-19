using System;
using System.Drawing;
using System.Windows.Forms;

namespace Post_Nhanh
{
    public partial class TraCuuCP2 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFromToWeight;
        private System.Windows.Forms.Label lblFromTo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TextBox txtService1;
        private System.Windows.Forms.TextBox txtService2;
        private System.Windows.Forms.TextBox txtService3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFromToWeight = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblFromTo = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtService1 = new System.Windows.Forms.TextBox();
            this.txtService2 = new System.Windows.Forms.TextBox();
            this.txtService3 = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.rbService1 = new System.Windows.Forms.RadioButton();
            this.rbService2 = new System.Windows.Forms.RadioButton();
            this.rbService3 = new System.Windows.Forms.RadioButton();
            this.pnlHeader.SuspendLayout();
            this.pnlFromToWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(859, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(309, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kết quả tra cứu cước";
            // 
            // pnlFromToWeight
            // 
            this.pnlFromToWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFromToWeight.Controls.Add(this.textBox6);
            this.pnlFromToWeight.Controls.Add(this.textBox5);
            this.pnlFromToWeight.Controls.Add(this.lblFromTo);
            this.pnlFromToWeight.Controls.Add(this.lblWeight);
            this.pnlFromToWeight.Location = new System.Drawing.Point(12, 100);
            this.pnlFromToWeight.Name = "pnlFromToWeight";
            this.pnlFromToWeight.Size = new System.Drawing.Size(833, 173);
            this.pnlFromToWeight.TabIndex = 1;
            this.pnlFromToWeight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFromToWeight_Paint);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(205, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(533, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(205, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(533, 20);
            this.textBox5.TabIndex = 2;
            // 
            // lblFromTo
            // 
            this.lblFromTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFromTo.ForeColor = System.Drawing.Color.Black;
            this.lblFromTo.Location = new System.Drawing.Point(7, 17);
            this.lblFromTo.Name = "lblFromTo";
            this.lblFromTo.Size = new System.Drawing.Size(154, 23);
            this.lblFromTo.TabIndex = 0;
            this.lblFromTo.Text = "Gửi từ:";
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(7, 55);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(164, 23);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Khối lượng quy đổi:";
            // 
            // txtService1
            // 
            this.txtService1.BackColor = System.Drawing.Color.White;
            this.txtService1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtService1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtService1.ForeColor = System.Drawing.Color.Black;
            this.txtService1.Location = new System.Drawing.Point(12, 291);
            this.txtService1.Name = "txtService1";
            this.txtService1.ReadOnly = true;
            this.txtService1.Size = new System.Drawing.Size(453, 18);
            this.txtService1.TabIndex = 2;
            this.txtService1.Text = "Chuyển phát tiết kiệm hàng hóa";
            this.txtService1.TextChanged += new System.EventHandler(this.txtService1_TextChanged);
            // 
            // txtService2
            // 
            this.txtService2.BackColor = System.Drawing.Color.White;
            this.txtService2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtService2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtService2.ForeColor = System.Drawing.Color.Black;
            this.txtService2.Location = new System.Drawing.Point(12, 337);
            this.txtService2.Name = "txtService2";
            this.txtService2.ReadOnly = true;
            this.txtService2.Size = new System.Drawing.Size(360, 18);
            this.txtService2.TabIndex = 3;
            this.txtService2.Text = "Chuyển phát nhanh";
            // 
            // txtService3
            // 
            this.txtService3.BackColor = System.Drawing.Color.White;
            this.txtService3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtService3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtService3.ForeColor = System.Drawing.Color.Black;
            this.txtService3.Location = new System.Drawing.Point(12, 391);
            this.txtService3.Name = "txtService3";
            this.txtService3.ReadOnly = true;
            this.txtService3.Size = new System.Drawing.Size(360, 18);
            this.txtService3.TabIndex = 4;
            this.txtService3.Text = "TMDT Tiết Kiệm";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.Red;
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(239, 527);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(360, 50);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Tạo đơn hàng";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // rbService1
            // 
            this.rbService1.AutoSize = true;
            this.rbService1.Location = new System.Drawing.Point(378, 292);
            this.rbService1.Name = "rbService1";
            this.rbService1.Size = new System.Drawing.Size(50, 17);
            this.rbService1.TabIndex = 6;
            this.rbService1.TabStop = true;
            this.rbService1.Text = "Chọn";
            this.rbService1.UseVisualStyleBackColor = true;
            // 
            // rbService2
            // 
            this.rbService2.AutoSize = true;
            this.rbService2.Location = new System.Drawing.Point(378, 338);
            this.rbService2.Name = "rbService2";
            this.rbService2.Size = new System.Drawing.Size(50, 17);
            this.rbService2.TabIndex = 7;
            this.rbService2.TabStop = true;
            this.rbService2.Text = "Chọn";
            this.rbService2.UseVisualStyleBackColor = true;
            // 
            // rbService3
            // 
            this.rbService3.AutoSize = true;
            this.rbService3.Location = new System.Drawing.Point(378, 392);
            this.rbService3.Name = "rbService3";
            this.rbService3.Size = new System.Drawing.Size(50, 17);
            this.rbService3.TabIndex = 8;
            this.rbService3.TabStop = true;
            this.rbService3.Text = "Chọn";
            this.rbService3.UseVisualStyleBackColor = true;
            // 
            // TraCuuCP2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 600);
            this.Controls.Add(this.rbService1);
            this.Controls.Add(this.rbService2);
            this.Controls.Add(this.rbService3);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFromToWeight);
            this.Controls.Add(this.txtService1);
            this.Controls.Add(this.txtService2);
            this.Controls.Add(this.txtService3);
            this.Controls.Add(this.btnCreateOrder);
            this.Name = "TraCuuCP2";
            this.Text = "Tra cứu cước";
            this.Load += new System.EventHandler(this.TraCuuCP2_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFromToWeight.ResumeLayout(false);
            this.pnlFromToWeight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private RadioButton rbService1;
        private RadioButton rbService2;
        private RadioButton rbService3;
    }
}
