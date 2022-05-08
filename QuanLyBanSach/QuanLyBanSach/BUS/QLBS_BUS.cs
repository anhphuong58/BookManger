using QuanLyBanSach.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.BUS
{
    class QLBS_BUS
    {
        private static QLBS_BUS _Instance;
        public static QLBS_BUS Instance
        {
            get
            {
                if (_Instance == null) _Instance = new QLBS_BUS();
                return _Instance;
            }
            private set
            {

            }
        }
        private QLBS_BUS() { }
        // Login method
        #region login
        public bool Login(string username, string password)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            int user = (from p in db.QUANLINHANVIENs where p.Ma_NV == username && p.MatKhau == password select p).Count();
            return (user > 0) ? true : false;
        }
        public bool LoginPrivilege(string username, string password, bool flat)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            // nếu flat = true tìm những tài khoản được cấp quyền quản trị nhân viên
            // nếu flat = false tìm những tài khoản được cấp quyền tạo phiếu nhập
            int user = (flat)?(from p in db.QUANLINHANVIENs where p.Ma_NV == username && p.MatKhau == password && p.QuyenQuanTriNhanVien == true select p).Count(): (from p in db.QUANLINHANVIENs where p.Ma_NV == username && p.MatKhau == password && p.QuyenTaoPhieuNhap == true select p).Count();
            return (user > 0) ? true : false;
        }
        #endregion
        // Get list comboboxes
        #region combobox
        public List<CBBItem> GetListCBBCategory()
        {
            int t = 0;
            List<CBBItem> data = new List<CBBItem>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach(THELOAI i in db.THELOAIs)
                {
                    data.Add(new CBBItem { Text = i.Ten_TL, Value = ++t });
                }
            }
            return data;
        }
        public List<CBBItem> GetListCBBStaff()
        {
            int t = 0;
            List<CBBItem> data = new List<CBBItem>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (QUANLINHANVIEN i in from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select p)
                {
                    data.Add(new CBBItem { Text = i.Ma_NV, Value = ++t });
                }
            }
            return data;
        }
        public List<CBBItem> GetListCBBNXB()
        {
            int t = 0;
            List<CBBItem> data = new List<CBBItem>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (NXB i in from p in db.NXBs select p)
                {
                    data.Add(new CBBItem { Text = i.Ten_NXB, Value = ++t });
                }
            }
            return data;
        }
        #endregion
        // Get staff
        #region staff
        public List<Object> GetListStaff()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select new { p.Ma_NV, p.Ten_NV, p.SoCMND, p.SDT, p.Email, p.DiaChi, p.ChucVu };
            list = l1.ToList<Object>();
            return list;
        }
        public QUANLINHANVIEN GetStaffFromID(string ID)
        {
            QUANLINHANVIEN staff = new QUANLINHANVIEN();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (QUANLINHANVIEN i in from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select p)
                {
                    if (i.Ma_NV == ID)
                    {
                        staff = i;
                        break;
                    }
                }
            }
            return staff;
        }
        public List<Object> GetStaffFromKeywordAllGrant(string keyword)
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" && (p.Ma_NV.Contains(keyword) || p.Ten_NV.Contains(keyword) || p.SoCMND.Contains(keyword) || p.DiaChi.Contains(keyword) || p.Email.Contains(keyword) || p.SDT.Contains(keyword) || p.ChucVu.Contains(keyword) || p.Luong.ToString().Contains(keyword) || p.NgayBatDau.ToString().Contains(keyword)) select new { p.Ma_NV, p.Ten_NV, p.SoCMND, p.SDT, p.Email, p.DiaChi, p.ChucVu, p.Luong, p.NgayBatDau };
            list = l1.ToList<Object>();
            return list;
        }
        public List<Object> GetStaffFromKeyword(string keyword, bool admin, bool receipt)
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" && (p.Ma_NV.Contains(keyword) || p.Ten_NV.Contains(keyword) || p.SoCMND.Contains(keyword) || p.DiaChi.Contains(keyword) || p.Email.Contains(keyword) || p.SDT.Contains(keyword) || p.ChucVu.Contains(keyword) || p.Luong.ToString().Contains(keyword) || p.NgayBatDau.ToString().Contains(keyword)) && (p.QuyenQuanTriNhanVien == admin && p.QuyenTaoPhieuNhap == receipt) select new { p.Ma_NV, p.Ten_NV, p.SoCMND, p.SDT, p.Email, p.DiaChi, p.ChucVu, p.Luong, p.NgayBatDau };
            list = l1.ToList<Object>();
            return list;
        }
        public List<Object> GetListStaffAdmin()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select new { p.Ma_NV, p.Ten_NV, p.SoCMND, p.SDT, p.Email, p.DiaChi, p.ChucVu, p.Luong, p.NgayBatDau };
            list = l1.ToList<Object>();
            return list;
        }
        public QUANLINHANVIEN GetStaffFromPhoneOrEmailOrCMND(string phone_mail_CMND)
        {
            QUANLINHANVIEN nv = new QUANLINHANVIEN();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (QUANLINHANVIEN i in from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select p)
                {
                    if (i.Email == phone_mail_CMND || i.SDT == phone_mail_CMND || i.SoCMND == phone_mail_CMND)
                    {
                        nv = i;
                        break;
                    }
                }
            }
            return nv;
        }
        public QUANLINHANVIEN GetStaffByCode(string code)
        {
            QUANLINHANVIEN nv = new QUANLINHANVIEN();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (QUANLINHANVIEN i in from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select p)
                {
                    if (i.Ma_NV == code)
                    {
                        nv = i;
                        break;
                    }
                }
            }
            return nv;
        }
        public List<Object> GetListStaffByInfo(string tenNV, string email, string address, string phone, string position, string soCMND)
        {
            List<QUANLINHANVIEN> temp = new List<QUANLINHANVIEN>();
            List<Object> list = new List<Object>();
            List<string> listMaNV = GetListStaffCodeByInfo(tenNV, email, address, phone, position, soCMND);
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            foreach(string i in listMaNV)
            {
                foreach(QUANLINHANVIEN j in db.QUANLINHANVIENs)
                {
                    if(j.Ma_NV == i)
                    {
                        temp.Add(j);
                    }
                }
            }
            var l = from p in temp select new { p.Ma_NV, p.Ten_NV, p.SoCMND, p.SDT, p.Email, p.DiaChi, p.ChucVu };
            list = l.ToList<object>();
            return list;
        }
        public List<string> GetListStaffCodeByInfo(string tenNV, string email, string address, string phone, string position, string soCMND)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            List<string> list = new List<string>();
            List<QUANLINHANVIEN> data = (from p in db.QUANLINHANVIENs where p.Ma_NV != "Admin" select p).ToList<QUANLINHANVIEN>();
            if(tenNV != "")
            {
                foreach(QUANLINHANVIEN i in data)
                {
                    if (i.Ten_NV.Contains(tenNV))
                    {
                        list.Add(i.Ma_NV);
                    }
                }
                if (list.Count == 0) return new List<string>();
            }
            if (email != "")
            {
                if (list.Count > 0)
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (!i.Email.Contains(email))
                        {
                            list.Remove(i.Ma_NV);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (i.Email.Contains(email))
                        {
                            list.Add(i.Ma_NV);
                        }
                    }
                }
            }
            if (address != "")
            {
                if(list.Count > 0)
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (!i.DiaChi.Contains(address))
                        {
                            list.Remove(i.Ma_NV);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (i.DiaChi.Contains(address))
                        {
                            list.Add(i.Ma_NV);
                        }
                    }
                }

            }
            if (phone != "")
            {
                if (list.Count > 0)
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (!i.SDT.Contains(phone))
                        {
                            list.Remove(i.Ma_NV);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (i.SDT.Contains(phone))
                        {
                            list.Add(i.Ma_NV);
                        }
                    }
                }
            }
            if (position != "")
            {
                if (list.Count > 0)
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (!i.ChucVu.Contains(position))
                        {
                            list.Remove(i.Ma_NV);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (i.ChucVu.Contains(position))
                        {
                            list.Add(i.Ma_NV);
                        }
                    }
                }
            }
            if (soCMND != "")
            {
                if (list.Count > 0)
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (!i.SoCMND.Contains(soCMND))
                        {
                            list.Remove(i.Ma_NV);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (QUANLINHANVIEN i in data)
                    {
                        if (i.SoCMND.Contains(soCMND))
                        {
                            list.Add(i.Ma_NV);
                        }
                    }
                }
            }
            return list;
        }
        // Add staff
        public void AddStaff(QUANLINHANVIEN nv)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.QUANLINHANVIENs.Add(nv);
            db.SaveChanges();
        }
        // update staff
        public void UpdateStaff(QUANLINHANVIEN nv)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            QUANLINHANVIEN newnv = db.QUANLINHANVIENs.Where(p => p.Ma_NV == nv.Ma_NV).First();
            newnv.Ma_NV = nv.Ma_NV;
            newnv.Ten_NV = nv.Ten_NV;
            newnv.DiaChi = nv.DiaChi;
            newnv.Email = nv.Email;
            newnv.SoCMND = nv.SoCMND;
            newnv.SDT = nv.SDT;
            newnv.ChucVu = nv.ChucVu;
            newnv.Luong = nv.Luong;
            newnv.MatKhau = nv.MatKhau;
            newnv.NgayBatDau = nv.NgayBatDau;
            newnv.QuyenQuanTriNhanVien = nv.QuyenQuanTriNhanVien;
            newnv.QuyenTaoPhieuNhap = nv.QuyenTaoPhieuNhap;
            db.SaveChanges();
        }
        // delete staff
        public void DeleteStaff(string maNV)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            QUANLINHANVIEN nv = db.QUANLINHANVIENs.SingleOrDefault(p => p.Ma_NV == maNV);
            if (nv != null)
            {
                db.QUANLINHANVIENs.Remove(nv);
                db.SaveChanges();
            }
        }
        #endregion
        // Get customers
        #region customer
        public List<Object> GetListCustomer()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.KHACHHANGs where p.Ma_KH != "NoName" select new { p.Ma_KH, p.Ten_KH, p.DiaChi, p.Email, p.SDT_KH };
            list = l1.ToList<Object>();
            return list;
        }
        public KHACHHANG GetCustomerFromPhoneOrEmail(string phone_mail)
        {
            KHACHHANG kh = new KHACHHANG();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (KHACHHANG i in from p in db.KHACHHANGs where p.Ma_KH != "NoName" select p)
                {
                    if (i.Email == phone_mail || i.SDT_KH == phone_mail)
                    {
                        kh = i;
                        break;
                    }
                }
            }
            return kh;
        }
        public KHACHHANG GetCustomerFromCode(string code)
        {
            KHACHHANG kh = new KHACHHANG();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (KHACHHANG i in from p in db.KHACHHANGs where p.Ma_KH != "NoName" select p)
                {
                    if (i.Ma_KH == code)
                    {
                        kh = i;
                        break;
                    }
                }
            }
            return kh;
        }
        public List<Object> GetListCustomerByInfo(string MaKH, string TenKH, string address, string email, string phone)
        {
            List<KHACHHANG> temp = new List<KHACHHANG>();
            List<Object> list = new List<Object>();
            List<string> listMaNV = GetListCustomerCodeByInfo(MaKH, TenKH, address, email, phone);
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            foreach (string i in listMaNV)
            {
                foreach (KHACHHANG j in db.KHACHHANGs)
                {
                    if (j.Ma_KH == i)
                    {
                        temp.Add(j);
                    }
                }
            }
            var l = from p in temp where p.Ma_KH != "NoName" select new { p.Ma_KH, p.Ten_KH, p.DiaChi, p.Email, p.SDT_KH};
            list = l.ToList<object>();
            return list;
        }
        public List<string> GetListCustomerCodeByInfo(string MaKH, string TenKH, string address, string email, string phone)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            List<string> list = new List<string>();
            List<KHACHHANG> data = (from p in db.KHACHHANGs select p).ToList<KHACHHANG>();
            if (MaKH != "")
            {
                foreach (KHACHHANG i in data)
                {
                    if (i.Ma_KH.Contains(MaKH))
                    {
                        list.Add(i.Ma_KH);
                    }
                }
                if (list.Count == 0) return new List<string>();
            }
            if (TenKH != "")
            {
                if (list.Count > 0)
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (!i.Ten_KH.Contains(TenKH))
                        {
                            list.Remove(i.Ma_KH);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (i.Ten_KH.Contains(TenKH))
                        {
                            list.Add(i.Ma_KH);
                        }
                    }
                }
            }
            if (address != "")
            {
                if (list.Count > 0)
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (!i.DiaChi.Contains(address))
                        {
                            list.Remove(i.Ma_KH);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (i.DiaChi.Contains(address))
                        {
                            list.Add(i.Ma_KH);
                        }
                    }
                }

            }
            if (email != "")
            {
                if (list.Count > 0)
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (!i.Email.Contains(email))
                        {
                            list.Remove(i.Ma_KH);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (i.Email.Contains(email))
                        {
                            list.Add(i.Ma_KH);
                        }
                    }
                }
            }
            if (phone != "")
            {
                if (list.Count > 0)
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (!i.SDT_KH.Contains(phone))
                        {
                            list.Remove(i.Ma_KH);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (KHACHHANG i in data)
                    {
                        if (i.SDT_KH.Contains(phone))
                        {
                            list.Add(i.Ma_KH);
                        }
                    }
                }
            }
            return list;
        }

        // add customer
        public void AddCustomer(KHACHHANG kh)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }
        // Update customer
        public void UpdateCustomer(KHACHHANG kh)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            KHACHHANG newkh = db.KHACHHANGs.Where(p => p.Ma_KH == kh.Ma_KH && p.Ma_KH != "NoName").First();
            newkh.Ma_KH = kh.Ma_KH;
            newkh.Ten_KH = kh.Ten_KH;
            newkh.DiaChi = kh.DiaChi;
            newkh.Email = kh.Email;
            newkh.SDT_KH = kh.SDT_KH;
            db.SaveChanges();
        }
        // Delete Customer
        public void DeleteCustomer(string maKH)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(p => p.Ma_KH == maKH && p.Ma_KH != "NoName");
            if (kh != null)
            {
                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();
            }
        }
        #endregion
        // get Books
        #region book
        public List<Object> GetListBook()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.SACHes select new{p.Ma_S,p.Ten_S, p.Ma_TL, p.Ma_NXB, p.SoLuong, p.TinhTrang, p.Gia};
            list = l1.ToList<Object>();
            return list;
        }
        public List<SACH> GetListBookForBill(bool all, string maSach, string tenSach, string maNXB, int tinhtrang, string theLoai)
        {
            List<SACH> list = new List<SACH>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            if (all == true)
            {
                var l1 = from p in db.SACHes select p;
                list = l1.ToList<SACH>();
                return list;
            }
            List<string> listMaSach = GetListBookCodeByInfo(maSach, tenSach, maNXB, tinhtrang, theLoai);
            foreach (string i in listMaSach)
            {
                foreach (SACH j in db.SACHes)
                {
                    if (j.Ma_S == i)
                    {
                        list.Add(j);
                    }
                }
            }
            list = list.ToList<SACH>();
            return list;
        }
        public SACH GetBookByID(string ID)
        {
            SACH s = new SACH();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (SACH i in from p in db.SACHes select p)
                {
                    if (i.Ma_S == ID)
                    {
                        s = i;
                        break;
                    }
                }
            }
            return s;
        }
        public List<Object> GetListBookByInfo(string maSach, string tenSach, string maNXB, int tinhtrang, string theLoai)
        {
            List<SACH> temp = new List<SACH>();
            List<Object> list = new List<Object>();
            List<string> listMaSach = GetListBookCodeByInfo(maSach, tenSach, maNXB, tinhtrang, theLoai);
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            foreach (string i in listMaSach)
            {
                foreach (SACH j in db.SACHes)
                {
                    if (j.Ma_S == i)
                    {
                        temp.Add(j);
                    }
                }
            }
            var l = from p in temp select new { p.Ma_S, p.Ten_S, p.Ma_TL, p.Ma_NXB, p.SoLuong, p.TinhTrang, p.Gia };
            list = l.ToList<object>();
            list = list.ToList<object>();
            return list;
        }

        //public List<Object> GetListBookByInfo(string maSach, string tenSach, string maNXB, int tinhtrang, string theLoai)
        //{
        //    List<object> list = new List<object>();
        //    using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
        //    {
        //        var l = from p in db.SACHes where p.Ma_S.ToString().Contains(maSach) && p.Ten_S.Contains(tenSach) && p.Ma_NXB.Contains(maNXB) && p.Ma_TL.Contains(theLoai) select new { p.Ma_S, p.Ten_S, p.Ma_TL, p.Ma_NXB, p.SoLuong, p.TinhTrang, p.Gia };
        //        if(tinhtrang != 0)
        //        {
        //            bool flat = (tinhtrang==1) ? true : false;
        //            l = from p in l where p.TinhTrang == flat select p;
        //        }
        //        list = l.ToList<object>();
        //    }
        //    return list;
        //}

        public List<string> GetListBookCodeByInfo(string maSach, string tenSach, string maNXB, int tinhTrang, string theLoai)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            List<string> list = new List<string>();
            List<SACH> data = (from p in db.SACHes select p).ToList<SACH>();
            if (maSach != "")
            {
                foreach (SACH i in data)
                {
                    if (i.Ma_S.Contains(maSach))
                    {
                        list.Add(i.Ma_S);
                    }
                }
                if (list.Count == 0) return new List<string>();
            }
            
            if (tenSach != "")
            {
                if (list.Count > 0)
                {
                    foreach (SACH i in data)
                    {
                        if (!i.Ten_S.Contains(tenSach))
                        {
                            list.Remove(i.Ma_S);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (SACH i in data)
                    {
                        if (i.Ten_S.Contains(tenSach))
                        {
                            list.Add(i.Ma_S);
                        }
                    }
                }
            }
            if (maNXB != null)
            {
                if (list.Count > 0)
                {
                    foreach (SACH i in data)
                    {
                        if (!i.Ma_NXB.Contains(maNXB))
                        {
                            list.Remove(i.Ma_S);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (SACH i in data)
                    {
                        if (i.Ma_NXB.Contains(maNXB))
                        {
                            list.Add(i.Ma_S);
                        }
                    }
                }

            }
            if (tinhTrang != 0)
            {
                if (list.Count > 0)
                {
                    foreach (SACH i in data)
                    {
                        if (i.TinhTrang == true && tinhTrang == 2)
                        {
                            list.Remove(i.Ma_S);
                            if (list.Count == 0) return new List<string>();
                        }
                        else if (i.TinhTrang == false && tinhTrang == 1)
                        {
                            list.Remove(i.Ma_S);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (SACH i in data)
                    {
                        if (i.TinhTrang == true && tinhTrang == 1)
                        {
                            list.Add(i.Ma_S);
                        }
                        else if (i.TinhTrang == false && tinhTrang == 2)
                        {
                            list.Add(i.Ma_S);
                        }
                    }
                }
            }
            if (theLoai != null)
            {
                if (list.Count > 0)
                {
                    foreach (SACH i in data)
                    {
                        if (!i.Ma_TL.Contains(theLoai))
                        {
                            list.Remove(i.Ma_S);
                            if (list.Count == 0) return new List<string>();
                        }
                    }
                }
                else
                {
                    foreach (SACH i in data)
                    {
                        if (i.Ma_TL.Contains(theLoai))
                        {
                            list.Add(i.Ma_S);
                        }
                    }
                }
            }
            return list;
        }
        // get book category
        public List<Object> GetListCategory()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.THELOAIs select new { p.Ma_TL, p.Ten_TL, p.ViTri};
            list = l1.ToList<Object>();
            return list;
        }
        public THELOAI GetBookCategoryByID(string ID)
        {
            THELOAI theloai = new THELOAI();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (THELOAI i in from p in db.THELOAIs select p)
                {
                    if(i.Ma_TL == ID)
                    {
                        theloai = i;
                    }
                }
            }
            return theloai;
        }
        public THELOAI GetBookCategoryByName(string name)
        {
            THELOAI theloai = new THELOAI();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (THELOAI i in from p in db.THELOAIs select p)
                {
                    if (i.Ten_TL == name)
                    {
                        theloai = i;
                    }
                }
            }
            return theloai;
        }
        // get NXB
        public List<Object> GetListNXB()
        {
            List<Object> list = new List<Object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.NXBs select new { p.Ma_NXB, p.Ten_NXB, p.DiaChi_NXB, p.SDT_NXB};
            list = l1.ToList<Object>();
            return list;
        }
        public NXB GetNXBByID(string ID)
        {
            NXB nxb = new NXB();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (NXB i in from p in db.NXBs select p)
                {
                    if (i.Ma_NXB == ID)
                    {
                        nxb = i;
                    }
                }
            }
            return nxb;
        }
        public NXB GetNXBByName(string name)
        {
            NXB nxb = new NXB();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (NXB i in from p in db.NXBs select p)
                {
                    if (i.Ten_NXB == name)
                    {
                        nxb = i;
                    }
                }
            }
            return nxb;
        }
        public NXB GetNXBByPhone(string phone)
        {
            NXB nxb = new NXB();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (NXB i in from p in db.NXBs select p)
                {
                    if (i.SDT_NXB == phone)
                    {
                        nxb = i;
                    }
                }
            }
            return nxb;
        }
        // add book
        public void AddBook(SACH sach)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.SACHes.Add(sach);
            db.SaveChanges();
        }
        public void AddNXB(NXB nxb)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.NXBs.Add(nxb);
            db.SaveChanges();
        }
        public void AddCategory(THELOAI theloai)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.THELOAIs.Add(theloai);
            db.SaveChanges();
        }
        // Update book
        public void UpdateBook(SACH sach)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            SACH newSach = db.SACHes.Where(p => p.Ma_S == sach.Ma_S).FirstOrDefault();
            newSach.Ma_S = sach.Ma_S;
            newSach.Ma_NXB = sach.Ma_NXB;
            newSach.Ma_TL = sach.Ma_TL;
            newSach.Ten_S = sach.Ten_S;
            newSach.SoLuong = sach.SoLuong;
            newSach.TinhTrang = sach.TinhTrang;
            newSach.Gia = sach.Gia;
            newSach.imgPath = sach.imgPath;
            db.SaveChanges();
        }
        public void UpdateNXB(NXB nxb)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            NXB newNXB = db.NXBs.Where(p => p.Ma_NXB == nxb.Ma_NXB).First();
            newNXB.Ma_NXB = nxb.Ma_NXB;
            newNXB.Ten_NXB = nxb.Ten_NXB;
            newNXB.DiaChi_NXB = nxb.DiaChi_NXB;
            newNXB.SDT_NXB = nxb.SDT_NXB;
            db.SaveChanges();
        }
        public void UpdateCategory(THELOAI theloai)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            THELOAI newTheLoai = db.THELOAIs.Where(p => p.Ma_TL == theloai.Ma_TL).First();
            newTheLoai.Ma_TL = theloai.Ma_TL;
            newTheLoai.Ten_TL = theloai.Ten_TL;
            newTheLoai.ViTri = theloai.ViTri;
            db.SaveChanges();
        }
        // Delete book
        public void DeleteBook(string MaSach)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            SACH sach = db.SACHes.SingleOrDefault(p => p.Ma_S == MaSach);
            if (sach != null)
            {
                db.SACHes.Remove(sach);
                db.SaveChanges();
            }
        }
        public void DeleteNXB(string MaNXB)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            NXB nxb = db.NXBs.SingleOrDefault(p => p.Ma_NXB == MaNXB);
            if (nxb != null)
            {
                db.NXBs.Remove(nxb);
                db.SaveChanges();
            }
        }
        public void DeleteCategory(string MaTheLoai)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            THELOAI theloai = db.THELOAIs.SingleOrDefault(p => p.Ma_TL == MaTheLoai);
            if (theloai != null)
            {
                db.THELOAIs.Remove(theloai);
                db.SaveChanges();
            }
        }
        #endregion
        // Order
        #region order
        public List<object> GetListHoaDon()
        {
            List<object> list = new List<object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.HOADONs select new { p.Ma_HD, p.Ma_KH, p.Ma_NV, p.NgayBan, p.TongTien };
            list = l1.ToList<Object>();
            return list;
        }
        
        public HOADON GetHoaDonByID(string MaHD)
        {
            HOADON hd = new HOADON();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (HOADON i in from p in db.HOADONs select p)
                {
                    if (i.Ma_HD == MaHD)
                    {
                        hd = i;
                    }
                }
            }
            return hd;
        }
        public List<object> GetChiTietHoaDon(string MaHD)
        {
            List<object> list = new List<object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.CHITIETHOADONs where p.Ma_HD == MaHD select new { p.Ma_S,p.Ten_S, p.SoLuong,p.DonGia };
            list = l1.ToList<Object>();
            return list;
        }
        public List<object> GetListOrder()
        {
            List<object> list = new List<object>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                var l = from p in db.HOADONs select new { p.Ma_HD, p.Ma_KH, p.Ma_NV, p.NgayBan, p.TongTien };
                list = l.ToList<object>();
            }
            return list;
        }
        public List<object> GetListOrderByInfo(string MaHD, string MaKH, DateTime timeFrom, DateTime timeTo, string MaNV, double MNMin, double MNMax)
        {
            List<object> list = new List<object>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                var l = from p in db.HOADONs where p.Ma_HD.ToString().Contains(MaHD) && p.Ma_KH.Contains(MaKH) && p.Ma_NV.Contains(MaNV) && EntityFunctions.TruncateTime(p.NgayBan) >= timeFrom.Date && EntityFunctions.TruncateTime(p.NgayBan) <= timeTo.Date && p.TongTien >= MNMin && p.TongTien <= MNMax select new { p.Ma_HD, p.Ma_KH, p.Ma_NV, p.NgayBan, p.TongTien };
                list = l.ToList<object>();
            }
            return list;
        }
        // add order
        public void AddOrder(HOADON hd, List<CHITIETHOADON> cthd)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.HOADONs.Add(hd);
            for(int i = 0; i < cthd.Count; i++)
            {
                db.CHITIETHOADONs.Add(cthd[i]);
            }
            db.SaveChanges();
        }
        #endregion
        // Receipt
        #region receipt
        public List<object> getListReceipt()
        {
            List<object> list = new List<object>();
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            var l1 = from p in db.PHIEUNHAPs select new { p.So_PN, p.Ma_NXB, p.NgayNhap, p.TongTien};
            list = l1.ToList<Object>();
            return list;
        }
        public List<object> GetListDetailReceiptBySoPN(string SoPN)
        {
            List<object> list = new List<object>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                var l = from p in db.CHITIETPHIEUNHAPs where p.So_PN.ToString().Contains(SoPN) select new { p.Ma_S, p.SoLuongNhap, p.GiaNhap };
                list = l.ToList<object>();
            }
            return list;
        }
        public List<object> GetListReceiptByInfo(string SoPN, string MaNXB, DateTime timeFrom, DateTime timeTo)
        {
            List<object> list = new List<object>();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                    var l = from p in db.PHIEUNHAPs where p.So_PN.ToString().Contains(SoPN) && p.Ma_NXB.Contains(MaNXB) && EntityFunctions.TruncateTime(p.NgayNhap) >= timeFrom.Date && EntityFunctions.TruncateTime(p.NgayNhap) <= timeTo.Date select new { p.So_PN, p.Ma_NXB, p.NgayNhap ,p.TongTien};
                    list = l.ToList<object>();
            }
            return list;
        }
        public int GetSoPNMax()
        {
            int SoPN = -1;
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                SoPN = db.PHIEUNHAPs.Count();
            }
            return SoPN;
        }
        public PHIEUNHAP GetPhieuNhapByID(int SoPN)
        {
            PHIEUNHAP pn = new PHIEUNHAP();
            using (QL_Ban_Sach_DB db = new QL_Ban_Sach_DB())
            {
                foreach (PHIEUNHAP i in from p in db.PHIEUNHAPs select p)
                {
                    if (i.So_PN == SoPN)
                    {
                        pn = i;
                    }
                }
            }
            return pn;
        }
        // add Receipt
        public void AddPN(PHIEUNHAP pn, List<CHITIETPHIEUNHAP> ctpn)
        {
            QL_Ban_Sach_DB db = new QL_Ban_Sach_DB();
            db.PHIEUNHAPs.Add(pn);
            for (int i = 0; i < ctpn.Count; i++)
            {
                db.CHITIETPHIEUNHAPs.Add(ctpn[i]);
            }
            db.SaveChanges();
        }
        #endregion
    }
}
