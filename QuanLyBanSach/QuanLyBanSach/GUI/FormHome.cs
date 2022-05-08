using QuanLyBanSach.BUS;
using QuanLyBanSach.DTO;
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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            SetCBB();
            SetGUI();
        }
        private void SetCBB()
        {
            // tao combobox nhan vien
            cbbStaffCode.Items.Clear();
            cbbStaffCode.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbStaffCode.Items.AddRange(QLBS_BUS.Instance.GetListCBBStaff().ToArray());
            cbbStaffCode.SelectedIndex = 0;
        }
        private void SetGUI()
        {
            // set combobox NXB
            cbbStaffCode.SelectedIndex = 0;
            dtgvOrderSearch.DataSource = QLBS_BUS.Instance.GetListHoaDon();
            if(dtgvOrderSearch.Rows.Count > 0)
            {
                dtgvOrderSearch.Columns[0].HeaderText = "Mã hóa đơn";
                dtgvOrderSearch.Columns[1].HeaderText = "Mã khách hàng";
                dtgvOrderSearch.Columns[2].HeaderText = "Mã nhân viên";
                dtgvOrderSearch.Columns[3].HeaderText = "Ngày bán";
                dtgvOrderSearch.Columns[4].HeaderText = "Tổng tiền";
            }
            dtgvDetailOrder.DataSource = null;
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbBookName.Text = "";
            txbOrderCode.Text = "";
            dtpkDayImport.Value = new DateTime(2015, 1, 1);
            dtpkDayTo.Value = DateTime.Now;
            txbMNMax.Text = txbMNMin.Text = "";
            cbbStaffCode.SelectedIndex = 0;
            txbCheckInfo.Text = "";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin(1);
            f.ShowDialog();
            if(f.flat == 1)
            {
                FormAdmin fa = new FormAdmin();
                fa.ShowDialog();
            }
        }

        private void quảnLýKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWarehouseManager f = new FormWarehouseManager();
            f.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRevenue f = new FormRevenue();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn tắt chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.ShowDialog();
            if(f.flat == 1)
            {
                FormBill fb = new FormBill();
                fb.ShowDialog();
            }
            SetCBB();
            SetGUI();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagerCustomer f = new FormManagerCustomer();
            f.ShowDialog();
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            FormFindStaff f = new FormFindStaff();
            f.ShowDialog();
        }

        private void bthCustomerSearch_Click(object sender, EventArgs e)
        {
            FormFindCustomer f = new FormFindCustomer();
            f.Text = "Tìm kiếm khách hàng";
            f.ShowDialog();
        }

        private void cbbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cbbStaffCode.SelectedItem.ToString();
            QUANLINHANVIEN staff = QLBS_BUS.Instance.GetStaffFromID(ID);
            txbStaffName.Text = staff.Ten_NV;
        }

        private void txbCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvOrderSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvOrderSearch.SelectedRows;
            if (r.Count == 1)
            {
                dtgvDetailOrder.Refresh();
                dtgvDetailOrder.DataSource = QLBS_BUS.Instance.GetChiTietHoaDon(r[0].Cells["Ma_HD"].Value.ToString());
                if(dtgvDetailOrder.Rows.Count > 0)
                {
                    dtgvDetailOrder.Columns[0].HeaderText = "Mã sách";
                    dtgvDetailOrder.Columns[1].HeaderText = "Tên sách";
                    dtgvDetailOrder.Columns[2].HeaderText = "Số lượng";
                    dtgvDetailOrder.Columns[3].HeaderText = "Đơn giá";
                }
                txbOrderCode.Text = r[0].Cells["Ma_HD"].Value.ToString();
            }
        }

        private void txbCheckInfo_TextChanged(object sender, EventArgs e)
        {
            if (txbCheckInfo.Text != "")
            {
                KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCheckInfo.Text);
                txbCustomerName.Text = kh.Ten_KH;
                txbCustomerCode.Text = kh.Ma_KH;
            }
            else
            {
                txbCustomerName.Text = "";
                txbCustomerCode.Text = "";
            }
        }

        private void bthCustomerSearch_Click_1(object sender, EventArgs e)
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

        private void cbbStaffCode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cbbStaffCode.SelectedIndex > 0)
            {
                string ID = cbbStaffCode.SelectedItem.ToString();
                QUANLINHANVIEN staff = QLBS_BUS.Instance.GetStaffFromID(ID);
                txbStaffName.Text = staff.Ten_NV;
            }
            else
            {
                txbStaffName.Text = "";
            }
        }

        private void btnStaffSearch_Click_1(object sender, EventArgs e)
        {
            FormFindStaff f = new FormFindStaff();
            f.ShowDialog();
            cbbStaffCode.SelectedIndex = cbbStaffCode.FindStringExact(FormBill.IDNhanVien);
        }

        private void btnSearch_order_Click(object sender, EventArgs e)
        {
            double value;
            if(txbOrderCode.Text == "" && dtpkDayImport.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && dtpkDayTo.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && txbMNMax.Text == "" && txbMNMin.Text == "" && cbbStaffCode.SelectedIndex == 0 && txbCheckInfo.Text == "")
            {
                SetCBB();
                SetGUI();
                return;
            }
            if (!double.TryParse(txbMNMin.Text, out value) && !double.TryParse(txbMNMax.Text, out value))
            {
                if (txbMNMin.Text != "" || txbMNMax.Text != "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại giá trị hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            double min = (txbMNMin.Text == "") ? 0 : Convert.ToDouble(txbMNMin.Text);
            double max = (txbMNMax.Text == "") ? 1000000000 : Convert.ToDouble(txbMNMax.Text);
            string MaNV = (cbbStaffCode.SelectedIndex > 0) ? cbbStaffCode.SelectedItem.ToString() : "";
            dtgvOrderSearch.DataSource = QLBS_BUS.Instance.GetListOrderByInfo(txbOrderCode.Text, txbCustomerCode.Text, dtpkDayImport.Value, dtpkDayTo.Value, MaNV, min, max);
            dtgvDetailOrder.DataSource = null;
        }

        private void dtgvDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvDetailOrder.SelectedRows;
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
                            img = Image.FromFile(FormWarehouseManager.nullImagePath);
                        }
                        pbBookImage.Image = img;
                    }
                    else
                    {
                        pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
                    }
                    lbBookName.Text = sach.Ten_S;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbOrderCode_TextChanged(object sender, EventArgs e)
        {
            if(QLBS_BUS.Instance.GetHoaDonByID(txbOrderCode.Text).Ma_HD == txbOrderCode.Text)
            {
                HOADON hd = QLBS_BUS.Instance.GetHoaDonByID(txbOrderCode.Text);
                dtpkDayImport.Value = dtpkDayTo.Value = (DateTime)hd.NgayBan;
                txbMNMax.Text = txbMNMin.Text = hd.TongTien.ToString();
                cbbStaffCode.SelectedIndex = cbbStaffCode.FindStringExact(hd.Ma_NV);
                KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromCode(hd.Ma_KH);
                if (kh.SDT_KH != "" || kh.SDT_KH != null)
                {
                    txbCheckInfo.Text = kh.SDT_KH;
                }
                else txbCheckInfo.Text = kh.Email;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCBB();
            SetGUI();
        }
    }
}
