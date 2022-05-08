using QuanLyBanSach.BUS;
using QuanLyBanSach.DTO;
using QuanLyBanSach.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class FormWarehouseManager : Form
    {
        public static string nullImagePath = "./SystemImage/null.jpg";
        public FormWarehouseManager()
        {
            InitializeComponent();
            SetCBB();
            SetGUI();
        }
        private void SetCBB()
        {
            // tao combobox nha xuat ban
            cbbNXB.Items.Clear();
            cbbNXB.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbNXB.Items.AddRange(QLBS_BUS.Instance.GetListCBBNXB().ToArray());

            cbbNXBReceipt.Items.Clear();
            cbbNXBReceipt.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbNXBReceipt.Items.AddRange(QLBS_BUS.Instance.GetListCBBNXB().ToArray());

            // tao combobox ting trang sach
            cbbStatusBook.Items.Clear();
            cbbStatusBook.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbStatusBook.Items.Add(new CBBItem { Value = 0, Text = "Mới" });
            cbbStatusBook.Items.Add(new CBBItem { Value = 1, Text = "Cũ" });

            // tao combobox the loai sach
            cbbBookCategory.Items.Clear();
            cbbBookCategory.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbBookCategory.Items.AddRange(QLBS_BUS.Instance.GetListCBBCategory().ToArray());
        }
        private void SetGUI()
        {
            dtpkDayImport.Value = new DateTime(2015, 1, 1);
            dtpkDayTo.Value = DateTime.Now;
            txbBookCode.Text = "";
            txbBookName.Text = "";
            txbBookPosition.Text = "";
            txbBookPrice.Text = "";
            nmBookAmount.Value = 0;
            cbbNXB.SelectedIndex = 0;
            cbbNXBReceipt.SelectedIndex = 0;
            cbbStatusBook.SelectedIndex = 0;
            cbbBookCategory.SelectedIndex = 0;
            dtgvListReceipt.DataSource = QLBS_BUS.Instance.getListReceipt();
            if (dtgvListReceipt.Rows.Count > 0)
            {
                dtgvListReceipt.Columns[0].HeaderText = "Số phiếu nhập";
                dtgvListReceipt.Columns[1].HeaderText = "Mã nhà xuất bản";
                dtgvListReceipt.Columns[2].HeaderText = "Ngày nhập";
                dtgvListReceipt.Columns[3].HeaderText = "Giá nhập";
            }

            dtgvBookInfo.DataSource = QLBS_BUS.Instance.GetListBook();
            if (dtgvBookInfo.Rows.Count > 0)
            {
                dtgvBookInfo.Columns[0].HeaderText = "Mã sách";
                dtgvBookInfo.Columns[1].HeaderText = "Tên sách";
                dtgvBookInfo.Columns[2].HeaderText = "Mã thể loại";
                dtgvBookInfo.Columns[3].HeaderText = "Mã nhà xuất bản";
                dtgvBookInfo.Columns[4].HeaderText = "Số lượng";
                dtgvBookInfo.Columns[5].HeaderText = "Tình trạng";
                dtgvBookInfo.Columns[6].HeaderText = "Giá";
            }
            dtgvDetailReceipt.DataSource = null;
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
                pbBookImageReceipt.Image = Image.FromFile(nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbBookName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txbBookCode.Text == "" || txbBookName.Text == "" || txbBookPrice.Text == "" || cbbNXB.SelectedIndex == 0 || cbbBookCategory.SelectedIndex == 0 || cbbStatusBook.SelectedIndex == 0)
            {
                MessageBox.Show("Thông tin chưa đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (QLBS_BUS.Instance.GetBookByID(txbBookCode.Text).Ma_S == txbBookCode.Text)
            {
                MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int value;
            if (!int.TryParse(txbBookPrice.Text, out value))
            {
                MessageBox.Show("Lỗi giá sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SACH sach = new SACH();
            sach.Ma_S = txbBookCode.Text;
            sach.Ten_S = txbBookName.Text;
            sach.Ma_NXB = QLBS_BUS.Instance.GetNXBByName(cbbNXB.SelectedItem.ToString()).Ma_NXB;
            sach.Ma_TL = QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).Ma_TL;
            sach.SoLuong = (int)nmBookAmount.Value;
            sach.TinhTrang = (cbbStatusBook.SelectedIndex == 1) ? true : false;
            sach.Gia = Convert.ToDouble(txbBookPrice.Text);
            if(MessageBox.Show("Chọn ảnh cho sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = "";
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pbBookImage.Image = Image.FromFile(dialog.FileName);
                        path = dialog.FileName;
                        sach.imgPath = path;
                        MessageBox.Show("Bạn đã chọn ảnh cho cuốn " + sach.Ten_S + " Thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            QLBS_BUS.Instance.AddBook(sach);
            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI();
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            if (cbbNXBReceipt.SelectedIndex > 0)
            {
                if(MessageBox.Show("Bạn muốn thêm phiếu nhập từ NXB " + cbbNXBReceipt.SelectedItem.ToString() + "?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                FormLogin f = new FormLogin(2);
                f.ShowDialog();
                if (f.flat == 1)
                {
                    FormReceipt fr = new FormReceipt(cbbNXBReceipt.SelectedItem.ToString());
                    fr.ShowDialog();
                    SetCBB();
                    SetGUI();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            FormNXB f = new FormNXB();
            f.ShowDialog();
            SetCBB();
        }

        private void dtgvListReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListReceipt.SelectedRows;
            if(r.Count == 1)
            {
                txbReceiptCode.Text = r[0].Cells["So_PN"].Value.ToString();
                cbbNXBReceipt.SelectedIndex = cbbNXBReceipt.FindStringExact(QLBS_BUS.Instance.GetNXBByID(r[0].Cells["Ma_NXB"].Value.ToString()).Ten_NXB);
                dtpkDayImport.Value = (DateTime)r[0].Cells["NgayNhap"].Value;
                dtgvDetailReceipt.DataSource = QLBS_BUS.Instance.GetListDetailReceiptBySoPN(r[0].Cells["So_PN"].Value.ToString());
                if(dtgvDetailReceipt.Rows.Count > 0)
                {
                    dtgvDetailReceipt.Columns[0].HeaderText = "Mã sách";
                    dtgvDetailReceipt.Columns[1].HeaderText = "Số lượng nhập";
                    dtgvDetailReceipt.Columns[2].HeaderText = "Giá nhập";
                }

            }
        }

        private void btnReceiptSearch_Click(object sender, EventArgs e)
        {
            if(txbReceiptCode.Text == "" && cbbNXBReceipt.SelectedIndex == 0 && dtpkDayImport.Value.Date == DateTime.Now.Date)
            {
                SetCBB();
                SetGUI();
                return;
            }
            string SoPN = txbReceiptCode.Text;
            string MaNXB = "";
            if (cbbNXBReceipt.SelectedIndex > 0)
            {
                MaNXB = QLBS_BUS.Instance.GetNXBByName(cbbNXBReceipt.SelectedItem.ToString()).Ma_NXB;
            }
            DateTime timeFrom = dtpkDayImport.Value;
            DateTime timeTo = dtpkDayTo.Value;
            dtgvListReceipt.DataSource = QLBS_BUS.Instance.GetListReceiptByInfo(SoPN, MaNXB, timeFrom, timeTo);
            dtgvDetailReceipt.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCBB();
            SetGUI();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSach = txbBookCode.Text;
            string tenSach = txbBookName.Text;
            string viTri = txbBookPosition.Text;
            string maNXB = QLBS_BUS.Instance.GetNXBByName(cbbNXB.SelectedItem.ToString()).Ma_NXB;
            int tinhTrang = cbbStatusBook.SelectedIndex;
            string theLoai = QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).Ma_TL;

            if (maSach == "" && tenSach == "" && viTri == "" && cbbNXB.SelectedIndex == 0 && cbbStatusBook.SelectedIndex == 0 && cbbBookCategory.SelectedIndex == 0)
            {
                dtgvBookInfo.DataSource = QLBS_BUS.Instance.GetListBook();
                return;
            }
            dtgvBookInfo.DataSource = QLBS_BUS.Instance.GetListBookByInfo(maSach, tenSach, maNXB, tinhTrang, theLoai);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetCBB();
            SetGUI();
        }

        private void cbbBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBookCategory.SelectedIndex > 0)
            {
                txbBookPosition.Text = QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).ViTri;
            }
            else txbBookPosition.Text = "";
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvBookInfo.SelectedRows;
            if (r.Count == 1)
            {
                string path = "";
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pbBookImage.Image = Image.FromFile(dialog.FileName);
                        path = dialog.FileName;
                        SACH sach = QLBS_BUS.Instance.GetBookByID(r[0].Cells["Ma_S"].Value.ToString());
                        sach.imgPath = path;
                        QLBS_BUS.Instance.UpdateBook(sach);
                        MessageBox.Show("Bạn đã chọn ảnh cho cuốn " + r[0].Cells["Ten_S"].Value.ToString() + " Thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvBookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvBookInfo.SelectedRows;
            if (r.Count == 1)
            {
                SACH sach = QLBS_BUS.Instance.GetBookByID(r[0].Cells["Ma_S"].Value.ToString());
                txbBookCode.Text = r[0].Cells["Ma_S"].Value.ToString();
                try
                {
                    if (sach.imgPath != null)
                    {
                        Image img = Image.FromFile(sach.imgPath);
                        if (img == null)
                        {
                            img = Image.FromFile(nullImagePath);
                        }
                        pbBookImage.Image = img;
                    }
                    else
                    {
                        pbBookImage.Image = Image.FromFile(nullImagePath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbBookCode_TextChanged(object sender, EventArgs e)
        {
            SACH s = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            if (s.Ma_S == txbBookCode.Text)
            {
                THELOAI theloai = QLBS_BUS.Instance.GetBookCategoryByID(s.Ma_TL);
                NXB nxb = QLBS_BUS.Instance.GetNXBByID(s.Ma_NXB);
                txbBookName.Text = s.Ten_S;
                txbBookPrice.Text = s.Gia.ToString();
                cbbBookCategory.SelectedIndex = cbbBookCategory.FindStringExact(theloai.Ten_TL);
                cbbNXB.SelectedIndex = cbbNXB.FindStringExact(nxb.Ten_NXB);
                cbbStatusBook.SelectedIndex = cbbStatusBook.FindStringExact(((bool)(s.TinhTrang) ? "Mới" : "Cũ"));
                nmBookAmount.Value = Convert.ToInt32(s.SoLuong);
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật sách " + txbBookName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (txbBookCode.Text == "" || txbBookName.Text == "" || txbBookPrice.Text == "" || cbbNXB.SelectedIndex == 0 || cbbBookCategory.SelectedIndex == 0 || cbbStatusBook.SelectedIndex == 0)
            {
                MessageBox.Show("Thông tin chưa đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (QLBS_BUS.Instance.GetBookByID(txbBookCode.Text).Ma_S != txbBookCode.Text)
            {
                MessageBox.Show("Mã sách không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int value;
            if (!int.TryParse(txbBookPrice.Text, out value))
            {
                MessageBox.Show("Lỗi giá sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SACH sach = new SACH();
            sach.Ma_S = txbBookCode.Text;
            sach.Ten_S = txbBookName.Text;
            sach.Ma_NXB = QLBS_BUS.Instance.GetNXBByName(cbbNXB.SelectedItem.ToString()).Ma_NXB;
            sach.Ma_TL = QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).Ma_TL;
            sach.SoLuong = (int)nmBookAmount.Value;
            sach.TinhTrang = (cbbStatusBook.SelectedIndex == 1) ? true : false;
            sach.Gia = Convert.ToDouble(txbBookPrice.Text);
            if (MessageBox.Show("Chọn ảnh cho sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = "";
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pbBookImage.Image = Image.FromFile(dialog.FileName);
                        path = dialog.FileName;
                        sach.imgPath = path;
                        MessageBox.Show("Bạn đã chọn ảnh cho cuốn " + sach.Ten_S + " Thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            QLBS_BUS.Instance.UpdateBook(sach);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvBookInfo.SelectedRows;
            if (r.Count == 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sách " + txbBookName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                string MaS = r[0].Cells["Ma_S"].Value.ToString();
                QLBS_BUS.Instance.DeleteCustomer(MaS);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCategory f = new FormCategory();
            f.ShowDialog();
            SetCBB();
            SetGUI();
        }

        private void dtgvDetailReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvDetailReceipt.SelectedRows;
            if (r.Count == 1)
            {
                SACH sach = QLBS_BUS.Instance.GetBookByID(r[0].Cells["Ma_S"].Value.ToString());
                try
                {
                    if (sach.imgPath != null)
                    {
                        Image img = Image.FromFile(sach.imgPath);
                        if (img == null)
                        {
                            img = Image.FromFile(nullImagePath);
                        }
                        pbBookImageReceipt.Image = img;
                    }
                    else
                    {
                        pbBookImageReceipt.Image = Image.FromFile(nullImagePath);
                    }
                    lbBookName.Text = sach.Ten_S;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
