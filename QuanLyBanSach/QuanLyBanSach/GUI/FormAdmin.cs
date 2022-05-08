using QuanLyBanSach.BUS;
using QuanLyBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            setCBB();
            SetGUI();
        }
        private void setCBB()
        {
            // tao combobox kiểm tra các quyền
            cbbGrant.Items.Clear();
            cbbGrant.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbGrant.Items.Add(new CBBItem { Value = 1, Text = "Quyền quản lý nhân viên" });
            cbbGrant.Items.Add(new CBBItem { Value = 2, Text = "Quyền tạo phiếu nhập" });
            cbbGrant.Items.Add(new CBBItem { Value = 2, Text = "Toàn quyền quản trị" });
            cbbGrant.SelectedIndex = 0;
        }
        private void SetGUI()
        {
            dtgvListStaff.DataSource = QLBS_BUS.Instance.GetListStaffAdmin();
            if (dtgvListStaff.Rows.Count > 0)
            {
                dtgvListStaff.Columns[0].HeaderText = "Mã nhân viên";
                dtgvListStaff.Columns[1].HeaderText = "Tên nhân viên";
                dtgvListStaff.Columns[2].HeaderText = "Số CMND";
                dtgvListStaff.Columns[3].HeaderText = "Số điện thoại";
                dtgvListStaff.Columns[4].HeaderText = "Email";
                dtgvListStaff.Columns[5].HeaderText = "Địa chỉ";
                dtgvListStaff.Columns[6].HeaderText = "Chức vụ";
                dtgvListStaff.Columns[7].HeaderText = "Lương";
                dtgvListStaff.Columns[8].HeaderText = "Ngày bất đầu";
            }
            txbStaffCode.Clear();
            txbStaffName.Clear();
            txbStaffCMND.Clear();
            txbStaffAddress.Clear();
            txbStaffPass.Clear();
            txbReNewPassword.Clear();
            txbStaffPhone.Clear();
            txbStaffEmail.Clear();
            txbStaffPosition.Clear();
            txbStaffSalary.Clear();
            txbStaffSearch.Clear();
            txbStaffPass.Clear();
            txbReStaffPass.Clear();
            dtpStaffStart.Value = DateTime.Now;
            btnGrantStaff.Text = "cấp quyền quản trị";
            btnGrantReceipt.Text = "cấp quyền tạo phiếu nhập";
        }
        // thay đổi mật khẩu quản trị viên
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!QLBS_BUS.Instance.Login("Admin", txbAdminOldPassword.Text))
            {
                MessageBox.Show("Sai mật khẩu Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbAdminOldPassword.Clear();
                txbNewPassword.Clear();
                txbReNewPassword.Clear();
                return;
            }
            if (txbNewPassword.Text != txbReNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbAdminOldPassword.Clear();
                txbNewPassword.Clear();
                txbReNewPassword.Clear();
                return;
            }
            if (txbNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu không đủ kí tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbAdminOldPassword.Clear();
                txbNewPassword.Clear();
                txbReNewPassword.Clear();
                return;
            }
            QUANLINHANVIEN admin = new QUANLINHANVIEN();
            admin.Ma_NV = "Admin";
            admin.Ten_NV = "Admin";
            admin.DiaChi = "Đà Nẵng";
            admin.Email = "";
            admin.SoCMND = "000000000";
            admin.SDT = "";
            admin.ChucVu = "";
            admin.Luong = 0;
            admin.NgayBatDau = DateTime.Now;
            admin.MatKhau = txbNewPassword.Text;
            QLBS_BUS.Instance.UpdateStaff(admin);
            MessageBox.Show("Thay đổi mật khẩu admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbAdminOldPassword.Clear();
            txbNewPassword.Clear();
            txbReNewPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            string keyWord = this.txbStaffSearch.Text;
            bool admin = false;
            bool receipt = false;
            if (keyWord == "" && cbbGrant.SelectedIndex == 0) dtgvListStaff.DataSource = QLBS_BUS.Instance.GetListStaffAdmin();
            else
            {
                if(cbbGrant.SelectedIndex == 0)
                {
                    dtgvListStaff.DataSource = QLBS_BUS.Instance.GetStaffFromKeywordAllGrant(keyWord);
                    return;
                }
                if (cbbGrant.SelectedIndex == 1) admin = true;
                if (cbbGrant.SelectedIndex == 2) receipt = true;
                if (cbbGrant.SelectedIndex == 3)
                {
                    admin = receipt = true;
                }
                    
                dtgvListStaff.DataSource = QLBS_BUS.Instance.GetStaffFromKeyword(keyWord, admin, receipt);
            }
        }

        private void dtgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListStaff.SelectedRows;
            if(r.Count == 1)
            {
                QUANLINHANVIEN nv = QLBS_BUS.Instance.GetStaffByCode(r[0].Cells["Ma_NV"].Value.ToString());
                txbStaffCode.Text = nv.Ma_NV;
                txbStaffName.Text = nv.Ten_NV;
                txbStaffCMND.Text = nv.SoCMND;
                txbStaffAddress.Text = nv.DiaChi;
                txbStaffEmail.Text = nv.Email;
                txbStaffPhone.Text = nv.SDT;
                txbStaffPosition.Text = nv.ChucVu;
                txbStaffSalary.Text = nv.Luong.ToString();
                dtpStaffStart.Value = (DateTime)nv.NgayBatDau;
                btnGrantStaff.Text = ((bool)nv.QuyenQuanTriNhanVien) ? "Hủy quyền quản trị" : "Thêm quyền quản trị";
                btnGrantReceipt.Text = ((bool)nv.QuyenTaoPhieuNhap) ? "Hủy tạo phiếu nhập" : "Thêm quyền tạo phiếu nhập";
            }
        }
        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            if (QLBS_BUS.Instance.GetStaffByCode(txbStaffCode.Text).Ma_NV == txbStaffCode.Text)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txbStaffCode.Text == "")
            {
                MessageBox.Show("Chưa có mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txbStaffName.Text == "" || txbStaffCMND.Text == "" || txbStaffAddress.Text == "" || (txbStaffPhone.Text == "" || txbStaffEmail.Text == "") || txbStaffPosition.Text == "" || txbStaffSalary.Text == "" || txbStaffPass.Text == "" || txbReStaffPass.Text == "" || dtpStaffStart.Value == null)
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int value;
                if (!int.TryParse(txbStaffSalary.Text, out value) || !int.TryParse(txbStaffCMND.Text, out value))
                {
                    MessageBox.Show("Lỗi định dạng thông tin, vui lòng kiểm tra lương hoặc số CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txbStaffEmail.Text != "")
                {
                    if (txbStaffEmail.Text.Length < 10 || txbStaffEmail.Text.Substring(txbStaffEmail.Text.Length - 10, 10) != "@gmail.com")
                    {
                        MessageBox.Show("Tài khoản gmail không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txbStaffPhone.Text != "")
                {
                    if ((txbStaffPhone.Text.Length < 10 || txbStaffPhone.Text.Length > 11) || !int.TryParse(txbStaffPhone.Text, out value))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffEmail.Text).Email == txbStaffEmail.Text ||
                    QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffPhone.Text).SDT == txbStaffPhone.Text ||
                    QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffCMND.Text).SoCMND == txbStaffCMND.Text)
                {
                    MessageBox.Show("Lỗi số điện thoại, email hoặc số CMND bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txbStaffPass.Text != txbReStaffPass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txbStaffPass.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có đủ 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                QUANLINHANVIEN nv = new QUANLINHANVIEN();
                nv.Ma_NV = txbStaffCode.Text;
                nv.Ten_NV = txbStaffName.Text;
                nv.DiaChi = txbStaffAddress.Text;
                nv.Email = txbStaffEmail.Text;
                nv.SDT = txbStaffPhone.Text;
                nv.SoCMND = txbStaffCMND.Text;
                nv.ChucVu = txbStaffPosition.Text;
                nv.Luong = Convert.ToInt32(txbStaffSalary.Text);
                nv.MatKhau = txbStaffPass.Text;
                nv.NgayBatDau = dtpStaffStart.Value;
                nv.QuyenQuanTriNhanVien = false;
                nv.QuyenTaoPhieuNhap = false;
                QLBS_BUS.Instance.AddStaff(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (QLBS_BUS.Instance.GetStaffFromID(txbStaffCode.Text).Ma_NV != txbStaffCode.Text)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txbStaffCode.Text == "")
            {
                MessageBox.Show("Chưa có mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txbStaffName.Text == "" || txbStaffCMND.Text == "" || txbStaffAddress.Text == "" || (txbStaffPhone.Text == "" || txbStaffEmail.Text == "") || txbStaffPosition.Text == "" || txbStaffSalary.Text == "" || txbStaffPass.Text == "" || txbReStaffPass.Text == "" || dtpStaffStart.Value == null)
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int value;
                if (!int.TryParse(txbStaffSalary.Text, out value) || !int.TryParse(txbStaffCMND.Text, out value))
                {
                    MessageBox.Show("Lỗi định dạng thông tin, vui lòng kiểm tra lương hoặc số CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txbStaffEmail.Text != "")
                {
                    if (txbStaffEmail.Text.Length < 10 || txbStaffEmail.Text.Substring(txbStaffEmail.Text.Length - 10, 10) != "@gmail.com")
                    {
                        MessageBox.Show("Tài khoản gmail không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txbStaffPhone.Text != "")
                {
                    if ((txbStaffPhone.Text.Length < 10 || txbStaffPhone.Text.Length > 11) || !int.TryParse(txbStaffPhone.Text, out value))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if ((QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffEmail.Text).Ma_NV != txbStaffCode.Text) &&
                    (QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffEmail.Text).Email == txbStaffEmail.Text))
                {
                    MessageBox.Show("Lỗi email bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffPhone.Text).Ma_NV != txbStaffCode.Text) && (QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffPhone.Text).SDT == txbStaffPhone.Text))
                {
                    MessageBox.Show("Lỗi số điện thoại bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffCMND.Text).Ma_NV != txbStaffCode.Text) && (QLBS_BUS.Instance.GetStaffFromPhoneOrEmailOrCMND(txbStaffCMND.Text).SDT == txbStaffCMND.Text))
                {
                    MessageBox.Show("Lỗi số CMND bị trùng lặp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txbStaffPass.Text != txbReStaffPass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txbStaffPass.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có đủ 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FormLogin f = new FormLogin(1);
                f.ShowDialog();
                if (f.flat == 1)
                {
                    QUANLINHANVIEN nv = new QUANLINHANVIEN();
                    QUANLINHANVIEN old = QLBS_BUS.Instance.GetStaffByCode(txbStaffCode.Text);
                    nv.Ma_NV = txbStaffCode.Text;
                    nv.Ten_NV = txbStaffName.Text;
                    nv.DiaChi = txbStaffAddress.Text;
                    nv.Email = txbStaffEmail.Text;
                    nv.SDT = txbStaffPhone.Text;
                    nv.SoCMND = txbStaffCMND.Text;
                    nv.ChucVu = txbStaffPosition.Text;
                    nv.Luong = Convert.ToInt32(txbStaffSalary.Text);
                    nv.MatKhau = txbStaffPass.Text;
                    nv.NgayBatDau = dtpStaffStart.Value;
                    nv.QuyenQuanTriNhanVien = old.QuyenQuanTriNhanVien;
                    nv.QuyenTaoPhieuNhap = old.QuyenTaoPhieuNhap;
                    QLBS_BUS.Instance.UpdateStaff(nv);
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetGUI();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListStaff.SelectedRows;
            if (r.Count == 1)
            {
                FormLogin f = new FormLogin(1);
                f.ShowDialog();
                if (f.flat == 1)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng " + txbStaffName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    string MaNV = r[0].Cells["Ma_NV"].Value.ToString();
                    QLBS_BUS.Instance.DeleteStaff(MaNV);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
            }
        }

        private void btnGrantStaff_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListStaff.SelectedRows;
            if (r.Count == 1)
            {
                QUANLINHANVIEN nv = QLBS_BUS.Instance.GetStaffByCode(r[0].Cells["Ma_NV"].Value.ToString());
                if (nv.QuyenQuanTriNhanVien == false)
                {
                    if (MessageBox.Show("Cấp quyền quản trị nhân viên cho nhân viên này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    nv.QuyenQuanTriNhanVien = true;
                    QLBS_BUS.Instance.UpdateStaff(nv);
                    MessageBox.Show("Đã thêm quyền quản trị cho nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
                else
                {
                    if (MessageBox.Show("Hủy quyền quản trị của nhân viên này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    nv.QuyenQuanTriNhanVien = false;
                    QLBS_BUS.Instance.UpdateStaff(nv);
                    MessageBox.Show("Đã hủy quyền quản trị của nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGrantReceipt_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListStaff.SelectedRows;
            if (r.Count == 1)
            {
                QUANLINHANVIEN nv = QLBS_BUS.Instance.GetStaffByCode(r[0].Cells["Ma_NV"].Value.ToString());
                if (nv.QuyenTaoPhieuNhap == false)
                {
                    if (MessageBox.Show("Cấp quyền tạo phiếu nhập cho nhân viên này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    nv.QuyenTaoPhieuNhap = true;
                    QLBS_BUS.Instance.UpdateStaff(nv);
                    MessageBox.Show("Đã thêm quyền tạo nhiếu nhập cho nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
                else
                {
                    if (MessageBox.Show("Hủy quyền tạo phiếu nhập của nhân viên này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    nv.QuyenTaoPhieuNhap = false;
                    QLBS_BUS.Instance.UpdateStaff(nv);
                    MessageBox.Show("Đã hủy quyền tạo phiếu nhập của nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetGUI();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
