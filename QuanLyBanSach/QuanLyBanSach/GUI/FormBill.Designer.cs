
namespace QuanLyBanSach
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bthCustomerSearch = new System.Windows.Forms.Button();
            this.txbCheckInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCustomerCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkOderDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOrderCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.dtgvListBookSelected = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txbTotalMoney = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMonneyText = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbBookPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nmBookAmount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbPriceUnit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbIntoMoney = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbBookStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbBookCode = new System.Windows.Forms.TextBox();
            this.lbReadNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.lbStaffCode = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBookSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(512, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bthCustomerSearch);
            this.groupBox1.Controls.Add(this.txbCheckInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbCustomerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCustomerCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpkOderDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbOrderCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1427, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // bthCustomerSearch
            // 
            this.bthCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("bthCustomerSearch.Image")));
            this.bthCustomerSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthCustomerSearch.Location = new System.Drawing.Point(1288, 62);
            this.bthCustomerSearch.Name = "bthCustomerSearch";
            this.bthCustomerSearch.Size = new System.Drawing.Size(104, 33);
            this.bthCustomerSearch.TabIndex = 8;
            this.bthCustomerSearch.Text = "Chọn";
            this.bthCustomerSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthCustomerSearch.UseVisualStyleBackColor = true;
            this.bthCustomerSearch.Click += new System.EventHandler(this.bthCustomerSearch_Click);
            // 
            // txbCheckInfo
            // 
            this.txbCheckInfo.Location = new System.Drawing.Point(1053, 30);
            this.txbCheckInfo.Name = "txbCheckInfo";
            this.txbCheckInfo.Size = new System.Drawing.Size(339, 27);
            this.txbCheckInfo.TabIndex = 6;
            this.txbCheckInfo.TextChanged += new System.EventHandler(this.txbCheckInfo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nhập email hoặc SĐT:";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Enabled = false;
            this.txbCustomerName.Location = new System.Drawing.Point(997, 100);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(395, 27);
            this.txbCustomerName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(794, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên khách hàng:";
            // 
            // txbCustomerCode
            // 
            this.txbCustomerCode.Enabled = false;
            this.txbCustomerCode.Location = new System.Drawing.Point(997, 67);
            this.txbCustomerCode.Name = "txbCustomerCode";
            this.txbCustomerCode.Size = new System.Drawing.Size(274, 27);
            this.txbCustomerCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã khách hàng:";
            // 
            // dtpkOderDay
            // 
            this.dtpkOderDay.Location = new System.Drawing.Point(169, 69);
            this.dtpkOderDay.Name = "dtpkOderDay";
            this.dtpkOderDay.Size = new System.Drawing.Size(414, 27);
            this.dtpkOderDay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán:";
            // 
            // txbOrderCode
            // 
            this.txbOrderCode.Location = new System.Drawing.Point(169, 36);
            this.txbOrderCode.Name = "txbOrderCode";
            this.txbOrderCode.Size = new System.Drawing.Size(414, 27);
            this.txbOrderCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.pbBookImage);
            this.groupBox3.Controls.Add(this.dtgvListBookSelected);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1427, 405);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giỏ hàng";
            // 
            // pbBookImage
            // 
            this.pbBookImage.Location = new System.Drawing.Point(1124, 21);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(297, 378);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 1;
            this.pbBookImage.TabStop = false;
            // 
            // dtgvListBookSelected
            // 
            this.dtgvListBookSelected.AllowUserToAddRows = false;
            this.dtgvListBookSelected.AllowUserToDeleteRows = false;
            this.dtgvListBookSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListBookSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBookSelected.Location = new System.Drawing.Point(6, 21);
            this.dtgvListBookSelected.Name = "dtgvListBookSelected";
            this.dtgvListBookSelected.ReadOnly = true;
            this.dtgvListBookSelected.RowHeadersWidth = 51;
            this.dtgvListBookSelected.RowTemplate.Height = 24;
            this.dtgvListBookSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListBookSelected.Size = new System.Drawing.Size(1112, 378);
            this.dtgvListBookSelected.TabIndex = 0;
            this.dtgvListBookSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListBookSelected_CellClick);
            this.dtgvListBookSelected.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListBookSelected_CellValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(32, 846);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tổng tiền:";
            // 
            // txbTotalMoney
            // 
            this.txbTotalMoney.Enabled = false;
            this.txbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalMoney.Location = new System.Drawing.Point(165, 843);
            this.txbTotalMoney.Name = "txbTotalMoney";
            this.txbTotalMoney.Size = new System.Drawing.Size(200, 27);
            this.txbTotalMoney.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(35, 888);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Bằng chữ:";
            // 
            // lbMonneyText
            // 
            this.lbMonneyText.AutoSize = true;
            this.lbMonneyText.Location = new System.Drawing.Point(161, 671);
            this.lbMonneyText.Name = "lbMonneyText";
            this.lbMonneyText.Size = new System.Drawing.Size(0, 17);
            this.lbMonneyText.TabIndex = 7;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateOrder.Image")));
            this.btnCreateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateOrder.Location = new System.Drawing.Point(1123, 861);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(153, 41);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Tạo hóa đơn";
            this.btnCreateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.White;
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOrder.Image")));
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOrder.Location = new System.Drawing.Point(1285, 861);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(162, 41);
            this.btnCancelOrder.TabIndex = 5;
            this.btnCancelOrder.Text = "Hủy hóa đơn";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã sách:";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSearch.Image")));
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductSearch.Location = new System.Drawing.Point(411, 40);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(87, 33);
            this.btnProductSearch.TabIndex = 1;
            this.btnProductSearch.Text = "Chọn";
            this.btnProductSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đơn giá:";
            // 
            // txbBookPrice
            // 
            this.txbBookPrice.Enabled = false;
            this.txbBookPrice.Location = new System.Drawing.Point(169, 76);
            this.txbBookPrice.Name = "txbBookPrice";
            this.txbBookPrice.Size = new System.Drawing.Size(329, 27);
            this.txbBookPrice.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tên sách:";
            // 
            // txbBookName
            // 
            this.txbBookName.Enabled = false;
            this.txbBookName.Location = new System.Drawing.Point(673, 40);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(310, 27);
            this.txbBookName.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Số lượng:";
            // 
            // nmBookAmount
            // 
            this.nmBookAmount.Location = new System.Drawing.Point(673, 77);
            this.nmBookAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBookAmount.Name = "nmBookAmount";
            this.nmBookAmount.Size = new System.Drawing.Size(213, 27);
            this.nmBookAmount.TabIndex = 5;
            this.nmBookAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBookAmount.ValueChanged += new System.EventHandler(this.nmBookAmount_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1107, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Đơn vị tính:";
            // 
            // cbbPriceUnit
            // 
            this.cbbPriceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPriceUnit.FormattingEnabled = true;
            this.cbbPriceUnit.Items.AddRange(new object[] {
            "VND",
            "USD",
            "YÊN"});
            this.cbbPriceUnit.Location = new System.Drawing.Point(1209, 40);
            this.cbbPriceUnit.Name = "cbbPriceUnit";
            this.cbbPriceUnit.Size = new System.Drawing.Size(183, 28);
            this.cbbPriceUnit.TabIndex = 6;
            this.cbbPriceUnit.SelectedIndexChanged += new System.EventHandler(this.cbbPriceUnit_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1013, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Thành tiền:";
            // 
            // txbIntoMoney
            // 
            this.txbIntoMoney.Enabled = false;
            this.txbIntoMoney.Location = new System.Drawing.Point(1117, 79);
            this.txbIntoMoney.Name = "txbIntoMoney";
            this.txbIntoMoney.Size = new System.Drawing.Size(275, 27);
            this.txbIntoMoney.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(627, 121);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(122, 40);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(789, 121);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(115, 40);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txbBookStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbBookCode);
            this.groupBox2.Controls.Add(this.btnDeleteBook);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Controls.Add(this.txbIntoMoney);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbbPriceUnit);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nmBookAmount);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbBookName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbBookPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnProductSearch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1427, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // txbBookStatus
            // 
            this.txbBookStatus.Enabled = false;
            this.txbBookStatus.Location = new System.Drawing.Point(169, 109);
            this.txbBookStatus.Name = "txbBookStatus";
            this.txbBookStatus.Size = new System.Drawing.Size(242, 27);
            this.txbBookStatus.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tình trạng:";
            // 
            // txbBookCode
            // 
            this.txbBookCode.Location = new System.Drawing.Point(169, 40);
            this.txbBookCode.Name = "txbBookCode";
            this.txbBookCode.Size = new System.Drawing.Size(236, 27);
            this.txbBookCode.TabIndex = 0;
            this.txbBookCode.TextChanged += new System.EventHandler(this.txbBookCode_TextChanged);
            // 
            // lbReadNumber
            // 
            this.lbReadNumber.AutoSize = true;
            this.lbReadNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbReadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadNumber.ForeColor = System.Drawing.Color.Navy;
            this.lbReadNumber.Location = new System.Drawing.Point(161, 885);
            this.lbReadNumber.Name = "lbReadNumber";
            this.lbReadNumber.Size = new System.Drawing.Size(61, 17);
            this.lbReadNumber.TabIndex = 8;
            this.lbReadNumber.Text = "label18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhân viên:";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lbStaffName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.ForeColor = System.Drawing.Color.Blue;
            this.lbStaffName.Location = new System.Drawing.Point(169, 13);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(194, 35);
            this.lbStaffName.TabIndex = 10;
            this.lbStaffName.Text = "Tên nhân viên";
            // 
            // lbStaffCode
            // 
            this.lbStaffCode.AutoSize = true;
            this.lbStaffCode.BackColor = System.Drawing.Color.Transparent;
            this.lbStaffCode.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffCode.ForeColor = System.Drawing.Color.Blue;
            this.lbStaffCode.Location = new System.Drawing.Point(167, 47);
            this.lbStaffCode.Name = "lbStaffCode";
            this.lbStaffCode.Size = new System.Drawing.Size(188, 35);
            this.lbStaffCode.TabIndex = 12;
            this.lbStaffCode.Text = "Mã nhân viên";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(4, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 35);
            this.label18.TabIndex = 11;
            this.label18.Text = "Mã:";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1459, 920);
            this.Controls.Add(this.lbStaffCode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbStaffName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbReadNumber);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lbMonneyText);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txbTotalMoney);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBill_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBookSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bthCustomerSearch;
        private System.Windows.Forms.TextBox txbCheckInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCustomerCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkOderDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOrderCode;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvListBookSelected;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbTotalMoney;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbMonneyText;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbBookPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmBookAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbPriceUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbIntoMoney;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbBookCode;
        private System.Windows.Forms.TextBox txbBookStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbReadNumber;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label lbStaffCode;
        private System.Windows.Forms.Label label18;
    }
}