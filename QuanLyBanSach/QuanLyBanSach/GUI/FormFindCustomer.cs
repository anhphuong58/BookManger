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

namespace QuanLyBanSach
{
    public partial class FormFindCustomer : Form
    {
        public FormFindCustomer()
        {
            InitializeComponent();
            SetGUI();
        }
        private void SetGUI()
        {
            txbCustomerCode.Text = "";
            txbCustomerName.Text = "";
            txbCustomerPhone.Text = "";
            txbCustomerEmail.Text = "";
            txbCustomerAddress.Text = "";
            dtgvListCustomer.DataSource = QLBS_BUS.Instance.GetListCustomer();
            if(dtgvListCustomer.Rows.Count > 0)
            {
                dtgvListCustomer.Columns[0].HeaderText = "Mã khách hàng";
                dtgvListCustomer.Columns[1].HeaderText = "Tên khách hàng";
                dtgvListCustomer.Columns[2].HeaderText = "Địa chỉ";
                dtgvListCustomer.Columns[3].HeaderText = "Email";
                dtgvListCustomer.Columns[4].HeaderText = "Số điện thoại";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCustomerCode_TextChanged(object sender, EventArgs e)
        {
            KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromCode(txbCustomerCode.Text);
            if (kh.Ma_KH == txbCustomerCode.Text)
            {
                txbCustomerName.Text = kh.Ten_KH;
                txbCustomerPhone.Text = kh.SDT_KH;
                txbCustomerEmail.Text = kh.Email;
                txbCustomerAddress.Text = kh.DiaChi;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton nhap lai
            SetGUI();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maKH = txbCustomerCode.Text;
            string tenKH = txbCustomerName.Text;
            string address = txbCustomerAddress.Text;
            string email = txbCustomerEmail.Text;
            string phone = txbCustomerPhone.Text;

            if(maKH == "" && tenKH == "" && address == "" && email == "" && phone == "")
            {
                dtgvListCustomer.DataSource = QLBS_BUS.Instance.GetListCustomer();
                return;
            }
            
            dtgvListCustomer.DataSource = QLBS_BUS.Instance.GetListCustomerByInfo(maKH, tenKH, address, email, phone);

        }

        private void dtgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListCustomer.SelectedRows;
            if (r.Count == 1)
            {
                string MaKH = r[0].Cells["Ma_KH"].Value.ToString();
                txbCustomerCode.Text = MaKH;
            }
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = QLBS_BUS.Instance.GetCustomerFromCode(txbCustomerCode.Text);
            
            if (kh.Ten_KH == txbCustomerName.Text && kh.DiaChi == txbCustomerAddress.Text && kh.Email == txbCustomerEmail.Text && kh.SDT_KH == txbCustomerPhone.Text)
            {
                FormBill.IDKhachHang = txbCustomerCode.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin từ các text không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (QLBS_BUS.Instance.GetCustomerFromCode(txbCustomerCode.Text).Ma_KH != txbCustomerCode.Text)
            {
                MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txbCustomerName.Text == "")
                {
                    MessageBox.Show("Chưa có tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txbCustomerEmail.Text == "" && txbCustomerPhone.Text == "")
                {
                    MessageBox.Show("Phải có thông tin email hoặc số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txbCustomerEmail.Text != "")
                {
                    if(txbCustomerEmail.Text.Length < 10 || txbCustomerEmail.Text.Substring(txbCustomerEmail.Text.Length - 10, 10) != "@gmail.com")
                    {
                        MessageBox.Show("Tài khoản gmail không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if(txbCustomerPhone.Text != "")
                {
                    int value;
                    if((txbCustomerPhone.Text.Length < 10 || txbCustomerPhone.Text.Length > 11) || !int.TryParse(txbCustomerPhone.Text, out value))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if ((QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerEmail.Text).Ma_KH != txbCustomerCode.Text) &&
                    (QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerEmail.Text).Email == txbCustomerEmail.Text))
                {
                    MessageBox.Show("Lỗi email bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerPhone.Text).Ma_KH != txbCustomerCode.Text) && (QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerPhone.Text).SDT_KH == txbCustomerPhone.Text))
                {
                    MessageBox.Show("Lỗi số điện thoại bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KHACHHANG kh = new KHACHHANG();
                kh.Ma_KH = txbCustomerCode.Text;
                kh.Ten_KH = txbCustomerName.Text;
                kh.DiaChi = txbCustomerAddress.Text;
                kh.Email = txbCustomerEmail.Text;
                kh.SDT_KH = txbCustomerPhone.Text;
                QLBS_BUS.Instance.UpdateCustomer(kh);
                MessageBox.Show("Cập nhật khách hàng " + txbCustomerCode.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(QLBS_BUS.Instance.GetCustomerFromCode(txbCustomerCode.Text).Ma_KH == txbCustomerCode.Text)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txbCustomerCode.Text == "")
            {
                MessageBox.Show("Chưa có mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txbCustomerName.Text == "")
                {
                    MessageBox.Show("Chưa có tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txbCustomerEmail.Text == "" && txbCustomerPhone.Text == "")
                {
                    MessageBox.Show("Phải có thông tin email hoặc số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txbCustomerEmail.Text != "")
                {
                    if(txbCustomerEmail.Text.Length < 10 || txbCustomerEmail.Text.Substring(txbCustomerEmail.Text.Length - 10, 10) != "@gmail.com")
                    {
                        MessageBox.Show("Tài khoản gmail không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if(txbCustomerPhone.Text != "")
                {
                    int value;
                    if((txbCustomerPhone.Text.Length < 10 || txbCustomerPhone.Text.Length > 11) || !int.TryParse(txbCustomerPhone.Text, out value))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerEmail.Text).Email == txbCustomerEmail.Text || QLBS_BUS.Instance.GetCustomerFromPhoneOrEmail(txbCustomerPhone.Text).SDT_KH == txbCustomerPhone.Text)
                {
                    MessageBox.Show("Lỗi số điện thoại hoặc email bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KHACHHANG kh = new KHACHHANG();
                kh.Ma_KH = txbCustomerCode.Text;
                kh.Ten_KH = txbCustomerName.Text;
                kh.DiaChi = txbCustomerAddress.Text;
                kh.Email = txbCustomerEmail.Text;
                kh.SDT_KH = txbCustomerPhone.Text;
                QLBS_BUS.Instance.AddCustomer(kh);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListCustomer.SelectedRows;
            if(r.Count == 1)
            {
                if(MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng " + txbCustomerName.Text + "?","Thông báo" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                string MaKH = r[0].Cells["Ma_KH"].Value.ToString();
                QLBS_BUS.Instance.DeleteCustomer(MaKH);
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
        }
    }
}
