
namespace QuanLyBanSach
{
    partial class FormWarehouseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouseManager));
            this.btnExit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.dtgvBookInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbBookCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.nmBookAmount = new System.Windows.Forms.NumericUpDown();
            this.txbBookPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbBookPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbStatusBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBookCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReceiptSearch = new System.Windows.Forms.Button();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.pbBookImageReceipt = new System.Windows.Forms.PictureBox();
            this.dtgvDetailReceipt = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvListReceipt = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpkDayTo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.cbbNXBReceipt = new System.Windows.Forms.ComboBox();
            this.dtpkDayImport = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txbReceiptCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImageReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailReceipt)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListReceipt)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1389, 791);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 44);
            this.btnExit.TabIndex = 1000;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1514, 744);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý sách";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChooseImage);
            this.groupBox3.Controls.Add(this.pbBookImage);
            this.groupBox3.Controls.Add(this.dtgvBookInfo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1495, 406);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseImage.Image")));
            this.btnChooseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseImage.Location = new System.Drawing.Point(1266, 358);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(129, 42);
            this.btnChooseImage.TabIndex = 1;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbBookImage
            // 
            this.pbBookImage.Location = new System.Drawing.Point(1181, 26);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(308, 326);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 1;
            this.pbBookImage.TabStop = false;
            // 
            // dtgvBookInfo
            // 
            this.dtgvBookInfo.AllowUserToAddRows = false;
            this.dtgvBookInfo.AllowUserToDeleteRows = false;
            this.dtgvBookInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBookInfo.Location = new System.Drawing.Point(15, 26);
            this.dtgvBookInfo.Name = "dtgvBookInfo";
            this.dtgvBookInfo.ReadOnly = true;
            this.dtgvBookInfo.RowHeadersWidth = 51;
            this.dtgvBookInfo.RowTemplate.Height = 24;
            this.dtgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBookInfo.Size = new System.Drawing.Size(1160, 374);
            this.dtgvBookInfo.TabIndex = 0;
            this.dtgvBookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBookInfo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnDeleteBook);
            this.groupBox2.Controls.Add(this.btnEditBook);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1495, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(897, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(742, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(630, 26);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(106, 48);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.White;
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBook.Image")));
            this.btnEditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.Location = new System.Drawing.Point(518, 26);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(106, 48);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Sửa";
            this.btnEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(406, 26);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(106, 48);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbBookCategory);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbNXB);
            this.groupBox1.Controls.Add(this.nmBookAmount);
            this.groupBox1.Controls.Add(this.txbBookPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbBookPosition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbStatusBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbBookCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBookName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1495, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1241, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thêm thể loại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(813, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm NXB";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // cbbBookCategory
            // 
            this.cbbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookCategory.FormattingEnabled = true;
            this.cbbBookCategory.Location = new System.Drawing.Point(1194, 37);
            this.cbbBookCategory.Name = "cbbBookCategory";
            this.cbbBookCategory.Size = new System.Drawing.Size(217, 28);
            this.cbbBookCategory.TabIndex = 7;
            this.cbbBookCategory.SelectedIndexChanged += new System.EventHandler(this.cbbBookCategory_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1055, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Thể loại:";
            // 
            // cbbNXB
            // 
            this.cbbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(742, 39);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(217, 28);
            this.cbbNXB.TabIndex = 4;
            // 
            // nmBookAmount
            // 
            this.nmBookAmount.Location = new System.Drawing.Point(742, 128);
            this.nmBookAmount.Name = "nmBookAmount";
            this.nmBookAmount.ReadOnly = true;
            this.nmBookAmount.Size = new System.Drawing.Size(217, 27);
            this.nmBookAmount.TabIndex = 6;
            // 
            // txbBookPrice
            // 
            this.txbBookPrice.Location = new System.Drawing.Point(188, 175);
            this.txbBookPrice.Name = "txbBookPrice";
            this.txbBookPrice.Size = new System.Drawing.Size(217, 27);
            this.txbBookPrice.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Giá:";
            // 
            // txbBookPosition
            // 
            this.txbBookPosition.Enabled = false;
            this.txbBookPosition.Location = new System.Drawing.Point(1194, 125);
            this.txbBookPosition.Name = "txbBookPosition";
            this.txbBookPosition.Size = new System.Drawing.Size(217, 27);
            this.txbBookPosition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1055, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vị trí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng:";
            // 
            // cbbStatusBook
            // 
            this.cbbStatusBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusBook.FormattingEnabled = true;
            this.cbbStatusBook.Location = new System.Drawing.Point(188, 129);
            this.cbbStatusBook.Name = "cbbStatusBook";
            this.cbbStatusBook.Size = new System.Drawing.Size(217, 28);
            this.cbbStatusBook.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tình trạng:";
            // 
            // txbBookCode
            // 
            this.txbBookCode.Location = new System.Drawing.Point(188, 31);
            this.txbBookCode.Name = "txbBookCode";
            this.txbBookCode.Size = new System.Drawing.Size(217, 27);
            this.txbBookCode.TabIndex = 0;
            this.txbBookCode.TextChanged += new System.EventHandler(this.txbBookCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà xuất bản:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(188, 79);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(217, 27);
            this.txbBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnReceiptSearch);
            this.tabPage2.Controls.Add(this.btnAddReceipt);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1514, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(961, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Làm mới";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReceiptSearch
            // 
            this.btnReceiptSearch.BackColor = System.Drawing.Color.White;
            this.btnReceiptSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiptSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnReceiptSearch.Image")));
            this.btnReceiptSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceiptSearch.Location = new System.Drawing.Point(773, 134);
            this.btnReceiptSearch.Name = "btnReceiptSearch";
            this.btnReceiptSearch.Size = new System.Drawing.Size(155, 49);
            this.btnReceiptSearch.TabIndex = 2;
            this.btnReceiptSearch.Text = "Tìm kiếm";
            this.btnReceiptSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiptSearch.UseVisualStyleBackColor = false;
            this.btnReceiptSearch.Click += new System.EventHandler(this.btnReceiptSearch_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.BackColor = System.Drawing.Color.White;
            this.btnAddReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReceipt.Image")));
            this.btnAddReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReceipt.Location = new System.Drawing.Point(539, 134);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(206, 49);
            this.btnAddReceipt.TabIndex = 1;
            this.btnAddReceipt.Text = "Thêm phiếu nhập";
            this.btnAddReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReceipt.UseVisualStyleBackColor = false;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbBookName);
            this.groupBox5.Controls.Add(this.pbBookImageReceipt);
            this.groupBox5.Controls.Add(this.dtgvDetailReceipt);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(655, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(853, 549);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu nhập";
            // 
            // lbBookName
            // 
            this.lbBookName.Location = new System.Drawing.Point(449, 503);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(394, 40);
            this.lbBookName.TabIndex = 7;
            this.lbBookName.Text = "label7";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBookImageReceipt
            // 
            this.pbBookImageReceipt.Location = new System.Drawing.Point(453, 26);
            this.pbBookImageReceipt.Name = "pbBookImageReceipt";
            this.pbBookImageReceipt.Size = new System.Drawing.Size(390, 474);
            this.pbBookImageReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImageReceipt.TabIndex = 6;
            this.pbBookImageReceipt.TabStop = false;
            // 
            // dtgvDetailReceipt
            // 
            this.dtgvDetailReceipt.AllowUserToAddRows = false;
            this.dtgvDetailReceipt.AllowUserToDeleteRows = false;
            this.dtgvDetailReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDetailReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetailReceipt.Location = new System.Drawing.Point(8, 26);
            this.dtgvDetailReceipt.Name = "dtgvDetailReceipt";
            this.dtgvDetailReceipt.ReadOnly = true;
            this.dtgvDetailReceipt.RowHeadersWidth = 51;
            this.dtgvDetailReceipt.RowTemplate.Height = 24;
            this.dtgvDetailReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetailReceipt.Size = new System.Drawing.Size(439, 517);
            this.dtgvDetailReceipt.TabIndex = 0;
            this.dtgvDetailReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetailReceipt_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvListReceipt);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 549);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu nhập";
            // 
            // dtgvListReceipt
            // 
            this.dtgvListReceipt.AllowUserToAddRows = false;
            this.dtgvListReceipt.AllowUserToDeleteRows = false;
            this.dtgvListReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListReceipt.Location = new System.Drawing.Point(8, 26);
            this.dtgvListReceipt.Name = "dtgvListReceipt";
            this.dtgvListReceipt.ReadOnly = true;
            this.dtgvListReceipt.RowHeadersWidth = 51;
            this.dtgvListReceipt.RowTemplate.Height = 24;
            this.dtgvListReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListReceipt.Size = new System.Drawing.Size(613, 517);
            this.dtgvListReceipt.TabIndex = 0;
            this.dtgvListReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListReceipt_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpkDayTo);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.btnAddNXB);
            this.groupBox6.Controls.Add(this.cbbNXBReceipt);
            this.groupBox6.Controls.Add(this.dtpkDayImport);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txbReceiptCode);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1485, 111);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin";
            // 
            // dtpkDayTo
            // 
            this.dtpkDayTo.Location = new System.Drawing.Point(1106, 63);
            this.dtpkDayTo.Name = "dtpkDayTo";
            this.dtpkDayTo.Size = new System.Drawing.Size(344, 27);
            this.dtpkDayTo.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(986, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Đến ngày:";
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.BackColor = System.Drawing.Color.White;
            this.btnAddNXB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNXB.Image")));
            this.btnAddNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNXB.Location = new System.Drawing.Point(699, 59);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(141, 46);
            this.btnAddNXB.TabIndex = 2;
            this.btnAddNXB.Text = "Thêm NXB";
            this.btnAddNXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNXB.UseVisualStyleBackColor = false;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // cbbNXBReceipt
            // 
            this.cbbNXBReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNXBReceipt.FormattingEnabled = true;
            this.cbbNXBReceipt.Location = new System.Drawing.Point(582, 25);
            this.cbbNXBReceipt.Name = "cbbNXBReceipt";
            this.cbbNXBReceipt.Size = new System.Drawing.Size(258, 28);
            this.cbbNXBReceipt.TabIndex = 1;
            // 
            // dtpkDayImport
            // 
            this.dtpkDayImport.Location = new System.Drawing.Point(1106, 26);
            this.dtpkDayImport.Name = "dtpkDayImport";
            this.dtpkDayImport.Size = new System.Drawing.Size(344, 27);
            this.dtpkDayImport.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(986, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ngày nhập:";
            // 
            // txbReceiptCode
            // 
            this.txbReceiptCode.Location = new System.Drawing.Point(181, 24);
            this.txbReceiptCode.Name = "txbReceiptCode";
            this.txbReceiptCode.Size = new System.Drawing.Size(217, 27);
            this.txbReceiptCode.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Số phiếu nhập:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(455, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Nhà xuất bản:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1522, 773);
            this.tabControl1.TabIndex = 0;
            // 
            // FormWarehouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1546, 844);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWarehouseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImageReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailReceipt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListReceipt)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvBookInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.NumericUpDown nmBookAmount;
        private System.Windows.Forms.TextBox txbBookPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbBookPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbStatusBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbBookCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvListReceipt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbbNXBReceipt;
        private System.Windows.Forms.DateTimePicker dtpkDayImport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbReceiptCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddNXB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvDetailReceipt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReceiptSearch;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.DateTimePicker dtpkDayTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbBookCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.PictureBox pbBookImageReceipt;
        private System.Windows.Forms.Button btnReset;
    }
}