
namespace QuanLyBanSach
{
    partial class FormRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRevenue));
            this.btnSearchRevenue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbExport = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvList = new System.Windows.Forms.DataGridView();
            this.dtpkDayFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpkDayTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReadNumber = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txbTotalMoney = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRevenue
            // 
            this.btnSearchRevenue.BackColor = System.Drawing.Color.White;
            this.btnSearchRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRevenue.Image")));
            this.btnSearchRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRevenue.Location = new System.Drawing.Point(645, 132);
            this.btnSearchRevenue.Name = "btnSearchRevenue";
            this.btnSearchRevenue.Size = new System.Drawing.Size(134, 48);
            this.btnSearchRevenue.TabIndex = 1;
            this.btnSearchRevenue.Text = "Thống kê";
            this.btnSearchRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchRevenue.UseVisualStyleBackColor = false;
            this.btnSearchRevenue.Click += new System.EventHandler(this.btnSearchRevenue_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1328, 920);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 47);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbExport
            // 
            this.rbExport.AutoSize = true;
            this.rbExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExport.Location = new System.Drawing.Point(332, 123);
            this.rbExport.Name = "rbExport";
            this.rbExport.Size = new System.Drawing.Size(134, 24);
            this.rbExport.TabIndex = 101;
            this.rbExport.TabStop = true;
            this.rbExport.Text = "Thống kê xuất";
            this.rbExport.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImport.Location = new System.Drawing.Point(332, 167);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(139, 24);
            this.rbImport.TabIndex = 102;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "Thống kê nhập";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dtgvDetail);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 544);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1009, 319);
            this.groupBox5.TabIndex = 105;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết ";
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.AllowUserToAddRows = false;
            this.dtgvDetail.AllowUserToDeleteRows = false;
            this.dtgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Location = new System.Drawing.Point(8, 26);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.ReadOnly = true;
            this.dtgvDetail.RowHeadersWidth = 51;
            this.dtgvDetail.RowTemplate.Height = 24;
            this.dtgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetail.Size = new System.Drawing.Size(995, 287);
            this.dtgvDetail.TabIndex = 0;
            this.dtgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetail_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dtgvList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1009, 332);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách ";
            // 
            // dtgvList
            // 
            this.dtgvList.AllowUserToAddRows = false;
            this.dtgvList.AllowUserToDeleteRows = false;
            this.dtgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvList.Location = new System.Drawing.Point(8, 36);
            this.dtgvList.Name = "dtgvList";
            this.dtgvList.ReadOnly = true;
            this.dtgvList.RowHeadersWidth = 51;
            this.dtgvList.RowTemplate.Height = 24;
            this.dtgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvList.Size = new System.Drawing.Size(995, 290);
            this.dtgvList.TabIndex = 0;
            this.dtgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvList_CellClick);
            // 
            // dtpkDayFrom
            // 
            this.dtpkDayFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDayFrom.Location = new System.Drawing.Point(442, 72);
            this.dtpkDayFrom.Name = "dtpkDayFrom";
            this.dtpkDayFrom.Size = new System.Drawing.Size(325, 27);
            this.dtpkDayFrom.TabIndex = 106;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 107;
            this.label13.Text = "Ngày nhập:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(826, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 103;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(907, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 109;
            this.label14.Text = "Đến ngày:";
            // 
            // dtpkDayTo
            // 
            this.dtpkDayTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDayTo.Location = new System.Drawing.Point(1027, 72);
            this.dtpkDayTo.Name = "dtpkDayTo";
            this.dtpkDayTo.Size = new System.Drawing.Size(328, 27);
            this.dtpkDayTo.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(622, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 44);
            this.label1.TabIndex = 110;
            this.label1.Text = "Thống kê";
            // 
            // lbReadNumber
            // 
            this.lbReadNumber.AutoSize = true;
            this.lbReadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadNumber.Location = new System.Drawing.Point(145, 932);
            this.lbReadNumber.Name = "lbReadNumber";
            this.lbReadNumber.Size = new System.Drawing.Size(0, 17);
            this.lbReadNumber.TabIndex = 114;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(19, 935);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 113;
            this.label17.Text = "Bằng chữ:";
            // 
            // txbTotalMoney
            // 
            this.txbTotalMoney.Enabled = false;
            this.txbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalMoney.Location = new System.Drawing.Point(149, 890);
            this.txbTotalMoney.Name = "txbTotalMoney";
            this.txbTotalMoney.Size = new System.Drawing.Size(200, 27);
            this.txbTotalMoney.TabIndex = 111;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 893);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 112;
            this.label16.Text = "Tổng tiền:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 178);
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // lbBookName
            // 
            this.lbBookName.BackColor = System.Drawing.Color.Transparent;
            this.lbBookName.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(1036, 817);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(394, 40);
            this.lbBookName.TabIndex = 117;
            this.lbBookName.Text = "label7";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBookImage
            // 
            this.pbBookImage.BackColor = System.Drawing.Color.Transparent;
            this.pbBookImage.Location = new System.Drawing.Point(1040, 242);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(390, 551);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 116;
            this.pbBookImage.TabStop = false;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 985);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.pbBookImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbReadNumber);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txbTotalMoney);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkDayTo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpkDayFrom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbImport);
            this.Controls.Add(this.rbExport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchRevenue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchRevenue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbExport;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvList;
        private System.Windows.Forms.DateTimePicker dtpkDayFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpkDayTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReadNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbTotalMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.PictureBox pbBookImage;
    }
}