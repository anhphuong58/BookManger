
namespace QuanLyBanSach.GUI
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.cbbBookStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbBookPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBookCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBookCode = new System.Windows.Forms.TextBox();
            this.nmBookAmount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.dtgvListBook = new System.Windows.Forms.DataGridView();
            this.btnCreateReceipt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbNXB = new System.Windows.Forms.TextBox();
            this.dtpkDayImport = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txbReceiptCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbReadNumber = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnAddCategory);
            this.groupBox6.Controls.Add(this.cbbBookStatus);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txbBookPrice);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cbbBookCategory);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txbBookCode);
            this.groupBox6.Controls.Add(this.nmBookAmount);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txbBookName);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnProductSearch);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(14, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1272, 148);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin sách";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(656, 67);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 48);
            this.btnAddCategory.TabIndex = 10;
            this.btnAddCategory.Text = "Thêm thể loại";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // cbbBookStatus
            // 
            this.cbbBookStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookStatus.FormattingEnabled = true;
            this.cbbBookStatus.Location = new System.Drawing.Point(143, 108);
            this.cbbBookStatus.Name = "cbbBookStatus";
            this.cbbBookStatus.Size = new System.Drawing.Size(226, 28);
            this.cbbBookStatus.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Tình trạng:";
            // 
            // txbBookPrice
            // 
            this.txbBookPrice.Location = new System.Drawing.Point(965, 70);
            this.txbBookPrice.Name = "txbBookPrice";
            this.txbBookPrice.Size = new System.Drawing.Size(291, 27);
            this.txbBookPrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Giá sách:";
            // 
            // cbbBookCategory
            // 
            this.cbbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookCategory.FormattingEnabled = true;
            this.cbbBookCategory.Location = new System.Drawing.Point(540, 26);
            this.cbbBookCategory.Name = "cbbBookCategory";
            this.cbbBookCategory.Size = new System.Drawing.Size(266, 28);
            this.cbbBookCategory.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Thể loại:";
            // 
            // txbBookCode
            // 
            this.txbBookCode.Location = new System.Drawing.Point(143, 28);
            this.txbBookCode.Name = "txbBookCode";
            this.txbBookCode.Size = new System.Drawing.Size(133, 27);
            this.txbBookCode.TabIndex = 1;
            this.txbBookCode.TextChanged += new System.EventHandler(this.txbBookCode_TextChanged);
            // 
            // nmBookAmount
            // 
            this.nmBookAmount.Location = new System.Drawing.Point(964, 26);
            this.nmBookAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmBookAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBookAmount.Name = "nmBookAmount";
            this.nmBookAmount.Size = new System.Drawing.Size(291, 27);
            this.nmBookAmount.TabIndex = 7;
            this.nmBookAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(834, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Số lượng:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(143, 67);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(226, 27);
            this.txbBookName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Tên sách:";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnProductSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSearch.Image")));
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductSearch.Location = new System.Drawing.Point(282, 25);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(87, 33);
            this.btnProductSearch.TabIndex = 2;
            this.btnProductSearch.Text = "Chọn";
            this.btnProductSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Mã sách:";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(697, 260);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 45);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(554, 260);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(107, 45);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.pbBookImage);
            this.groupBox1.Controls.Add(this.dtgvListBook);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 411);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseImage.Image")));
            this.btnChooseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseImage.Location = new System.Drawing.Point(1048, 358);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(129, 42);
            this.btnChooseImage.TabIndex = 1003;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbBookImage
            // 
            this.pbBookImage.Location = new System.Drawing.Point(947, 26);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(308, 326);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 1002;
            this.pbBookImage.TabStop = false;
            // 
            // dtgvListBook
            // 
            this.dtgvListBook.AllowUserToAddRows = false;
            this.dtgvListBook.AllowUserToDeleteRows = false;
            this.dtgvListBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBook.Location = new System.Drawing.Point(6, 26);
            this.dtgvListBook.Name = "dtgvListBook";
            this.dtgvListBook.ReadOnly = true;
            this.dtgvListBook.RowHeadersWidth = 51;
            this.dtgvListBook.RowTemplate.Height = 24;
            this.dtgvListBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListBook.Size = new System.Drawing.Size(935, 374);
            this.dtgvListBook.TabIndex = 0;
            this.dtgvListBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListBook_CellClick);
            // 
            // btnCreateReceipt
            // 
            this.btnCreateReceipt.BackColor = System.Drawing.Color.White;
            this.btnCreateReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateReceipt.Image")));
            this.btnCreateReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReceipt.Location = new System.Drawing.Point(962, 759);
            this.btnCreateReceipt.Name = "btnCreateReceipt";
            this.btnCreateReceipt.Size = new System.Drawing.Size(172, 56);
            this.btnCreateReceipt.TabIndex = 4;
            this.btnCreateReceipt.Text = "tạo phiếu nhập";
            this.btnCreateReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateReceipt.UseVisualStyleBackColor = false;
            this.btnCreateReceipt.Click += new System.EventHandler(this.btnCreateReceipt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1166, 759);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 759);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "bằng chữ:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txbNXB);
            this.groupBox2.Controls.Add(this.dtpkDayImport);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbReceiptCode);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1271, 88);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txbNXB
            // 
            this.txbNXB.Enabled = false;
            this.txbNXB.Location = new System.Drawing.Point(515, 39);
            this.txbNXB.Name = "txbNXB";
            this.txbNXB.Size = new System.Drawing.Size(291, 27);
            this.txbNXB.TabIndex = 1;
            // 
            // dtpkDayImport
            // 
            this.dtpkDayImport.Location = new System.Drawing.Point(964, 39);
            this.dtpkDayImport.Name = "dtpkDayImport";
            this.dtpkDayImport.Size = new System.Drawing.Size(291, 27);
            this.dtpkDayImport.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày nhập:";
            // 
            // txbReceiptCode
            // 
            this.txbReceiptCode.Enabled = false;
            this.txbReceiptCode.Location = new System.Drawing.Point(142, 39);
            this.txbReceiptCode.Name = "txbReceiptCode";
            this.txbReceiptCode.Size = new System.Drawing.Size(226, 27);
            this.txbReceiptCode.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Số phiếu nhập:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(380, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Nhà xuất bản:";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalMoney.Location = new System.Drawing.Point(123, 736);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(46, 17);
            this.lbTotalMoney.TabIndex = 56;
            this.lbTotalMoney.Text = "label1";
            // 
            // lbReadNumber
            // 
            this.lbReadNumber.AutoSize = true;
            this.lbReadNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbReadNumber.Location = new System.Drawing.Point(123, 759);
            this.lbReadNumber.Name = "lbReadNumber";
            this.lbReadNumber.Size = new System.Drawing.Size(46, 17);
            this.lbReadNumber.TabIndex = 57;
            this.lbReadNumber.Text = "label7";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 827);
            this.Controls.Add(this.lbReadNumber);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateReceipt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.groupBox6);
            this.MaximizeBox = false;
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBookAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txbBookCode;
        private System.Windows.Forms.NumericUpDown nmBookAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox cbbBookStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbBookPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBookCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvListBook;
        private System.Windows.Forms.Button btnCreateReceipt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpkDayImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbReceiptCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbNXB;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbReadNumber;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pbBookImage;
    }
}