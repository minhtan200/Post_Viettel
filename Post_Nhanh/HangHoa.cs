using MongoDB.Driver;
using Post_Nhanh.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Post_Nhanh
{
    public partial class HangHoa : Form
    {
        private readonly IMongoCollection<PostalItems> _postalItemsCollection;
        private readonly IMongoDatabase database;
        private int productCount = 0;
        private TextBox senderAddressTextBox;
        private TextBox receiverAddressTextBox;

        public HangHoa()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("ViettelPost");
            _postalItemsCollection = database.GetCollection<PostalItems>("PostalItems");

            // Initialize TextBox controls for sender and receiver addresses
            senderAddressTextBox = new TextBox();
            receiverAddressTextBox = new TextBox();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            productCount++; // Increment product count for each button click

            // Create a new GroupBox for the new product
            GroupBox groupBoxProduct = new GroupBox
            {
                Name = "groupBoxProduct" + productCount,
                Text = "Thông tin sản phẩm " + productCount,
                Location = new Point(10, (productCount - 1) * 200), // Adjust location as necessary
                Size = new Size(220, 180) // Adjust size as necessary
            };

            // Create TextBox for product name
            TextBox textBoxTenSP = CreateTextBox("textBoxTenSP" + productCount, "Nhập tên sản phẩm thứ " + productCount, new Point(10, 30));

            // Create other TextBox controls for weight, length, height, etc.
            TextBox textBoxWeight = CreateTextBox("textBoxWeight" + productCount, "Nhập trọng lượng sản phẩm thứ " + productCount, new Point(10, 70));
            TextBox textBoxLength = CreateTextBox("textBoxLength" + productCount, "Nhập chiều dài sản phẩm thứ " + productCount, new Point(10, 110));
            TextBox textBoxHeight = CreateTextBox("textBoxHeight" + productCount, "Nhập chiều cao sản phẩm thứ " + productCount, new Point(10, 150));

            // Add TextBox controls to the new GroupBox
            groupBoxProduct.Controls.Add(textBoxTenSP);
            groupBoxProduct.Controls.Add(textBoxWeight);
            groupBoxProduct.Controls.Add(textBoxLength);
            groupBoxProduct.Controls.Add(textBoxHeight);

            // Add the new GroupBox to the form (or a parent container)
            this.Controls.Add(groupBoxProduct);
        }

        private TextBox CreateTextBox(string name, string placeholder, Point location)
        {
            TextBox textBox = new TextBox
            {
                Name = name,
                Location = location,
                Size = new Size(200, 30) // Adjust size as necessary
            };
            AddPlaceholder(textBox, placeholder);
            return textBox;
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray; // Set placeholder color
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black; // Change to normal text color
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray; // Change back to placeholder color
                }
            };
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Allow multiple file selection
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Image file filter

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Clear previous images before displaying new ones
                    ClearImages();

                    // Load images one by one
                    for (int i = 0; i < openFileDialog.FileNames.Length && i < 2; i++)
                    {
                        LoadImage(i == 0 ? pictureBox1 : pictureBox2, openFileDialog.FileNames[i]);
                    }
                }
            }
        }

        private void ClearImages()
        {
            // Dispose of previous images and clear PictureBox
            DisposeImage(pictureBox1);
            DisposeImage(pictureBox2);
        }

        private void DisposeImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose(); // Dispose of previous image to free memory
                pictureBox.Image = null; // Clear PictureBox
            }
        }

        private void LoadImage(PictureBox pictureBox, string filePath)
        {
            try
            {
                using (Image tempImage = Image.FromFile(filePath))
                {
                    // Create a new bitmap to avoid memory issues
                    pictureBox.Image = new Bitmap(tempImage);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Change this to control how the image is displayed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }



        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            // Clear images and dispose to free memory
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose(); // Dispose of the image to free memory
                pictureBox1.Image = null; // Clear PictureBox
            }
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose(); // Dispose of the image to free memory
                pictureBox2.Image = null; // Clear PictureBox
            }
        }

        private async void buttonTiepTuc_Click(object sender, EventArgs e)
        {
            double totalWeight = 0;
            double totalValue = 0;

            // Tính toán trọng lượng và giá trị tổng
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    string productName = string.Empty;
                    double? length = null, weight = null, height = null;

                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is TextBox textBox)
                        {
                            switch (textBox.Name)
                            {
                                case string name when name.StartsWith("textBoxTenSP"):
                                    productName = textBox.Text;
                                    break;
                                case string name when name.StartsWith("textBoxLength"):
                                    length = ParseNullableDouble(textBox.Text);
                                    break;
                                case string name when name.StartsWith("textBoxWeight"):
                                    weight = ParseNullableDouble(textBox.Text);
                                    break;
                                case string name when name.StartsWith("textBoxHeight"):
                                    height = ParseNullableDouble(textBox.Text);
                                    break;
                            }
                        }
                    }

                    if (length.HasValue && weight.HasValue && height.HasValue)
                    {
                        totalWeight += (length.Value * weight.Value * height.Value); // Cách tính trọng lượng
                        totalValue += weight.Value; // Ví dụ giá trị
                    }
                }
            }

            // Tính toán cước phí
            double ratePerKg = 10; // Định nghĩa tỷ lệ cước phí mỗi kg
            double shippingCost = totalWeight * ratePerKg;

            // Tính toán các cước phí khác
            double tietkiemmCost = shippingCost; // Cước phí tiết kiệm
            double nhanhCost = shippingCost * 1.1; // Cước phí nhanh (10% cao hơn)
            double hoaTocCost = shippingCost * 1.2; // Cước phí hoả tốc (20% cao hơn)

            // Tạo đối tượng ToalCuocPhi
            ToalCuocPhi cuocPhi = new ToalCuocPhi
            {
                TotalWeight = totalWeight,
                TotalValue = totalValue,
                ShippingCost = shippingCost,
                SenderAddress = senderAddressTextBox.Text,
                ReceiverAddress = receiverAddressTextBox.Text,
                TietKiemCost = tietkiemmCost,
                NhanhCost = nhanhCost,
                HoaTocCost = hoaTocCost
            };

            // Lưu thông tin cước phí vào MongoDB
            var cuocPhiCollection = database.GetCollection<ToalCuocPhi>("CuocPhi");
            await cuocPhiCollection.InsertOneAsync(cuocPhi);

            MessageBox.Show("Thông tin đã được lưu thành công!");

            // Chuyển sang form CuocPhi và truyền thông tin
            CuocPhi cp = new CuocPhi
            {
                TietKiemCost = tietkiemmCost,
                NhanhCost = nhanhCost,
                HoaTocCost = hoaTocCost,
                SenderAddress = senderAddressTextBox.Text,
                ReceiverAddress = receiverAddressTextBox.Text
            };

            cp.Show(); // Mở form CuocPhi
            this.Hide(); // Ẩn form hiện tại
        }

        private double? ParseNullableDouble(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? (double?)null : double.Parse(text);
        }

        private void ClearInputs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is TextBox textBox)
                        {
                            textBox.Clear();
                        }
                    }
                }
            }
            // Clear PictureBox images
            buttonDeleteImage.PerformClick();
        }

        private void textBoxTotalWeight_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalWeight();
        }

        private void textBoxTotalGT_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        private void UpdateTotals()
        {
            double totalWeight = 0;
            double totalValue = 0;

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    double weight = 0;
                    double gt = 0;
                    double sl = 0;

                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is TextBox textBox)
                        {
                            // Assuming textBoxGT is for price/value, textBoxSL is for quantity, and textBoxWeight is for weight
                            if (textBox.Name.StartsWith("textBoxGT"))
                            {
                                gt = ParseNullableDouble(textBox.Text) ?? 0;
                            }
                            else if (textBox.Name.StartsWith("textBoxSL"))
                            {
                                sl = ParseNullableDouble(textBox.Text) ?? 0;
                            }
                            else if (textBox.Name.StartsWith("textBoxWeight"))
                            {
                                weight = ParseNullableDouble(textBox.Text) ?? 0;
                            }
                        }
                    }

                    // Calculate total weight and total value
                    totalWeight += weight *sl ; // Total Weight
                    totalValue += gt * sl; // Total Value

                    // Debugging outputs
                    Console.WriteLine($"Weight: {weight}, Quantity: {sl}, Total Weight: {totalWeight}");
                    Console.WriteLine($"Value: {gt}, Quantity: {sl}, Total Value: {totalValue}");
                }
            }

            // Update the total TextBoxes
            textBoxTotalWeight.Text = totalWeight.ToString("F2"); // Format as needed
            textBoxTotalGT.Text = totalValue.ToString("F2"); // Format as needed

            // Additional debugging to confirm totals are updated
            Console.WriteLine($"Final Total Weight: {textBoxTotalWeight.Text}, Final Total Value: {textBoxTotalGT.Text}");
        }
        private void UpdateTotalWeight()
        {
            // Parse the weight input and set it to textBoxTotalWeight
            double weight = ParseNullableDouble(textBoxWeight.Text) ?? 0;
            textBoxTotalWeight.Text = weight.ToString("F2"); // Display with 2 decimal places
        }
    }
}
