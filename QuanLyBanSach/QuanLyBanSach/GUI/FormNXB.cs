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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
            SetGUI();
        }
        private void SetGUI()
        {
            txbNXBCode.Text = "";
            txbNXBName.Text = "";
            txbNXBAddress.Text = "";
            txbNXBPhone.Text = "";
            dtgvListNXB.DataSource = QLBS_BUS.Instance.GetListNXB();
            if(dtgvListNXB.Rows.Count > 0)
            {
                dtgvListNXB.Columns["Ma_NXB"].HeaderText = "Mã nhà xuất bản";
                dtgvListNXB.Columns["Ten_NXB"].HeaderText = "Tên nhà xuất bản";
                dtgvListNXB.Columns["DiaChi_NXB"].HeaderText = "Địa chỉ nhà xuất bản";
                dtgvListNXB.Columns["SDT_NXB"].HeaderText = "SĐT nhà xuất bản";
            }
        }

        private void dtgvListNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvListNXB.SelectedRows;
            if(r.Count == 1)
            {
                txbNXBCode.Text = r[0].Cells["Ma_NXB"].Value.ToString();
                txbNXBName.Text = r[0].Cells["Ten_NXB"].Value.ToString();
                txbNXBAddress.Text = r[0].Cells["DiaChi_NXB"].Value.ToString();
                txbNXBPhone.Text = r[0].Cells["SDT_NXB"].Value.ToString();
            }
        }

        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            if(txbNXBCode.Text == "" || txbNXBName.Text == "" || txbNXBAddress.Text == "" || txbNXBPhone.Text == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(QLBS_BUS.Instance.GetNXBByID(txbNXBCode.Text).Ma_NXB != null)
            {
                MessageBox.Show("Trùng mã nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (QLBS_BUS.Instance.GetNXBByName(txbNXBName.Text).Ten_NXB == txbNXBName.Text)
            {
                MessageBox.Show("Trùng tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txbNXBPhone.Text == QLBS_BUS.Instance.GetNXBByPhone(txbNXBPhone.Text).SDT_NXB)
            {
                MessageBox.Show("Trùng số điện thoại NXB!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NXB nxb = new NXB();
            nxb.Ma_NXB = txbNXBCode.Text;
            nxb.Ten_NXB = txbNXBName.Text;
            nxb.DiaChi_NXB = txbNXBAddress.Text;
            nxb.SDT_NXB = txbNXBPhone.Text;
            QLBS_BUS.Instance.AddNXB(nxb);
            MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetGUI();
        }

        private void btnEditNXB_Click(object sender, EventArgs e)
        {
            if (txbNXBCode.Text == "" || txbNXBName.Text == "" || txbNXBAddress.Text == "" || txbNXBPhone.Text == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbNXBCode.Text == QLBS_BUS.Instance.GetNXBByID(txbNXBCode.Text).Ma_NXB.ToString())
            {
                if (QLBS_BUS.Instance.GetNXBByName(txbNXBName.Text).Ten_NXB == txbNXBName.Text && txbNXBCode.Text != QLBS_BUS.Instance.GetNXBByName(txbNXBName.Text).Ma_NXB.ToString())
                {
                    MessageBox.Show("Trùng tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txbNXBPhone.Text == QLBS_BUS.Instance.GetNXBByPhone(txbNXBPhone.Text).SDT_NXB && txbNXBCode.Text == QLBS_BUS.Instance.GetNXBByPhone(txbNXBPhone.Text).Ma_NXB.ToString())
                {
                    MessageBox.Show("Trùng số điện thoại NXB!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NXB nxb = new NXB();
                nxb.Ma_NXB = txbNXBCode.Text;
                nxb.Ten_NXB = txbNXBName.Text;
                nxb.DiaChi_NXB = txbNXBAddress.Text;
                nxb.SDT_NXB = txbNXBPhone.Text;
                QLBS_BUS.Instance.UpdateNXB(nxb); MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
            else
            {
                MessageBox.Show("Mã nhà xuất bản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDeleteNXB_Click(object sender, EventArgs e)
        {
            if(txbNXBCode.Text == QLBS_BUS.Instance.GetNXBByID(txbNXBCode.Text).Ma_NXB)
            {
                NXB nxb = QLBS_BUS.Instance.GetNXBByID(txbNXBCode.Text);
                if(txbNXBAddress.Text != nxb.DiaChi_NXB || txbNXBName.Text != nxb.Ten_NXB || txbNXBPhone.Text != nxb.SDT_NXB)
                {
                    MessageBox.Show("Thông tin nhà xuất bản từ các text không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                QLBS_BUS.Instance.DeleteNXB(nxb.Ma_NXB);
                MessageBox.Show("Xóa nhà xuất bản" + nxb.Ten_NXB + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetGUI();
            }
            else
            {
                MessageBox.Show("Mã nhà xuất bản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
