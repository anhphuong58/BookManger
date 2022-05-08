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
    public partial class FormLogin : Form
    {
        // Có 3 loại đăng nhập
        // Đăng nhập tạo hóa đơn (kind = 0)
        // Đăng nhập quản lý nhân viên (kind = 1)
        // Đăng nhập tạo phiếu nhập (kind = 2)
        int kind = 0;
        public int flat = 0;
        public FormLogin()
        {
            this.Text = "Đăng nhập";
            InitializeComponent();
        }

        public FormLogin(int n)
        {
            this.kind = n;
            this.Text = "Tài khoản quản trị hoặc được cấp quyền";
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text.ToString();
            string passWord = txbPassWord.Text.ToString();
            if(this.kind == 0)
            {
                if(userName.ToUpper() == "ADMIN")
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPassWord.Clear();
                    return;
                }
                if (QLBS_BUS.Instance.Login(userName, passWord))
                {
                    FormBill.IDNhanVien = userName;
                    this.flat = 1;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPassWord.Clear();
                }
            }
            else if(this.kind == 1)
            {
                if (QLBS_BUS.Instance.LoginPrivilege(userName, passWord, true))
                    this.flat = 1;
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPassWord.Clear();
                    return;
                }
                this.Dispose();
            }
            else if(this.kind == 2)
            {
                if (QLBS_BUS.Instance.LoginPrivilege(userName, passWord, false))
                    this.flat = 1;
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPassWord.Clear();
                    return;
                }
                this.Dispose();
            }
        }

    }
}
