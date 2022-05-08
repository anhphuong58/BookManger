
namespace QuanLyBanSach
{
    partial class FormFindProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.txbBookCode = new System.Windows.Forms.TextBox();
            this.txbBookPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbBookCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbBookStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.flpListBook = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1556, 766);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.BackColor = System.Drawing.Color.White;
            this.btnChooseBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseBook.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseBook.Image")));
            this.btnChooseBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseBook.Location = new System.Drawing.Point(1408, 766);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(113, 48);
            this.btnChooseBook.TabIndex = 3;
            this.btnChooseBook.Text = "Chọn";
            this.btnChooseBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseBook.UseVisualStyleBackColor = false;
            this.btnChooseBook.Click += new System.EventHandler(this.btnChooseBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbNXB);
            this.groupBox1.Controls.Add(this.txbBookCode);
            this.groupBox1.Controls.Add(this.txbBookPosition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbBookCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbBookStatus);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbBookName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1657, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(753, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbNXB
            // 
            this.cbbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(718, 33);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(379, 28);
            this.cbbNXB.TabIndex = 14;
            // 
            // txbBookCode
            // 
            this.txbBookCode.Location = new System.Drawing.Point(152, 33);
            this.txbBookCode.Name = "txbBookCode";
            this.txbBookCode.Size = new System.Drawing.Size(379, 27);
            this.txbBookCode.TabIndex = 0;
            this.txbBookCode.TextChanged += new System.EventHandler(this.txbBookCode_TextChanged);
            // 
            // txbBookPosition
            // 
            this.txbBookPosition.Enabled = false;
            this.txbBookPosition.Location = new System.Drawing.Point(718, 76);
            this.txbBookPosition.Name = "txbBookPosition";
            this.txbBookPosition.Size = new System.Drawing.Size(379, 27);
            this.txbBookPosition.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vị trí:";
            // 
            // cbbBookCategory
            // 
            this.cbbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookCategory.FormattingEnabled = true;
            this.cbbBookCategory.Location = new System.Drawing.Point(1266, 74);
            this.cbbBookCategory.Name = "cbbBookCategory";
            this.cbbBookCategory.Size = new System.Drawing.Size(379, 28);
            this.cbbBookCategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1126, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thể loại:";
            // 
            // cbbBookStatus
            // 
            this.cbbBookStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookStatus.FormattingEnabled = true;
            this.cbbBookStatus.Location = new System.Drawing.Point(1266, 35);
            this.cbbBookStatus.Name = "cbbBookStatus";
            this.cbbBookStatus.Size = new System.Drawing.Size(379, 28);
            this.cbbBookStatus.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(938, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1126, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tình trạng:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(152, 81);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(379, 27);
            this.txbBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pbBookImage);
            this.groupBox2.Controls.Add(this.flpListBook);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1657, 546);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // pbBookImage
            // 
            this.pbBookImage.Location = new System.Drawing.Point(1155, 29);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(490, 492);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 7;
            this.pbBookImage.TabStop = false;
            // 
            // flpListBook
            // 
            this.flpListBook.AutoScroll = true;
            this.flpListBook.BackColor = System.Drawing.Color.LightGray;
            this.flpListBook.Location = new System.Drawing.Point(25, 29);
            this.flpListBook.Name = "flpListBook";
            this.flpListBook.Size = new System.Drawing.Size(1124, 492);
            this.flpListBook.TabIndex = 6;
            // 
            // FormFindProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1699, 829);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChooseBook);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFindProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBookPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbBookCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbBookStatus;
        private System.Windows.Forms.TextBox txbBookCode;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.FlowLayoutPanel flpListBook;
    }
}