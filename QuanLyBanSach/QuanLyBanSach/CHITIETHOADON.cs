//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanSach
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETHOADON
    {
        public string Ma_HD { get; set; }
        public string Ma_S { get; set; }
        public string Ten_S { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
