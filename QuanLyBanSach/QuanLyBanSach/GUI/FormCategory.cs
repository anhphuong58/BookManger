using QuanLyBanSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.GUI
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            SetGUI();
        }
        private void SetGUI()
        {
            txbCategoryCode.Text = "";
            txbCategoryName.Text = "";
            txbPosition.Text = "";
            dtgvListCategory.DataSource = QLBS_BUS.Instance.GetListCategory();
            if(dtgvListCategory.Rows.Count > 0)
            {
                dtgvListCategory.Columns["Ma_TL"].HeaderText = "Mã thể loại";
                dtgvListCategory.Columns["Ten_TL"].HeaderText = "Tên thể loại";
                dtgvListCategory.Columns["ViTri"].HeaderText = "Vị trí";
            }
        }

        private void dtgvListCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListCategory.SelectedRows;
            if (r.Count == 1)
            {
                txbCategoryCode.Text = r[0].Cells["Ma_TL"].Value.ToString();
                txbCategoryName.Text = r[0].Cells["Ten_TL"].Value.ToString();
                txbPosition.Text = r[0].Cells["ViTri"].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txbCategoryCode.Text == "" || txbCategoryName.Text == "" || txbPosition.Text == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (QLBS_BUS.Instance.GetBookCategoryByID(txbCategoryCode.Text).Ma_TL != null)
            {
                MessageBox.Show("Trùng mã thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (QLBS_BUS.Instance.GetBookCategoryByName(txbCategoryName.Text).Ten_TL == txbCategoryName.Text)
            {
                MessageBox.Show("Trùng tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            THELOAI theloai = new THELOAI();
            theloai.Ma_TL = txbCategoryCode.Text;
            theloai.Ten_TL = txbCategoryName.Text;
            theloai.ViTri = txbPosition.Text;
            QLBS_BUS.Instance.AddCategory(theloai);
            MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (txbCategoryCode.Text == "" || txbCategoryName.Text == "" || txbPosition.Text == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txbCategoryCode.Text == QLBS_BUS.Instance.GetBookCategoryByID(txbCategoryCode.Text).Ma_TL)
            {
                if(QLBS_BUS.Instance.GetBookCategoryByName(txbCategoryName.Text).Ten_TL == txbCategoryName.Text && QLBS_BUS.Instance.GetBookCategoryByName(txbCategoryName.Text).Ma_TL != txbCategoryCode.Text)
                {
                    MessageBox.Show("Trùng tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                THELOAI theloai = new THELOAI();
                theloai.Ma_TL = txbCategoryCode.Text;
                theloai.Ten_TL = txbCategoryName.Text;
                theloai.ViTri = txbPosition.Text;
                QLBS_BUS.Instance.UpdateCategory(theloai);
                MessageBox.Show("cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
            else
            {
                MessageBox.Show("Mã thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (txbCategoryCode.Text == QLBS_BUS.Instance.GetBookCategoryByID(txbCategoryCode.Text).Ma_TL)
            {
                THELOAI theloai = QLBS_BUS.Instance.GetBookCategoryByID(txbCategoryCode.Text);
                if (txbCategoryName.Text != theloai.Ten_TL || txbPosition.Text != theloai.ViTri)
                {
                    MessageBox.Show("Thông tin thể loại từ các text không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                QLBS_BUS.Instance.DeleteCategory(theloai.Ma_TL);
                MessageBox.Show("Xóa thể loại sách" + theloai.Ten_TL + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
            else
            {
                MessageBox.Show("Mã thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
