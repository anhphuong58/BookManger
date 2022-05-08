
namespace QuanLyBanSach
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch_order = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.dtgvDetailOrder = new System.Windows.Forms.DataGridView();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvOrderSearch = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMNMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMNMin = new System.Windows.Forms.TextBox();
            this.dtpkDayTo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpkDayImport = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbOrderCode = new System.Windows.Forms.TextBox();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbStaffName = new System.Windows.Forms.TextBox();
            this.cbbStaffCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bthCustomerSearch = new System.Windows.Forms.Button();
            this.txbCheckInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCustomerCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailOrder)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderSearch)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.quảnLýKhoHàngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1880, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // quảnLýKhoHàngToolStripMenuItem
            // 
            this.quảnLýKhoHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKhoHàngToolStripMenuItem.Name = "quảnLýKhoHàngToolStripMenuItem";
            this.quảnLýKhoHàngToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.quảnLýKhoHàngToolStripMenuItem.Text = "Quản lý kho hàng";
            this.quảnLýKhoHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoHàngToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.đăngXuấtToolStripMenuItem.Text = "Thoát chương trình";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnSearch_order);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnCreateNewOrder);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1838, 810);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giao dịch";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(981, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch_order
            // 
            this.btnSearch_order.BackColor = System.Drawing.Color.White;
            this.btnSearch_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch_order.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_order.Image")));
            this.btnSearch_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_order.Location = new System.Drawing.Point(777, 157);
            this.btnSearch_order.Name = "btnSearch_order";
            this.btnSearch_order.Size = new System.Drawing.Size(155, 40);
            this.btnSearch_order.TabIndex = 1;
            this.btnSearch_order.Text = "Tìm kiếm";
            this.btnSearch_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch_order.UseVisualStyleBackColor = false;
            this.btnSearch_order.Click += new System.EventHandler(this.btnSearch_order_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBookName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbBookImage);
            this.groupBox1.Controls.Add(this.dtgvDetailOrder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(762, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 530);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // lbBookName
            // 
            this.lbBookName.Location = new System.Drawing.Point(649, 484);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(398, 40);
            this.lbBookName.TabIndex = 5;
            this.lbBookName.Text = "label7";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(896, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // pbBookImage
            // 
            this.pbBookImage.BackColor = System.Drawing.Color.Transparent;
            this.pbBookImage.Location = new System.Drawing.Point(649, 26);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(398, 455);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 2;
            this.pbBookImage.TabStop = false;
            // 
            // dtgvDetailOrder
            // 
            this.dtgvDetailOrder.AllowUserToAddRows = false;
            this.dtgvDetailOrder.AllowUserToDeleteRows = false;
            this.dtgvDetailOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetailOrder.Location = new System.Drawing.Point(15, 26);
            this.dtgvDetailOrder.Name = "dtgvDetailOrder";
            this.dtgvDetailOrder.ReadOnly = true;
            this.dtgvDetailOrder.RowHeadersWidth = 51;
            this.dtgvDetailOrder.RowTemplate.Height = 24;
            this.dtgvDetailOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetailOrder.Size = new System.Drawing.Size(628, 498);
            this.dtgvDetailOrder.TabIndex = 0;
            this.dtgvDetailOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetailOrder_CellClick);
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewOrder.Image")));
            this.btnCreateNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewOrder.Location = new System.Drawing.Point(1605, 749);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(221, 42);
            this.btnCreateNewOrder.TabIndex = 5;
            this.btnCreateNewOrder.Text = "Tạo mới hóa đơn";
            this.btnCreateNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewOrder.UseVisualStyleBackColor = false;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvOrderSearch);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 530);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách hóa đơn";
            // 
            // dtgvOrderSearch
            // 
            this.dtgvOrderSearch.AllowUserToAddRows = false;
            this.dtgvOrderSearch.AllowUserToDeleteRows = false;
            this.dtgvOrderSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOrderSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrderSearch.Location = new System.Drawing.Point(6, 26);
            this.dtgvOrderSearch.Name = "dtgvOrderSearch";
            this.dtgvOrderSearch.ReadOnly = true;
            this.dtgvOrderSearch.RowHeadersWidth = 51;
            this.dtgvOrderSearch.RowTemplate.Height = 24;
            this.dtgvOrderSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrderSearch.Size = new System.Drawing.Size(723, 498);
            this.dtgvOrderSearch.TabIndex = 0;
            this.dtgvOrderSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrderSearch_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txbMNMax);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txbMNMin);
            this.groupBox4.Controls.Add(this.dtpkDayTo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtpkDayImport);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txbOrderCode);
            this.groupBox4.Controls.Add(this.btnStaffSearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txbStaffName);
            this.groupBox4.Controls.Add(this.cbbStaffCode);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.bthCustomerSearch);
            this.groupBox4.Controls.Add(this.txbCheckInfo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txbCustomerName);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txbCustomerCode);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1826, 136);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin order hôm nay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Đến:";
            // 
            // txbMNMax
            // 
            this.txbMNMax.Location = new System.Drawing.Point(1025, 95);
            this.txbMNMax.Name = "txbMNMax";
            this.txbMNMax.Size = new System.Drawing.Size(184, 27);
            this.txbMNMax.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Giá trị từ:";
            // 
            // txbMNMin
            // 
            this.txbMNMin.Location = new System.Drawing.Point(697, 95);
            this.txbMNMin.Name = "txbMNMin";
            this.txbMNMin.Size = new System.Drawing.Size(179, 27);
            this.txbMNMin.TabIndex = 6;
            // 
            // dtpkDayTo
            // 
            this.dtpkDayTo.Location = new System.Drawing.Point(165, 101);
            this.dtpkDayTo.Name = "dtpkDayTo";
            this.dtpkDayTo.Size = new System.Drawing.Size(307, 27);
            this.dtpkDayTo.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Đến ngày:";
            // 
            // dtpkDayImport
            // 
            this.dtpkDayImport.Location = new System.Drawing.Point(165, 64);
            this.dtpkDayImport.Name = "dtpkDayImport";
            this.dtpkDayImport.Size = new System.Drawing.Size(307, 27);
            this.dtpkDayImport.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txbOrderCode
            // 
            this.txbOrderCode.Location = new System.Drawing.Point(165, 26);
            this.txbOrderCode.Name = "txbOrderCode";
            this.txbOrderCode.Size = new System.Drawing.Size(389, 27);
            this.txbOrderCode.TabIndex = 0;
            this.txbOrderCode.TextChanged += new System.EventHandler(this.txbOrderCode_TextChanged);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffSearch.Image")));
            this.btnStaffSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffSearch.Location = new System.Drawing.Point(1089, 22);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(87, 33);
            this.btnStaffSearch.TabIndex = 4;
            this.btnStaffSearch.Text = "Chọn";
            this.btnStaffSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tên nhân viên:";
            // 
            // txbStaffName
            // 
            this.txbStaffName.Enabled = false;
            this.txbStaffName.Location = new System.Drawing.Point(787, 58);
            this.txbStaffName.Name = "txbStaffName";
            this.txbStaffName.Size = new System.Drawing.Size(389, 27);
            this.txbStaffName.TabIndex = 5;
            // 
            // cbbStaffCode
            // 
            this.cbbStaffCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffCode.FormattingEnabled = true;
            this.cbbStaffCode.Location = new System.Drawing.Point(787, 24);
            this.cbbStaffCode.Name = "cbbStaffCode";
            this.cbbStaffCode.Size = new System.Drawing.Size(296, 28);
            this.cbbStaffCode.TabIndex = 3;
            this.cbbStaffCode.SelectedIndexChanged += new System.EventHandler(this.cbbStaffCode_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã nhân viên:";
            // 
            // bthCustomerSearch
            // 
            this.bthCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("bthCustomerSearch.Image")));
            this.bthCustomerSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthCustomerSearch.Location = new System.Drawing.Point(1682, 58);
            this.bthCustomerSearch.Name = "bthCustomerSearch";
            this.bthCustomerSearch.Size = new System.Drawing.Size(87, 33);
            this.bthCustomerSearch.TabIndex = 10;
            this.bthCustomerSearch.Text = "Chọn";
            this.bthCustomerSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthCustomerSearch.UseVisualStyleBackColor = true;
            this.bthCustomerSearch.Click += new System.EventHandler(this.bthCustomerSearch_Click_1);
            // 
            // txbCheckInfo
            // 
            this.txbCheckInfo.Location = new System.Drawing.Point(1472, 25);
            this.txbCheckInfo.Name = "txbCheckInfo";
            this.txbCheckInfo.Size = new System.Drawing.Size(297, 27);
            this.txbCheckInfo.TabIndex = 8;
            this.txbCheckInfo.TextChanged += new System.EventHandler(this.txbCheckInfo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1267, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nhập email hoặc SĐT:";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Enabled = false;
            this.txbCustomerName.Location = new System.Drawing.Point(1416, 95);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(353, 27);
            this.txbCustomerName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1267, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tên khách hàng:";
            // 
            // txbCustomerCode
            // 
            this.txbCustomerCode.Enabled = false;
            this.txbCustomerCode.Location = new System.Drawing.Point(1416, 60);
            this.txbCustomerCode.Name = "txbCustomerCode";
            this.txbCustomerCode.Size = new System.Drawing.Size(260, 27);
            this.txbCustomerCode.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1267, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mã khách hàng:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1846, 845);
            this.tabControl1.TabIndex = 4;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1880, 895);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailOrder)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderSearch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoHàngToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDetailOrder;
        private System.Windows.Forms.Button btnCreateNewOrder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvOrderSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button bthCustomerSearch;
        private System.Windows.Forms.TextBox txbCheckInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCustomerCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOrderCode;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbStaffName;
        private System.Windows.Forms.ComboBox cbbStaffCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkDayTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpkDayImport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearch_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMNMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMNMin;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}