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

namespace QuanLyBanSach
{
    public partial class FormBill : Form
    {
        int huy = 0;
        public static string IDSach;
        public static string IDKhachHang;
        public static string IDNhanVien;
        private DataTable data = new DataTable();
        public FormBill()
        {
            CreateTable();
            InitializeComponent();
            SetGUI();
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
        }
        private void SetGUI()
        {
            FormBill.IDSach = "";
            FormBill.IDKhachHang = "";
            lbStaffCode.Text = FormBill.IDNhanVien;
            lbStaffName.Text = QLBS_BUS.Instance.GetStaffByCode(FormBill.IDNhanVien).Ten_NV;
            // reset don vi tinh tien
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbbPriceUnit.SelectedIndex = 0;
            dtgvListBookSelected.DataSource = data;
            dtgvListBookSelected.Columns[0].HeaderText = "Mã sách";
            dtgvListBookSelected.Columns[1].HeaderText = "Tên sách";
            dtgvListBookSelected.Columns[2].HeaderText = "Nhà xuất bản";
            dtgvListBookSelected.Columns[3].HeaderText = "Thể loại";
            dtgvListBookSelected.Columns[4].HeaderText = "Tình trạng";
            dtgvListBookSelected.Columns[5].HeaderText = "Số lượng";
            dtgvListBookSelected.Columns[6].HeaderText = "Giá";
        }
        private string SetUnit(double tien)
        {
            string gia = "";
            if (cbbPriceUnit.SelectedIndex == 0)
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
                gia = tien.ToString("#,###", cul.NumberFormat) + "VND";

            }
            else if (cbbPriceUnit.SelectedIndex == 1)
            {
                tien /= 23061.5;
                if (tien < 1) gia = "0";
                gia += string.Format("{0:#.00}", Convert.ToDecimal(tien.ToString())) + " USD";
            }
            else if (cbbPriceUnit.SelectedIndex == 2)
            {
                tien /= 206;
                if (tien < 1) gia = "0";
                gia += string.Format("{0:#.00}", Convert.ToDecimal(tien.ToString())) +" YÊN";
            }
            return gia;
        }

