
namespace QuanLyBanSach.GUI
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvListCategory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.txbCategoryCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(526, 647);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(399, 191);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(105, 41);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.White;
            this.btnEditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.Image")));
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.Location = new System.Drawing.Point(258, 191);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(105, 41);
            this.btnEditCategory.TabIndex = 4;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(119, 191);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(105, 41);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvListCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 403);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thể loại:";
            // 
            // dtgvListCategory
            // 
            this.dtgvListCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListCategory.Location = new System.Drawing.Point(6, 26);
            this.dtgvListCategory.Name = "dtgvListCategory";
            this.dtgvListCategory.RowHeadersWidth = 51;
            this.dtgvListCategory.RowTemplate.Height = 24;
            this.dtgvListCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListCategory.Size = new System.Drawing.Size(613, 371);
            this.dtgvListCategory.TabIndex = 0;
            this.dtgvListCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListCategory_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã thể loại:";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(227, 75);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(277, 27);
            this.txbCategoryName.TabIndex = 1;
            // 
            // txbCategoryCode
            // 
            this.txbCategoryCode.Location = new System.Drawing.Point(227, 20);
            this.txbCategoryCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbCategoryCode.Name = "txbCategoryCode";
            this.txbCategoryCode.Size = new System.Drawing.Size(277, 27);
            this.txbCategoryCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vị trí:";
            // 
            // txbPosition
            // 
            this.txbPosition.Location = new System.Drawing.Point(227, 131);
            this.txbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.Size = new System.Drawing.Size(277, 27);
            this.txbPosition.TabIndex = 2;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.txbCategoryCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể loại";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvListCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.TextBox txbCategoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPosition;
    }
}