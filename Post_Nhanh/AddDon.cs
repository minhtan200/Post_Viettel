using MongoDB.Driver;
using MongoDB.Driver.Core.Misc;
using Post_Nhanh.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Post_Nhanh
{
    public partial class AddDon : Form
    {
        // Biến lưu tạm các thông tin từ các tab
        private SenderReceiverInfo _senderInfo;
        private SenderReceiverInfo _receiverInfo;
        private ProductInfo _productInfo;
        private ShippingInfo _shippingInfo;
        private string name;
        private string phone;
        private int productCount = 1; // Đếm số sản phẩm
        private int currentY = 0; // Vị trí Y của GroupBox
        private GroupBox groupBoxHangHoa;

        private IMongoCollection<DonHang> _donHangCollection;

        public AddDon()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            _donHangCollection = database.GetCollection<DonHang>("DonHang");
            // Gán sự kiện TextChanged cho các TextBox
            textBoxGT.TextChanged += textBoxGT_TextChanged;
            textBoxSL.TextChanged += textBoxSL_TextChanged;
            textBoxWeight.TextChanged += textBoxWeight_TextChanged;
            senderPhoneTextBox.TextChanged += senderPhoneTextBox_TextChanged;
            receiverPhoneTextBox.TextChanged += receiverPhoneTextBox_TextChanged;
            radioButtonTietKiem.CheckedChanged += radioButtonTietKiem_CheckedChanged;
            radioButtonNhanh.CheckedChanged += radioButtonNhanh_CheckedChanged;
            radioButtonHoaToc.CheckedChanged += radioButtonHoaToc_CheckedChanged;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            chkBaoHiem.CheckedChanged += chkBaoHiem_CheckedChanged;
            chkDongKiem.CheckedChanged += chkDongKiem_CheckedChanged;
            // Khởi tạo các TextBox cho thông tin cần thiết
        }




        private void buttonAddressTiepTuc_Click(object sender, EventArgs e)
        {
            string senderName = senderNameTextBox.Text;
            string receiverName = receiverNameTextBox.Text;
            // Kiểm tra xem các trường thông tin địa chỉ đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(senderPhoneTextBox.Text) || string.IsNullOrWhiteSpace(senderNameTextBox.Text) || string.IsNullOrWhiteSpace(senderAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(receiverPhoneTextBox.Text) || string.IsNullOrWhiteSpace(receiverNameTextBox.Text) || string.IsNullOrWhiteSpace(receiverAddressTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người gửi và người nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra số điện thoại của người gửi
            if (!IsValidPhoneNumber(senderPhoneTextBox.Text))
            {
                MessageBox.Show("Số điện thoại người gửi không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại của người nhận
            if (!IsValidPhoneNumber(receiverPhoneTextBox.Text))
            {
                MessageBox.Show("Số điện thoại người nhận không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra nếu tên người gửi và người nhận hợp lệ
            if (!IsValidName(senderName) || !IsValidName(receiverName))
            {
                MessageBox.Show("Họ tên không được chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lưu thông tin địa chỉ vào biến tạm
            _senderInfo = new SenderReceiverInfo
            {
                PhoneNumber = senderPhoneTextBox.Text,
                Name = senderNameTextBox.Text,
                Address = senderAddressTextBox.Text
            };

            _receiverInfo = new SenderReceiverInfo
            {
                PhoneNumber = receiverPhoneTextBox.Text,
                Name = receiverNameTextBox.Text,
                Address = receiverAddressTextBox.Text
            };

            // Chuyển sang tab Hàng Hóa
            tabControl.SelectedTab = tabHangHoa;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra độ dài và các ký tự của số điện thoại (chỉ cho phép số, không cho phép ký tự khác)
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
        private bool IsValidName(string name)
        {
            // Kiểm tra nếu có bất kỳ ký tự số nào trong tên
            return !name.Any(char.IsDigit);
        }

        // Sự kiện khi bấm tiếp tục ở tab Hàng Hóa
        private void buttonProductTiepTuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem thông tin hàng hóa đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(textBoxTenSP.Text) || string.IsNullOrWhiteSpace(textBoxGT.Text) ||
                string.IsNullOrWhiteSpace(textBoxSL.Text) || string.IsNullOrWhiteSpace(textBoxWeight.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra và chuyển đổi các giá trị số
            if (!decimal.TryParse(textBoxGT.Text, out decimal productValue) ||
                !int.TryParse(textBoxSL.Text, out int quantity) ||
                !decimal.TryParse(textBoxWeight.Text, out decimal weight))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá trị, số lượng và trọng lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra và chuyển đổi chiều dài và chiều rộng (nếu có)
            decimal length = 0, width = 0;
            if (!string.IsNullOrWhiteSpace(textBoxLenght.Text) && !decimal.TryParse(textBoxLenght.Text, out length))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho chiều dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBoxWidth.Text) && !decimal.TryParse(textBoxWidth.Text, out width))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho chiều rộng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu thông tin hàng hóa vào biến tạm
            _productInfo = new ProductInfo
            {
                ProductName = textBoxTenSP.Text,
                ProductValue = productValue,
                Quantity = quantity,
                Weight = weight,
                TotalValue = productValue * quantity,
                TotalWeight = weight,
                Length = length,
                Width = width,
                Image1 = pictureBox1.ImageLocation,
                Image2 = pictureBox2.ImageLocation
            };

            // Chuyển sang tab Cước Phí
            tabControl.SelectedTab = tabCuocPhi;
        }

        // Hàm chuyển về Trang Chủ
        private void ReturnToHomePage(string name, string phone)
        {
            // Giả định trang chính có hai tham số string trong constructor, cần cung cấp đúng tham số
            TrangChu trangchu = new TrangChu(name, phone);
            trangchu.Show();
            this.Close(); // Đóng form hiện tại
        }

        // Sự kiện xác nhận cước phí
        private void buttonXacNhanCuocPhi_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra và khởi tạo thông tin người gửi
                if (_senderInfo == null)
                {
                    _senderInfo = new SenderReceiverInfo
                    {
                        PhoneNumber = senderPhoneTextBox.Text,
                        Name = senderNameTextBox.Text,
                        Address = senderAddressTextBox.Text
                    };
                }

                // Kiểm tra và khởi tạo thông tin người nhận
                if (_receiverInfo == null)
                {
                    _receiverInfo = new SenderReceiverInfo
                    {
                        PhoneNumber = receiverPhoneTextBox.Text,
                        Name = receiverNameTextBox.Text,
                        Address = receiverAddressTextBox.Text
                    };
                }

                // Kiểm tra và khởi tạo thông tin sản phẩm
                if (_productInfo == null)
                {
                    if (!decimal.TryParse(textBoxGT.Text, out decimal productValue) ||
                        !int.TryParse(textBoxSL.Text, out int quantity) ||
                        !decimal.TryParse(textBoxWeight.Text, out decimal weight) ||
                        !decimal.TryParse(textBoxLenght.Text, out decimal length) ||
                        !decimal.TryParse(textBoxWidth.Text, out decimal width))
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng số cho các thông tin hàng hóa.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _productInfo = new ProductInfo
                    {
                        ProductName = textBoxTenSP.Text,
                        ProductValue = productValue,
                        Quantity = quantity,
                        Weight = weight,
                        TotalValue = productValue * quantity,
                        TotalWeight = weight,
                        Length = length,
                        Width = width,
                        Image1 = pictureBox1?.ImageLocation,
                        Image2 = pictureBox2?.ImageLocation
                    };
                }

                // Kiểm tra dịch vụ vận chuyển đã được chọn chưa
                if (!radioButtonTietKiem.Checked && !radioButtonNhanh.Checked && !radioButtonHoaToc.Checked)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ vận chuyển.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Khởi tạo thông tin vận chuyển
                _shippingInfo = new ShippingInfo
                {
                    ShippingService = radioButtonTietKiem.Checked ? "Tiết kiệm" :
                                      radioButtonNhanh.Checked ? "Nhanh" : "Hỏa tốc",
                    IsSpecialGoods = checkBox2.Checked,
                    AdditionalService = new AdditionalService
                    {
                        InsuranceAndDeclaredValue = chkBaoHiem.Checked,
                        Inspection = chkDongKiem.Checked
                    },
                    OrderNote = txtGhichu.Text
                };

                // Tính tổng tiền và gán vào _shippingInfo
                _shippingInfo.TotalOrderCost = CalculateTotalOrderCostPhi();

                // Hiển thị tổng tiền vào textbox
                textBox1.Text = _shippingInfo.TotalOrderCost.ToString("C"); // C định dạng tiền tệ

                // Tạo mã đơn hàng (orderCode)
                string orderCode = DateTime.Now.ToString("yyyyMMddHHmmss");

                // Tạo đối tượng đơn hàng mới
                var donHang = new DonHang
                {
                    OrderCode = orderCode, // Gán mã đơn hàng
                    Sender = _senderInfo,
                    Receiver = _receiverInfo,
                    Product = _productInfo,
                    Shipping = _shippingInfo,
                    OrderDate = DateTime.Now
                };

                // Lưu vào MongoDB
                _donHangCollection.InsertOne(donHang); // Truy vấn để lưu đơn hàng vào collection
                MessageBox.Show("Lưu đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị form HoanThanh với chi tiết đơn hàng
                string recipientInfo = $"{_receiverInfo.Name}"; // Format recipient info
                string receiverAddress = $"{_receiverInfo.Address}";
                string receiverPhone = $"{_receiverInfo.PhoneNumber}";

                HoanThanh hoanThanhForm = new HoanThanh(orderCode, donHang.OrderDate, recipientInfo, receiverAddress, receiverPhone);
                hoanThanhForm.Show();

                // Ẩn hoặc đóng form hiện tại
                this.Hide(); // or this.Close();
            }
            catch (FormatException fx)
            {
                MessageBox.Show($"Lỗi định dạng dữ liệu: {fx.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Sự kiện hủy bỏ
        private void buttonHuyBoCuocPhi_Click_1(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ? Mọi thông tin sẽ không được lưu.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuyển về Trang Chủ
                ReturnToHomePage(name,phone);
            }
        }
        // Hàm tính tổng tiền đơn hàng dựa vào các yếu tố
        // Sửa lại phương thức tính tổng tiền để xử lý null
       

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
        // Hàm để tính tổng giá trị sản phẩm và khối lượng
        private void CalculateTotalValues()
        {
            // Kiểm tra nếu các giá trị trong textBox là hợp lệ
            if (decimal.TryParse(textBoxGT.Text, out decimal productValue) &&
                int.TryParse(textBoxSL.Text, out int quantity))
            {
                // Tính tổng giá trị sản phẩm
                decimal totalValue = productValue * quantity;
                textBoxTotalGT.Text = totalValue.ToString("C");

              
            }
            else
            {
                // Nếu có lỗi, xóa các giá trị hiện tại
                textBoxTotalGT.Text = string.Empty;

            }
        }
        private void CalculateTotalWeight()
        {
            // Kiểm tra nếu các giá trị trong textBox là hợp lệ
            if (
                decimal.TryParse(textBoxWeight.Text, out decimal weight))
            {
                

                // Tính tổng khối lượng sản phẩm
                textBoxTotalWeight.Text = weight.ToString();
            }
            else
            {
                
                textBoxTotalWeight.Text = string.Empty;
            }
        }
        private void textBoxTotalWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalGT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGT_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalValues();
        }

        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalValues();
        }

        

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalWeight();
        }

        private void senderPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = senderPhoneTextBox.Text;

            // Kiểm tra nếu input không phải là số hoặc độ dài không bằng 10
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{0,10}$"))
            {
                // Xóa ký tự không hợp lệ nếu nhập không phải số hoặc vượt quá 10 ký tự
                MessageBox.Show("Vui lòng nhập đúng định dạng số và số điện thoại phải có 10 chữ số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                senderPhoneTextBox.Text = phoneNumber.Remove(phoneNumber.Length - 1);
                senderPhoneTextBox.SelectionStart = senderPhoneTextBox.Text.Length; // Đặt lại con trỏ sau khi xóa ký tự
            }
        }

        private void receiverPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = receiverPhoneTextBox.Text;

            // Kiểm tra nếu input không phải là số hoặc độ dài không bằng 10
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{0,10}$"))
            {
                // Xóa ký tự không hợp lệ nếu nhập không phải số hoặc vượt quá 10 ký tự
                MessageBox.Show("Vui lòng nhập đúng định dạng số và số điện thoại phải có 10 chữ số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                receiverPhoneTextBox.Text = phoneNumber.Remove(phoneNumber.Length - 1);
                receiverPhoneTextBox.SelectionStart = receiverPhoneTextBox.Text.Length; // Đặt lại con trỏ sau khi xóa ký tự
            }
        }

        private void senderAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidName(senderNameTextBox.Text))
            {
                // Nếu tên không hợp lệ, có thể thêm thông báo lỗi hoặc thay đổi màu nền
                senderNameTextBox.BackColor = Color.LightCoral; // Ví dụ: đổi màu nền thành đỏ
            }
            else
            {
                senderNameTextBox.BackColor = Color.White; // Trả lại màu nền ban đầu nếu hợp lệ
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabHangHoa)
            {
                // Kiểm tra thông tin ở tab Địa Chỉ
                if (string.IsNullOrWhiteSpace(senderPhoneTextBox.Text) || string.IsNullOrWhiteSpace(senderNameTextBox.Text) || string.IsNullOrWhiteSpace(senderAddressTextBox.Text) ||
                    string.IsNullOrWhiteSpace(receiverPhoneTextBox.Text) || string.IsNullOrWhiteSpace(receiverNameTextBox.Text) || string.IsNullOrWhiteSpace(receiverAddressTextBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin người gửi và người nhận trước khi chuyển đến tab Hàng Hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; // Ngăn chuyển đổi tab
                }
            }
            else if (e.TabPage == tabCuocPhi)
            {
                // Kiểm tra thông tin ở tab Hàng Hóa
                if (string.IsNullOrWhiteSpace(textBoxTenSP.Text) || string.IsNullOrWhiteSpace(textBoxGT.Text) || string.IsNullOrWhiteSpace(textBoxSL.Text) ||
                    string.IsNullOrWhiteSpace(textBoxWeight.Text) || string.IsNullOrWhiteSpace(textBoxLenght.Text) || string.IsNullOrWhiteSpace(textBoxWidth.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa trước khi chuyển đến tab Cước Phí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; // Ngăn chuyển đổi tab
                }
            }
        }
        private decimal CalculateTotalOrderCostPhi()
        {
            // Ensure that product info is initialized
            if (_productInfo == null)
            {
                throw new InvalidOperationException("Thông tin sản phẩm chưa được khởi tạo");
            }

            // Base cost from product value and quantity
            decimal baseCost = _productInfo.TotalValue; // e.g., Giá trị sản phẩm x Số lượng

            // Determine shipping cost based on the selected option
            decimal shippingCost = 0;
            if (radioButtonTietKiem.Checked)
                shippingCost = 10; // Tiết kiệm
            else if (radioButtonNhanh.Checked)
                shippingCost = 20; // Nhanh
            else if (radioButtonHoaToc.Checked)
                shippingCost = 30; // Hỏa tốc

            // Special goods fee
            decimal specialGoodsFee = checkBox2.Checked ? 25 : 0; // Phí cho hàng hóa đặc biệt

            // Additional service fees
            decimal additionalServiceFee = (chkBaoHiem.Checked ? 15 : 0) + // Bảo hiểm
                                            (chkDongKiem.Checked ? 5: 0); // Đóng kiện

            // Return total cost
            return baseCost + shippingCost + specialGoodsFee + additionalServiceFee;
        }

       

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabCuocPhi)
            {
                // Hiển thị tổng giá trị đơn hàng vào textbox khi chuyển qua tab
                textBox1.Text = CalculateTotalOrderCostPhi().ToString("C");
                UpdateTotalOrderCost();
                // Hiển thị giá trị cước phí tương ứng vào các TextBox
                LoadShippingCosts();
            }
        }
        private void LoadShippingCosts()
        {
            // Đặt giá trị cước phí cho từng loại
            decimal shippingCostTietKiem = 10; // Ví dụ: giá cước tiết kiệm
            decimal shippingCostNhanh = 20; // Ví dụ: giá cước nhanh
            decimal shippingCostHoaToc = 30; // Ví dụ: giá cước hỏa tốc

            // Cập nhật giá trị vào các TextBox
            textBoxTietKiem.Text = shippingCostTietKiem.ToString("C");
            textBoxNhanh.Text = shippingCostNhanh.ToString("C");
            textBoxHoaToc.Text = shippingCostHoaToc.ToString("C");
        }
        private void UpdateTotalOrderCost()
        {
            if (_productInfo == null)
            {
                MessageBox.Show("Thông tin sản phẩm chưa được khởi tạo", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalCost = _productInfo.TotalValue;

            // Add shipping cost based on selected radio button
            if (radioButtonTietKiem.Checked)
                totalCost += 10;
            else if (radioButtonNhanh.Checked)
                totalCost += 20;
            else if (radioButtonHoaToc.Checked)
                totalCost += 30;

            // Add special goods fee
            if (checkBox2.Checked)
                totalCost += 25;

            // Add insurance fee
            if (chkBaoHiem.Checked)
                totalCost += 15;

            // Add inspection fee
            if (chkDongKiem.Checked)
                totalCost += 5;

            // Update the total cost display
            textBox1.Text = totalCost.ToString("C");
        }

        private void radioButtonTietKiem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void radioButtonNhanh_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void radioButtonHoaToc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void chkBaoHiem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void chkDongKiem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Xác định số lượng GroupBox hiện có (sản phẩm) để tính vị trí Y cho GroupBox mới
            int numberOfProducts = groupBoxProduct.Controls.OfType<GroupBox>().Count();

            // Tính toán vị trí Y cho GroupBox mới dựa trên số lượng sản phẩm hiện có
            int currentY = numberOfProducts * (102 + 10); // 102 là chiều cao của GroupBox, 10 là khoảng cách giữa các GroupBox

            // Tạo GroupBox mới cho sản phẩm
            GroupBox newGroupBox = new GroupBox
            {
                Location = new System.Drawing.Point(10, currentY), // Vị trí Y mới
                Size = new System.Drawing.Size(531, 102),
                TabStop = false,
                Text = $"Sản phẩm {numberOfProducts + 1}" // Tên GroupBox
            };

            // Nhân đôi các điều khiển từ groupBoxHangHoa
            foreach (Control control in groupBoxHangHoa.Controls)
            {
                if (control is Label labelControl)
                {
                    // Tạo Label mới
                    Label newLabel = new Label
                    {
                        Text = labelControl.Text,
                        Location = labelControl.Location,
                        AutoSize = true
                    };
                    newGroupBox.Controls.Add(newLabel);
                }
                else if (control is TextBox textBoxControl)
                {
                    // Tạo TextBox mới
                    TextBox newTextBox = new TextBox
                    {
                        Name = textBoxControl.Name + (numberOfProducts + 1), // Tên duy nhất cho TextBox
                        Location = textBoxControl.Location,
                        Size = textBoxControl.Size
                    };
                    newGroupBox.Controls.Add(newTextBox);
                }
            }

            // Thêm Label và TextBox cho khối lượng (Weight)
            Label newLabelWeight = new Label
            {
                Text = "Khối lượng (g)",
                Location = new System.Drawing.Point(327, 70),
                AutoSize = true
            };
            newGroupBox.Controls.Add(newLabelWeight);

            TextBox newTextBoxWeight = new TextBox
            {
                Name = "textBoxWeight" + (numberOfProducts + 1),
                Location = new System.Drawing.Point(420, 70),
                Size = new System.Drawing.Size(100, 22)
            };
            newGroupBox.Controls.Add(newTextBoxWeight);

            // Thêm GroupBox mới vào groupBoxProduct
            groupBoxProduct.Controls.Add(newGroupBox);

            // Điều chỉnh chiều cao của panelProduct để hiển thị tất cả các sản phẩm mới và bật thanh cuộn nếu cần
            panelProduct.AutoScroll = true;
            panelProduct.AutoScrollMinSize = new Size(0, currentY + newGroupBox.Height + 10);
        }
    }
}
