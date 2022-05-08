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
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();
            SetGUI();
        }
        private void SetGUI()
        {
            dtpkDayFrom.Value = new DateTime(2015, 1, 1); ;
            dtpkDayTo.Value = DateTime.Now;
            rbExport.Checked = true;
            dtgvList.DataSource = QLBS_BUS.Instance.GetListOrder();
            if (dtgvList.Rows.Count > 0)
            {
                dtgvList.Columns[0].HeaderText = "Mã hóa đơn";
                dtgvList.Columns[1].HeaderText = "Mã khách hàng";
                dtgvList.Columns[2].HeaderText = "Mã ngày bán";
                dtgvList.Columns[3].HeaderText = "Mã nhân viên";
                dtgvList.Columns[4].HeaderText = "Tổng tiền";
            }
            SetTotalMoney();
            dtgvDetail.DataSource = null;
            lbBookName.Text = "";
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string SetUnit(double tien)
        {
            string gia = "";
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            gia = tien.ToString("#,###", cul.NumberFormat) + "VND";
            return gia;
        }
        private void SetTotalMoney()
        {
            double totalmoney = 0;
            if (dtgvList.RowCount == 0)
            {
                txbTotalMoney.Clear();
                lbReadNumber.Text = "";
            }
            else
            {
                if(dtgvList.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgvList.Rows)
                    {
                        totalmoney += Convert.ToDouble(row.Cells["TongTien"].Value.ToString());
                    }
                    txbTotalMoney.Text = SetUnit(totalmoney);
                    lbReadNumber.Text = ReadNumber.NumberToText(totalmoney) + " VND";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGUI();
        }

        private void btnSearchRevenue_Click(object sender, EventArgs e)
        {
            if(rbExport.Checked == true)
            {
                dtgvList.DataSource = QLBS_BUS.Instance.GetListOrderByInfo("","",dtpkDayFrom.Value, dtpkDayTo.Value,"",1,1000000000000);
                if(dtgvList.Rows.Count > 0)
                {
                    dtgvList.Columns[0].HeaderText = "Mã hóa đơn";
                    dtgvList.Columns[1].HeaderText = "Mã khách hàng";
                    dtgvList.Columns[2].HeaderText = "Mã ngày bán";
                    dtgvList.Columns[3].HeaderText = "Mã nhân viên";
                    dtgvList.Columns[4].HeaderText = "Tổng tiền";
                }
                dtgvDetail.DataSource = null;
            }
            else
            {
                dtgvList.DataSource = QLBS_BUS.Instance.GetListReceiptByInfo("","",dtpkDayFrom.Value,dtpkDayTo.Value);
                if(dtgvList.Rows.Count > 0)
                {
                    dtgvList.Columns[0].HeaderText = "Số phiếu nhập";
                    dtgvList.Columns[1].HeaderText = "Mã nhà xuất bản";
                    dtgvList.Columns[2].HeaderText = "Ngày nhập";
                    dtgvList.Columns[3].HeaderText = "Tổng tiền";
                }
                dtgvDetail.DataSource = null;
            }
            SetTotalMoney();
        }

        private void dtgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvList.SelectedRows;
            if(r.Count == 1)
            {
                if(dtgvList.Columns[0].HeaderText == "Mã hóa đơn")
                {
                    dtgvDetail.Refresh();
                    dtgvDetail.DataSource = QLBS_BUS.Instance.GetChiTietHoaDon(r[0].Cells["Ma_HD"].Value.ToString());
                    if(dtgvDetail.Rows.Count > 0)
                    {
                        dtgvDetail.Columns[0].HeaderText = "Mã sách";
                        dtgvDetail.Columns[1].HeaderText = "Tên sách";
                        dtgvDetail.Columns[2].HeaderText = "Số lượng";
                        dtgvDetail.Columns[3].HeaderText = "Đơn giá";
                    }
                }
                else if(dtgvList.Columns[0].HeaderText == "Số phiếu nhập")
                {
                    dtgvDetail.Refresh();
                    dtgvDetail.DataSource = QLBS_BUS.Instance.GetListDetailReceiptBySoPN(r[0].Cells["So_PN"].Value.ToString());
                    if (dtgvDetail.Rows.Count > 0)
                    {
                        dtgvDetail.Columns[0].HeaderText = "Mã sách";
                        dtgvDetail.Columns[1].HeaderText = "Số lượng nhập";
                        dtgvDetail.Columns[2].HeaderText = "Giá nhập";
                    }
                }
            }
        }

        private void dtgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtgvDetail.SelectedRows;
            if(r.Count == 1)
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
                        lbBookName.Text = sach.Ten_S;
                    }
                    else
                    {
                        pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
                        lbBookName.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
