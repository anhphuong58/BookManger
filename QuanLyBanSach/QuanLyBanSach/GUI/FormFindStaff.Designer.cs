
namespace QuanLyBanSach
{
    partial class FormFindStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseStaff = new System.Windows.Forms.Button();
            this.dtgvListStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRepress = new System.Windows.Forms.Button();
            this.txbSoCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbStaffPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbStaffAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbStaffPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbStaffEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbStaffCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(870, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseStaff
            // 
            this.btnChooseStaff.BackColor = System.Drawing.Color.White;
            this.btnChooseStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseStaff.Image")));
            this.btnChooseStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseStaff.Location = new System.Drawing.Point(741, 602);
            this.btnChooseStaff.Name = "btnChooseStaff";
            this.btnChooseStaff.Size = new System.Drawing.Size(113, 43);
            this.btnChooseStaff.TabIndex = 2;
            this.btnChooseStaff.Text = "Chọn";
            this.btnChooseStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseStaff.UseVisualStyleBackColor = false;
            this.btnChooseStaff.Click += new System.EventHandler(this.btnChooseStaff_Click);
            // 
            // dtgvListStaff
            // 
            this.dtgvListStaff.AllowUserToAddRows = false;
            this.dtgvListStaff.AllowUserToDeleteRows = false;
            this.dtgvListStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListStaff.Location = new System.Drawing.Point(12, 221);
            this.dtgvListStaff.Name = "dtgvListStaff";
            this.dtgvListStaff.ReadOnly = true;
            this.dtgvListStaff.RowHeadersWidth = 51;
            this.dtgvListStaff.RowTemplate.Height = 24;
            this.dtgvListStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListStaff.Size = new System.Drawing.Size(971, 375);
            this.dtgvListStaff.TabIndex = 1;
            this.dtgvListStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListStaff_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRepress);
            this.groupBox1.Controls.Add(this.txbSoCMND);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbStaffPosition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbStaffAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbStaffPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbStaffEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbStaffName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbStaffCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnRepress
            // 
            this.btnRepress.BackColor = System.Drawing.Color.White;
            this.btnRepress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepress.Image = ((System.Drawing.Image)(resources.GetObject("btnRepress.Image")));
            this.btnRepress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepress.Location = new System.Drawing.Point(545, 163);
            this.btnRepress.Name = "btnRepress";
            this.btnRepress.Size = new System.Drawing.Size(118, 38);
            this.btnRepress.TabIndex = 7;
            this.btnRepress.Text = "Nhập lại";
            this.btnRepress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepress.UseVisualStyleBackColor = false;
            this.btnRepress.Click += new System.EventHandler(this.btnRepress_Click);
            // 
            // txbSoCMND
            // 
            this.txbSoCMND.Location = new System.Drawing.Point(664, 121);
            this.txbSoCMND.Name = "txbSoCMND";
            this.txbSoCMND.Size = new System.Drawing.Size(272, 27);
            this.txbSoCMND.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số CMND:";
            // 
            // txbStaffPosition
            // 
            this.txbStaffPosition.Location = new System.Drawing.Point(152, 173);
            this.txbStaffPosition.Name = "txbStaffPosition";
            this.txbStaffPosition.Size = new System.Drawing.Size(268, 27);
            this.txbStaffPosition.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chức vụ:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(758, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbStaffAddress
            // 
            this.txbStaffAddress.Location = new System.Drawing.Point(152, 125);
            this.txbStaffAddress.Name = "txbStaffAddress";
            this.txbStaffAddress.Size = new System.Drawing.Size(268, 27);
            this.txbStaffAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txbStaffPhone
            // 
            this.txbStaffPhone.Location = new System.Drawing.Point(664, 74);
            this.txbStaffPhone.Name = "txbStaffPhone";
            this.txbStaffPhone.Size = new System.Drawing.Size(272, 27);
            this.txbStaffPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // txbStaffEmail
            // 
            this.txbStaffEmail.Location = new System.Drawing.Point(664, 32);
            this.txbStaffEmail.Name = "txbStaffEmail";
            this.txbStaffEmail.Size = new System.Drawing.Size(272, 27);
            this.txbStaffEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txbStaffName
            // 
            this.txbStaffName.Location = new System.Drawing.Point(152, 81);
            this.txbStaffName.Name = "txbStaffName";
            this.txbStaffName.Size = new System.Drawing.Size(268, 27);
            this.txbStaffName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên:";
            // 
            // cbbStaffCode
            // 
            this.cbbStaffCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaffCode.FormattingEnabled = true;
            this.cbbStaffCode.Location = new System.Drawing.Point(152, 36);
            this.cbbStaffCode.Name = "cbbStaffCode";
            this.cbbStaffCode.Size = new System.Drawing.Size(268, 28);
            this.cbbStaffCode.TabIndex = 0;
            this.cbbStaffCode.SelectedIndexChanged += new System.EventHandler(this.cbbStaffCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // FormFindStaff
            // 
            this.AcceptButton = this.btnChooseStaff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(995, 656);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChooseStaff);
            this.Controls.Add(this.dtgvListStaff);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFindStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseStaff;
        private System.Windows.Forms.DataGridView dtgvListStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbStaffAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbStaffPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbStaffEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbStaffCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbStaffPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSoCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRepress;
    }
}