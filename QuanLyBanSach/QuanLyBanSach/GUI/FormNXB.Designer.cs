
namespace QuanLyBanSach.GUI
{
    partial class FormNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNXB));
            this.txbNXBCode = new System.Windows.Forms.TextBox();
            this.txbNXBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvListNXB = new System.Windows.Forms.DataGridView();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.btnEditNXB = new System.Windows.Forms.Button();
            this.btnDeleteNXB = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNXBPhone = new System.Windows.Forms.TextBox();
            this.txbNXBAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNXBCode
            // 
            this.txbNXBCode.Location = new System.Drawing.Point(225, 34);
            this.txbNXBCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbNXBCode.Name = "txbNXBCode";
            this.txbNXBCode.Size = new System.Drawing.Size(216, 27);
            this.txbNXBCode.TabIndex = 0;
            // 
            // txbNXBName
            // 
            this.txbNXBName.Location = new System.Drawing.Point(225, 89);
            this.txbNXBName.Margin = new System.Windows.Forms.Padding(4);
            this.txbNXBName.Name = "txbNXBName";
            this.txbNXBName.Size = new System.Drawing.Size(216, 27);
            this.txbNXBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhà xuất bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhà xuất bản:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvListNXB);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 403);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách NXB:";
            // 
            // dtgvListNXB
            // 
            this.dtgvListNXB.AllowUserToAddRows = false;
            this.dtgvListNXB.AllowUserToDeleteRows = false;
            this.dtgvListNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNXB.Location = new System.Drawing.Point(6, 26);
            this.dtgvListNXB.Name = "dtgvListNXB";
            this.dtgvListNXB.ReadOnly = true;
            this.dtgvListNXB.RowHeadersWidth = 51;
            this.dtgvListNXB.RowTemplate.Height = 24;
            this.dtgvListNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListNXB.Size = new System.Drawing.Size(885, 371);
            this.dtgvListNXB.TabIndex = 0;
            this.dtgvListNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNXB_CellClick);
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.BackColor = System.Drawing.Color.White;
            this.btnAddNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNXB.Image")));
            this.btnAddNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNXB.Location = new System.Drawing.Point(281, 145);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(113, 46);
            this.btnAddNXB.TabIndex = 4;
            this.btnAddNXB.Text = "Thêm";
            this.btnAddNXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNXB.UseVisualStyleBackColor = false;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // btnEditNXB
            // 
            this.btnEditNXB.BackColor = System.Drawing.Color.White;
            this.btnEditNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNXB.Image")));
            this.btnEditNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNXB.Location = new System.Drawing.Point(420, 145);
            this.btnEditNXB.Name = "btnEditNXB";
            this.btnEditNXB.Size = new System.Drawing.Size(113, 46);
            this.btnEditNXB.TabIndex = 5;
            this.btnEditNXB.Text = "Sửa";
            this.btnEditNXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditNXB.UseVisualStyleBackColor = false;
            this.btnEditNXB.Click += new System.EventHandler(this.btnEditNXB_Click);
            // 
            // btnDeleteNXB
            // 
            this.btnDeleteNXB.BackColor = System.Drawing.Color.White;
            this.btnDeleteNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNXB.Image")));
            this.btnDeleteNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNXB.Location = new System.Drawing.Point(561, 145);
            this.btnDeleteNXB.Name = "btnDeleteNXB";
            this.btnDeleteNXB.Size = new System.Drawing.Size(113, 46);
            this.btnDeleteNXB.TabIndex = 6;
            this.btnDeleteNXB.Text = "Xóa";
            this.btnDeleteNXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNXB.UseVisualStyleBackColor = false;
            this.btnDeleteNXB.Click += new System.EventHandler(this.btnDeleteNXB_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(790, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "SĐT nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ nhà xuất bản:";
            // 
            // txbNXBPhone
            // 
            this.txbNXBPhone.Location = new System.Drawing.Point(693, 89);
            this.txbNXBPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txbNXBPhone.Name = "txbNXBPhone";
            this.txbNXBPhone.Size = new System.Drawing.Size(216, 27);
            this.txbNXBPhone.TabIndex = 3;
            // 
            // txbNXBAddress
            // 
            this.txbNXBAddress.Location = new System.Drawing.Point(693, 35);
            this.txbNXBAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbNXBAddress.Name = "txbNXBAddress";
            this.txbNXBAddress.Size = new System.Drawing.Size(216, 27);
            this.txbNXBAddress.TabIndex = 2;
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNXBPhone);
            this.Controls.Add(this.txbNXBAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteNXB);
            this.Controls.Add(this.btnEditNXB);
            this.Controls.Add(this.btnAddNXB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNXBName);
            this.Controls.Add(this.txbNXBCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà xuất bản";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNXBCode;
        private System.Windows.Forms.TextBox txbNXBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvListNXB;
        private System.Windows.Forms.Button btnAddNXB;
        private System.Windows.Forms.Button btnEditNXB;
        private System.Windows.Forms.Button btnDeleteNXB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNXBPhone;
        private System.Windows.Forms.TextBox txbNXBAddress;
    }
}