        private void SetTotalMoney()
        {
            double totalmoney = 0;
            if (dtgvListBookSelected.RowCount == 0)
            {
                txbTotalMoney.Clear();
                lbReadNumber.Text = "";
            }
            else
            {
                foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
                {
                    totalmoney += (double)QLBS_BUS.Instance.GetBookByID(row.Cells["Ma_S"].Value.ToString()).Gia * Convert.ToDouble(row.Cells["SoLuong"].Value);
                }
                txbTotalMoney.Text = SetUnit(totalmoney);
                if (cbbPriceUnit.SelectedIndex == 0)
                {
                    lbReadNumber.Text = ReadNumber.NumberToText(totalmoney) + " " + cbbPriceUnit.SelectedItem.ToString();
                }
                else if (cbbPriceUnit.SelectedIndex == 1)
                {
                    lbReadNumber.Text = ReadNumber.NumberToText(totalmoney / 23061.5) + " " + cbbPriceUnit.SelectedItem.ToString();
                }
                else if (cbbPriceUnit.SelectedIndex == 2)
                {
                    lbReadNumber.Text = ReadNumber.NumberToText(totalmoney / 206) + " " + cbbPriceUnit.SelectedItem.ToString();
                }
            }
        }


        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            huy = 1;
            this.Close();
        }

        private void FormBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(huy == 1)
            {
                if (MessageBox.Show("Bạn muốn hủy hóa đơn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                {
                    huy = 0;
                    e.Cancel = true;
                }
                else
                {
                    FormBill.IDSach = "";
                    FormBill.IDKhachHang = "";
                    FormBill.IDNhanVien = "";
                }
            }
        }

        private void bthCustomerSearch_Click(object sender, EventArgs e)
        {
            FormFindCustomer f = new FormFindCustomer();
            f.Text = "Tìm kiếm khách hàng";
            f.ShowDialog();
            txbCustomerCode.Text = FormBill.IDKhachHang;
            KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromCode(txbCustomerCode.Text);
            txbCustomerName.Text = kh.Ten_KH;
            if (kh.SDT_KH != "")
                txbCheckInfo.Text = kh.SDT_KH;
            else
                txbCheckInfo.Text = kh.Email;
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            FormFindProduct f = new FormFindProduct();
            f.ShowDialog();
            SACH sach = QLBS_BUS.Instance.GetBookByID(FormBill.IDSach);
            txbBookCode.Text = FormBill.IDSach;
            this.nmBookAmount_ValueChanged(sender, e);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            // kiem tra dieu kien
            if(txbOrderCode.Text == "")
            {
                MessageBox.Show("Chưa chọn mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(QLBS_BUS.Instance.GetHoaDonByID(txbOrderCode.Text).Ma_HD == txbOrderCode.Text)
                {
                    MessageBox.Show("Mã hóa đơn bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (txbTotalMoney.Text == "")
            {
                MessageBox.Show("Chưa chọn mặt hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double totalmoney = 0;
            HOADON hd = new HOADON();
            List<CHITIETHOADON> list = new List<CHITIETHOADON>();
            foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
            {
                totalmoney += (double)QLBS_BUS.Instance.GetBookByID(row.Cells["Ma_S"].Value.ToString()).Gia * Convert.ToDouble(row.Cells["SoLuong"].Value);
            }
            if (txbCustomerCode.Text == "")
            {
                if(MessageBox.Show("Tạo hóa đơn mà không có mã khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    hd.Ma_HD = txbOrderCode.Text;
                    hd.Ma_KH = "NoName";
                    hd.Ma_NV = FormBill.IDNhanVien;
                    hd.NgayBan = DateTime.Now;
                    hd.TongTien = totalmoney;
                }
                else
                    return;
            }
            else
            {
                hd.Ma_HD = txbOrderCode.Text;
                hd.Ma_KH = txbCustomerCode.Text;
                hd.Ma_NV = FormBill.IDNhanVien;
                hd.NgayBan = DateTime.Now;
                hd.TongTien = totalmoney;
            }
            foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
            {
                CHITIETHOADON cthd = new CHITIETHOADON();
                cthd.Ma_HD = hd.Ma_HD;
                cthd.Ma_S = row.Cells["Ma_S"].Value.ToString();
                cthd.Ten_S = row.Cells["Ten_S"].Value.ToString();
                cthd.DonGia = QLBS_BUS.Instance.GetBookByID(row.Cells["Ma_S"].Value.ToString()).Gia;
                cthd.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                list.Add(cthd);
                SACH sach = QLBS_BUS.Instance.GetBookByID(cthd.Ma_S);
                sach.SoLuong -= cthd.SoLuong;
                QLBS_BUS.Instance.UpdateBook(sach);
            }
            QLBS_BUS.Instance.AddOrder(hd, list);
            MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormBill.IDSach = "";
            FormBill.IDKhachHang = "";
            FormBill.IDNhanVien = "";
        }

        private void txbBookCode_TextChanged(object sender, EventArgs e)
        {
            string ID = txbBookCode.Text;
            SACH s = QLBS_BUS.Instance.GetBookByID(ID);
            txbBookName.Text = s.Ten_S;
            txbBookPrice.Text = (s.Gia).ToString();
            txbBookStatus.Text = (s.TinhTrang != null) ? (((bool)s.TinhTrang) ? "Mới" : "Cũ") : "";
            if(s.SoLuong != null)
            {
                if(s.SoLuong == 0)
                {
                    nmBookAmount.Maximum = 1;
                }
                else nmBookAmount.Maximum = (int)s.SoLuong;
                nmBookAmount.Value = 1;
            }
            

        }

        private void txbCheckInfo_TextChanged(object sender, EventArgs e)
        {
            if(txbCheckInfo.Text != "")
            {
                KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCheckInfo.Text);
                txbCustomerName.Text = kh.Ten_KH;
                txbCustomerCode.Text = kh.Ma_KH;
            }
        }

        private void nmBookAmount_ValueChanged(object sender, EventArgs e)
        {
            if(txbBookPrice.Text != "")
            {
                txbIntoMoney.Text = SetUnit(double.Parse(txbBookPrice.Text) * (double)nmBookAmount.Value);
            }
        }

        private void cbbPriceUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nmBookAmount_ValueChanged(sender, e);
            if(dtgvListBookSelected.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
                {
                    double gia = (double)QLBS_BUS.Instance.GetBookByID(row.Cells["Ma_S"].Value.ToString()).Gia * Convert.ToDouble(row.Cells["SoLuong"].Value);
                    row.Cells["Gia"].Value = SetUnit(gia);
                }
            }
            SetTotalMoney();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            SACH sach = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            if (sach.Ma_S == txbBookCode.Text)
            {
                foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
                {
                    if (row.Cells["Ma_S"].Value.ToString() == sach.Ma_S)
                    {
                        if (Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()) + nmBookAmount.Value > sach.SoLuong)
                        {
                            MessageBox.Show("Số lượng sách không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        row.Cells["SoLuong"].Value = (Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()) + nmBookAmount.Value).ToString();
                        row.Cells["Gia"].Value = SetUnit(Convert.ToDouble(Convert.ToDouble(row.Cells["SoLuong"].Value.ToString()) * sach.Gia));
                        SetTotalMoney();
                        return;
                    }
                }
                if (Convert.ToInt32(nmBookAmount.Value) > sach.SoLuong)
                {
                    MessageBox.Show("Số lượng sách không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maSach = sach.Ma_S;
                string tenSach = sach.Ten_S;
                string NXB = QLBS_BUS.Instance.GetNXBByID(sach.Ma_NXB).Ten_NXB;
                string theloai = QLBS_BUS.Instance.GetBookCategoryByID(sach.Ma_TL).Ten_TL;
                string tinhtrang = (sach.TinhTrang == true) ? "Mới" : "Cũ";
                string soluong = nmBookAmount.Value.ToString();
                string gia = txbIntoMoney.Text;
                data.Rows.Add(maSach, tenSach, NXB, theloai, tinhtrang, soluong, gia);
                dtgvListBookSelected.DataSource = data;
                SetTotalMoney();
            }
        }

        private void dtgvListBookSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListBookSelected.SelectedRows;
            if(r.Count == 1)
            {
                SACH sach = QLBS_BUS.Instance.GetBookByID(r[0].Cells["Ma_S"].Value.ToString());
                txbBookCode.Text = r[0].Cells["Ma_S"].Value.ToString();
                nmBookAmount.Value = Convert.ToInt32(r[0].Cells["SoLuong"].Value.ToString());
                try
                {
                    if (sach.imgPath != null)
                    {
                        Image img = Image.FromFile(sach.imgPath);
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

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SACH sach = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            foreach (DataGridViewRow row in dtgvListBookSelected.Rows)
            {
                if (row.Cells["Ma_S"].Value.ToString() == sach.Ma_S)
                {
                    
                    if(nmBookAmount.Value == Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()))
                    {
                        if (MessageBox.Show("Bạn muốn xóa hết sách " + sach.Ten_S + " trong hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            dtgvListBookSelected.Rows.Remove(row);
                        }
                    }
                    else if(nmBookAmount.Value < Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()))
                    {
                        if (MessageBox.Show("Bạn muốn xóa sách " + sach.Ten_S + " (" + nmBookAmount.Value.ToString() + " cuốn)?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                        {
                            row.Cells["SoLuong"].Value = (Convert.ToInt32(row.Cells["SoLuong"].Value.ToString()) - nmBookAmount.Value).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sách muốn xóa lớn hơn số lượng sách đã đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    SetTotalMoney();
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy sách phù hợp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dtgvListBookSelected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SetTotalMoney();
        }

    }
}
