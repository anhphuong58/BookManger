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
    public partial class FormFindStaff : Form
    {
        public FormFindStaff()
        {
            InitializeComponent();
            SetCBB();
            SetGUI();
        }
        private void SetCBB()
        {
            cbbStaffCode.Items.Add(new CBBItem { Value = 0, Text = "" });
            cbbStaffCode.Items.AddRange(QLBS_BUS.Instance.GetListCBBStaff().ToArray());
        }
        private void SetGUI()
        {
            cbbStaffCode.SelectedIndex = 0;
            dtgvListStaff.DataSource = QLBS_BUS.Instance.GetListStaff();
            if (dtgvListStaff.Rows.Count > 0)
            {
                dtgvListStaff.Columns[0].HeaderText = "Mã nhân viên";
                dtgvListStaff.Columns[1].HeaderText = "Tên nhân viên";
                dtgvListStaff.Columns[2].HeaderText = "Số CMND";
                dtgvListStaff.Columns[3].HeaderText = "Số điện thoại";
                dtgvListStaff.Columns[4].HeaderText = "Email";
                dtgvListStaff.Columns[5].HeaderText = "Địa chỉ";
                dtgvListStaff.Columns[6].HeaderText = "Chức vụ";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenNV = txbStaffName.Text;
            string email = txbStaffEmail.Text;
            string address = txbStaffAddress.Text;
            string phone = txbStaffPhone.Text;
            string position = txbStaffPosition.Text;
            string soCMND = txbSoCMND.Text;
            if(cbbStaffCode.SelectedIndex == 0 && tenNV == "" && email == "" && address == "" && phone == "" && position == "" && soCMND == "")
            {
                dtgvListStaff.DataSource = QLBS_BUS.Instance.GetListStaff();
                return;
            }

            if(cbbStaffCode.SelectedIndex != 0)
            {
                QUANLINHANVIEN nv = QLBS_BUS.Instance.GetStaffFromID(cbbStaffCode.SelectedItem.ToString());
                List<QUANLINHANVIEN> list = new List<QUANLINHANVIEN>();
                list.Add(nv);
                dtgvListStaff.DataSource = list;
            }
            else dtgvListStaff.DataSource = QLBS_BUS.Instance.GetListStaffByInfo(tenNV, email, address, phone, position, soCMND);
        }

        private void cbbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = cbbStaffCode.SelectedItem.ToString();
            QUANLINHANVIEN staff = QLBS_BUS.Instance.GetStaffFromID(ID);
            txbStaffName.Text = staff.Ten_NV;
            txbStaffEmail.Text = staff.Email;
            txbStaffAddress.Text = staff.DiaChi;
            txbStaffPhone.Text = staff.SDT;
            txbStaffPosition.Text = staff.ChucVu;
            txbSoCMND.Text = staff.SoCMND;
        }

        private void dtgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListStaff.SelectedRows;
            if (r.Count == 1)
            {
                string maNV = r[0].Cells["Ma_NV"].Value.ToString();
                cbbStaffCode.SelectedIndex = cbbStaffCode.FindStringExact(maNV);
            }
        }

        private void btnRepress_Click(object sender, EventArgs e)
        {
            SetGUI();
        }

        private void btnChooseStaff_Click(object sender, EventArgs e)
        {
            QUANLINHANVIEN nv = QLBS_BUS.Instance.GetStaffFromID(cbbStaffCode.SelectedItem.ToString());
            if(cbbStaffCode.SelectedIndex > 0 && txbStaffName.Text == nv.Ten_NV && txbStaffEmail.Text == nv.Email && txbStaffAddress.Text == nv.DiaChi && txbStaffPhone.Text == nv.SDT && txbStaffPosition.Text == nv.ChucVu && txbSoCMND.Text == nv.SoCMND)
            {
                FormBill.IDNhanVien = cbbStaffCode.SelectedItem.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin từ các text không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
