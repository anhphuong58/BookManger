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
    public partial class FormFindProduct : Form
    {
        private const int ELEMENT_WIDTH = 200;
        private const int ELEMENT_HEIGHT = 320;
        private const int SELECTBOOK_WIDTH = 202;
        private const int SELECTBOOK_HEIGHT = 250;

        public FormFindProduct()
        {
            InitializeComponent();
            SetCBB();
            SetGUI();
        }
        private void SetCBB()
        {
            // tao combobox tinh trang sach
            cbbBookStatus.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbBookStatus.Items.Add(new CBBItem { Value = 1, Text = "Mới" });
            cbbBookStatus.Items.Add(new CBBItem { Value = 2, Text = "Cũ" });
            
            // tao combobox the loai sach
            cbbBookCategory.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbBookCategory.Items.AddRange(QLBS_BUS.Instance.GetListCBBCategory().ToArray());
            
            // tao combobox nha xuat ban
            cbbNXB.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbNXB.Items.AddRange(QLBS_BUS.Instance.GetListCBBNXB().ToArray());
            
        }
        private void SetGUI()
        {
            // thiet lap combobox tinh trang sach
            cbbBookStatus.SelectedIndex = 0;
            // thiet lap combobox the loai sach
            cbbBookCategory.SelectedIndex = 0;
            // thiet lap combobox nha xuat ban
            cbbNXB.SelectedIndex = 0;
            txbBookCode.Text = "";
            txbBookName.Text = "";
            txbBookPosition.Text = "";
            flpListBook.Controls.Clear();
            LoadBook("", "", "", "", 0, "");
            try
            {
                pbBookImage.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBook(string maSach,string viTri, string tenSach, string maNXB, int tinhTrang, string theLoai)
        {
            List<SACH> list = new List<SACH>();
            if (maSach == "" && tenSach == "" && viTri == "" && cbbNXB.SelectedIndex == 0 && cbbBookStatus.SelectedIndex == 0 && cbbBookCategory.SelectedIndex == 0)
            {
                list = QLBS_BUS.Instance.GetListBookForBill(true, maSach, tenSach, maNXB, tinhTrang, theLoai);
            }
            else
            {
                list = QLBS_BUS.Instance.GetListBookForBill(false, maSach, tenSach, maNXB, tinhTrang, theLoai);
            }
            if (list.Count == 0) return;
            foreach(SACH sach in list)
            {
                FlowLayoutPanel flp = new FlowLayoutPanel() { Width = ELEMENT_WIDTH, Height = ELEMENT_HEIGHT };
                flp.BackColor = Color.White;
                flp.Padding = Padding.Empty;
                PictureBox pb = new PictureBox() { Width = SELECTBOOK_WIDTH, Height = SELECTBOOK_HEIGHT};
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Margin = new Padding(0, 0, 0, 0);
                try
                    {
                    if (sach.imgPath != null)
                    {
                        Image img = Image.FromFile(sach.imgPath);
                        if (img == null)
                        {
                            img = Image.FromFile(FormWarehouseManager.nullImagePath);
                        }
                        pb.Image = img;
                    }
                    else
                    {
                        pb.Image = Image.FromFile(FormWarehouseManager.nullImagePath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi (ảnh hệ thống đã bị xóa)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Label lb = new Label() { Width = ELEMENT_WIDTH, Height = (ELEMENT_HEIGHT - SELECTBOOK_HEIGHT)/2};
                lb.BackColor = Color.Transparent;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.Text = sach.Ten_S;
                Button btn = new Button() { Width = ELEMENT_WIDTH, Height = (ELEMENT_HEIGHT - SELECTBOOK_HEIGHT) / 2 };
                btn.Text = "Chọn (" + sach.SoLuong.ToString() +")";
                btn.BackColor = Color.White;
                btn.Click += (sender, args) =>
                {
                    this.txbBookCode.Text = sach.Ma_S;
                };
                btn.Margin = new Padding(0, 0, 0, 0);
                btn.Cursor = Cursors.Hand;
                btn.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                flp.Controls.Add(pb);
                flp.Controls.Add(lb);
                flp.Controls.Add(btn);
                lb.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                lb.ForeColor = Color.FromArgb(0,192,0);
                flpListBook.Controls.Add(flp);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGUI();
        }

        private void txbBookCode_TextChanged(object sender, EventArgs e)
        {
            SACH s = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            if (s.Ma_S == txbBookCode.Text)
            {
                THELOAI theloai = QLBS_BUS.Instance.GetBookCategoryByID(s.Ma_TL);
                NXB nxb = QLBS_BUS.Instance.GetNXBByID(s.Ma_NXB);
                txbBookName.Text = s.Ten_S;
                txbBookPosition.Text = theloai.ViTri;
                cbbBookCategory.SelectedIndex = cbbBookCategory.FindStringExact(theloai.Ten_TL);
                cbbNXB.SelectedIndex = cbbNXB.FindStringExact(nxb.Ten_NXB);
                cbbBookStatus.SelectedIndex = cbbBookStatus.FindStringExact(((bool)(s.TinhTrang) ? "Mới" : "Cũ"));
                try
                {
                    if (s.imgPath != null)
                    {
                        Image img = Image.FromFile(s.imgPath);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSach = txbBookCode.Text;
            string tenSach = txbBookName.Text;
            string viTri = txbBookPosition.Text;
            string maNXB = QLBS_BUS.Instance.GetNXBByName(cbbNXB.SelectedItem.ToString()).Ma_NXB;
            int tinhTrang = cbbBookStatus.SelectedIndex;
            string theLoai = QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).Ma_TL;
            flpListBook.Controls.Clear();
            LoadBook(maSach, viTri, tenSach, maNXB, tinhTrang, theLoai);
        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            SACH sach = QLBS_BUS.Instance.GetBookByID(txbBookCode.Text);
            if(cbbBookStatus.SelectedIndex != 0)
            {
                bool tinhtrang = (cbbBookStatus.SelectedIndex == 1) ? (true) : false;
                if (sach.Ten_S == txbBookName.Text && sach.TinhTrang == tinhtrang && sach.Ma_NXB == QLBS_BUS.Instance.GetNXBByName(cbbNXB.SelectedItem.ToString()).Ma_NXB && sach.Ma_TL == QLBS_BUS.Instance.GetBookCategoryByName(cbbBookCategory.SelectedItem.ToString()).Ma_TL)
                {
                    FormBill.IDSach = txbBookCode.Text;
                    FormReceipt.IDSach = txbBookCode.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin từ các text không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thông tin từ các text không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
