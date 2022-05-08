using QuanLyBanSach.BUS;
using QuanLyBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.GUI
{
    public partial class FormReceipt : Form
    {
        public static string IDSach;
        private DataTable data = new DataTable();
        public FormReceipt()
        {
            CreateTable();
            InitializeComponent();
            SetCBB();
            SetGUI();
        }
        public FormReceipt(string nxb)
        {
            CreateTable();
            InitializeComponent();
            txbReceiptCode.Text = (QLBS_BUS.Instance.GetSoPNMax() + 1).ToString();
            txbNXB.Text = nxb;
            SetCBB();
            SetGUI();
        }
        private void SetCBB()
        {
            // tao combobox tinh trang sach
            cbbBookStatus.Items.Clear();
            cbbBookStatus.Items.Add(new CBBItem { Value = 0, Text = "Mới" });
            cbbBookStatus.Items.Add(new CBBItem { Value = 1, Text = "Cũ" });

            // tao combobox the loai sach
            cbbBookCategory.Items.Clear();
            cbbBookCategory.Items.AddRange(QLBS_BUS.Instance.GetListCBBCategory().ToArray());

            dtpkDayImport.Value = DateTime.Now;
        }
        private void SetGUI()
        {
            // thiet lap combobox tinh trang sach
            cbbBookStatus.SelectedIndex = 0;
            // thiet lap combobox the loai sach
            if(cbbBookCategory.Items.Count > 0)
            {
                cbbBookCategory.SelectedIndex = 0;
            }
            dtgvListBook.DataSource = data;
            dtgvListBook.Columns[0].HeaderText = "Mã sách";
            dtgvListBook.Columns[1].HeaderText = "Tên sách";
            dtgvListBook.Columns[2].HeaderText = "Nhà xuất bản";
            dtgvListBook.Columns[3].HeaderText = "Thể loại";
            dtgvListBook.Columns[4].HeaderText = "Tình trạng";
            dtgvListBook.Columns[5].HeaderText = "Số lượng";
            dtgvListBook.Columns[6].HeaderText = "Giá";
            dtgvListBook.Columns[7].Visible = false;
            //
            lbReadNumber.Text = "";
            lbTotalMoney.Text = "";
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateTable()
        {
            data.Columns.Add("Ma_S");
            data.Columns.Add("Ten_S");
            data.Columns.Add("NXB");
            data.Columns.Add("TheLoai");
            data.Columns.Add("TinhTrang");
            data.Columns.Add("SoLuong");
            data.Columns.Add("Gia");
            data.Columns.Add("imgPath");
        }
        private void SetTotalMoney()
        {
            double totalmoney = 0;
            if (dtgvListBook.RowCount == 0)
            {
                lbTotalMoney.Text = "";
                lbReadNumber.Text = "";
            }
            else
            {
                foreach (DataGridViewRow row in dtgvListBook.Rows)
                {
                    totalmoney += Convert.ToDouble(row.Cells["Gia"].Value) * Convert.ToDouble(row.Cells["SoLuong"].Value);
                }
                string gia = "";
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                gia = totalmoney.ToString("#,###", cul.NumberFormat) + " VND";
                lbTotalMoney.Text = gia;
                lbReadNumber.Text = ReadNumber.NumberToText(totalmoney) + " VND";
            }
        }
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            FormReceipt.IDSach = "";
            FormFindProduct f = new FormFindProduct();
            f.ShowDialog();
            if(FormReceipt.IDSach != "")
            {
                if (QLBS_BUS.Instance.GetBookByID(FormReceipt.IDSach).Ma_NXB != QLBS_BUS.Instance.GetNXBByName(txbNXB.Text).Ma_NXB)
                {
                    MessageBox.Show("NXB sách đã chọn không phù hợp với NXB phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txbBookCode.Text = FormReceipt.IDSach;
                nmBookAmount.Value = 1;
            }
        }

        private void txbBookCode_TextChanged(object sender, EventArgs e)
        {
            SACH s = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            if (txbBookCode.Text == s.Ma_S)
            {
                if (s.Ma_NXB != QLBS_BUS.Instance.GetNXBByName(txbNXB.Text).Ma_NXB)
                {
                    return;
                }
                THELOAI theloai = QLBS_BUS.Instance.GetBookCategoryByID(s.Ma_TL);
                txbBookName.Text = s.Ten_S;
                cbbBookCategory.SelectedIndex = cbbBookCategory.FindStringExact(theloai.Ten_TL);
                cbbBookStatus.SelectedIndex = cbbBookStatus.FindStringExact(((bool)(s.TinhTrang) ? "Mới" : "Cũ"));
                nmBookAmount.Value = 1;
                txbBookPrice.Text = s.Gia.ToString();
                txbBookName.Enabled = false;
                txbBookPrice.Enabled = false;
                cbbBookStatus.Enabled = false;
                cbbBookCategory.Enabled = false;
            }
            else
            {
                txbBookName.Text = "";
                if(cbbBookCategory.Items.Count > 0)
                {
                    cbbBookCategory.SelectedIndex = 0;
                }
                cbbBookStatus.SelectedIndex = 0;
                nmBookAmount.Value = 1;
                txbBookPrice.Text = "";
                txbBookName.Enabled = true;
                txbBookPrice.Enabled = true;
                cbbBookStatus.Enabled = true;
                cbbBookCategory.Enabled = true;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txbBookCode.Text == "" || txbBookName.Text == "" || txbBookPrice.Text == "")
            {
                MessageBox.Show("Thông tin sách từ các text chưa đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            if(QLBS_BUS.Instance.GetBookByID(txbBookCode.Text).Ma_S == txbBookCode.Text && QLBS_BUS.Instance.GetBookByID(txbBookCode.Text).Ma_NXB != QLBS_BUS.Instance.GetNXBByName(txbNXB.Text).Ma_NXB)
            {
                MessageBox.Show("Mã sách này đã tồn tại (nhà xuất bản khác)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbBookCategory.Items.Count == 0)
            {
                MessageBox.Show("Thể loại sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int value;
            if (!int.TryParse(txbBookPrice.Text, out value))
            {
                MessageBox.Show("Lỗi giá sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dtgvListBook.Rows)
            {
                if (row.Cells["Ma_S"].Value.ToString() == txbBookCode.Text)
                {
                    if (txbBookName.Text != row.Cells["Ten_S"].Value.ToString() || cbbBookStatus.SelectedItem.ToString() != row.Cells["TinhTrang"].Value.ToString() || cbbBookCategory.SelectedItem.ToString() != row.Cells["TheLoai"].Value.ToString() || txbBookPrice.Text != row.Cells["Gia"].Value.ToString())
                    {
                        MessageBox.Show("Thông tin sách từ các text không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    row.Cells["SoLuong"].Value = (Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()) + nmBookAmount.Value).ToString();
                    SetTotalMoney();
                    return;
                }
            }

            string maSach = txbBookCode.Text;
            string tenSach = txbBookName.Text;
            string NXB = txbNXB.Text;
            string theloai = cbbBookCategory.SelectedItem.ToString();
            string tinhtrang = (cbbBookStatus.SelectedIndex == 0) ? "Mới" : "Cũ";
            string soluong = nmBookAmount.Value.ToString();
            string gia = txbBookPrice.Text;
            string path = "";
            if (txbBookCode.Text != QLBS_BUS.Instance.GetBookByID(txbBookCode.Text).Ma_S && MessageBox.Show("Chọn ảnh cho sách mới này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path = dialog.FileName;
                        MessageBox.Show("Bạn đã chọn ảnh cho cuốn " + tenSach + " Thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else path = QLBS_BUS.Instance.GetBookByID(maSach).imgPath;
            data.Rows.Add(maSach, tenSach, NXB, theloai, tinhtrang, soluong, gia, path);
            dtgvListBook.DataSource = data;
            SetTotalMoney();
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormCategory f = new FormCategory();
            f.ShowDialog();
            SetCBB();
            SetGUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                return;
            }
            this.Close();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvListBook.Rows)
            {
                if (row.Cells["Ma_S"].Value.ToString() == txbBookCode.Text)
                {
                    if (txbBookName.Text != row.Cells["Ten_S"].Value.ToString() || cbbBookStatus.SelectedItem.ToString() != row.Cells["TinhTrang"].Value.ToString() || cbbBookCategory.SelectedItem.ToString() != row.Cells["TheLoai"].Value.ToString() || txbBookPrice.Text != row.Cells["Gia"].Value.ToString())
                    {
                        MessageBox.Show("Thông tin sách từ các text không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (nmBookAmount.Value == Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()))
                    {
                        if (MessageBox.Show("Bạn muốn xóa hết sách " + txbBookName.Text + " trong phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            dtgvListBook.Rows.Remove(row);
                        }
                    }
                    else if (nmBookAmount.Value < Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()))
                    {
                        if (MessageBox.Show("Bạn muốn xóa sách " + txbBookName.Text + " (" + nmBookAmount.Value.ToString() + " cuốn)?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            row.Cells["SoLuong"].Value = (Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()) - nmBookAmount.Value).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sách muốn xóa lớn hơn số lượng sách trong phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    SetTotalMoney();
                    return;
                }
            }
        }

        private void dtgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListBook.SelectedRows;
            if(r.Count == 1)
            {
                txbBookCode.Text = r[0].Cells["Ma_S"].Value.ToString();
                txbBookName.Text = r[0].Cells["Ten_S"].Value.ToString();
                txbBookPrice.Text = r[0].Cells["Gia"].Value.ToString();
                cbbBookCategory.SelectedIndex = cbbBookCategory.FindStringExact(r[0].Cells["TheLoai"].Value.ToString());
                cbbBookStatus.SelectedIndex = cbbBookStatus.FindStringExact(r[0].Cells["TinhTrang"].Value.ToString());
                try
                {
                    if (r[0].Cells["imgPath"].Value.ToString() != "")
                    {
                        Image img = Image.FromFile(r[0].Cells["imgPath"].Value.ToString());
                        if (img == null)
                        {
                            img = Image.FromFile(FormWarehouseManager.nullImagePath);
                        }
                        pbBookImage.Image = img;
                    }
                    else
                    {
                        pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            if (lbTotalMoney.Text == "")
            {
                MessageBox.Show("Chưa có sách nào trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double totalmoney = 0;
            PHIEUNHAP pn = new PHIEUNHAP();
            List<CHITIETPHIEUNHAP> list = new List<CHITIETPHIEUNHAP>();
            foreach (DataGridViewRow row in dtgvListBook.Rows)
            {
                totalmoney += Convert.ToDouble(row.Cells["Gia"].Value.ToString()) * Convert.ToDouble(row.Cells["SoLuong"].Value);
            }
            pn.So_PN = Convert.ToInt32(txbReceiptCode.Text);
            pn.Ma_NXB = QLBS_BUS.Instance.GetNXBByName(txbNXB.Text).Ma_NXB;
            pn.NgayNhap = dtpkDayImport.Value;
            pn.TongTien = totalmoney;
            foreach(DataGridViewRow row in dtgvListBook.Rows)
            {
                if(row.Cells["Ma_S"].Value.ToString() != QLBS_BUS.Instance.GetBookByID(row.Cells["Ma_S"].Value.ToString()).Ma_S)
                {
                    SACH sachmoi = new SACH();
                    sachmoi.Ma_S = row.Cells["Ma_S"].Value.ToString();
                    sachmoi.Ten_S = row.Cells["Ten_S"].Value.ToString();
                    sachmoi.Ma_NXB = QLBS_BUS.Instance.GetNXBByName(row.Cells["NXB"].Value.ToString()).Ma_NXB;
                    sachmoi.Ma_TL = QLBS_BUS.Instance.GetBookCategoryByName(row.Cells["TheLoai"].Value.ToString()).Ma_TL;
                    sachmoi.TinhTrang = (row.Cells["TinhTrang"].Value.ToString() == "Mới") ? true : false;
                    sachmoi.SoLuong = 0;
                    sachmoi.Gia = Convert.ToDouble(row.Cells["Gia"].Value);
                    if(row.Cells["imgPath"].Value.ToString() != "") sachmoi.imgPath = row.Cells["imgPath"].Value.ToString();
                    QLBS_BUS.Instance.AddBook(sachmoi);
                }
                CHITIETPHIEUNHAP ctpn = new CHITIETPHIEUNHAP();
                ctpn.So_PN = Convert.ToInt32(txbReceiptCode.Text);
                ctpn.Ma_S = row.Cells["Ma_S"].Value.ToString();
                ctpn.GiaNhap = Convert.ToDouble(row.Cells["Gia"].Value);
                ctpn.SoLuongNhap = Convert.ToInt32(row.Cells["SoLuong"].Value);
                list.Add(ctpn);
                SACH sach = QLBS_BUS.Instance.GetBookByID(ctpn.Ma_S);
                sach.SoLuong += ctpn.SoLuongNhap;
                QLBS_BUS.Instance.UpdateBook(sach);
            }
            QLBS_BUS.Instance.AddPN(pn, list);
            MessageBox.Show("Tạo phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormReceipt.IDSach = "";
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListBook.SelectedRows;
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
                        r[0].Cells["imgPath"].Value = path;
                        MessageBox.Show("Bạn đã chọn ảnh cho cuốn " + r[0].Cells["Ten_S"].Value.ToString() + " Thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
