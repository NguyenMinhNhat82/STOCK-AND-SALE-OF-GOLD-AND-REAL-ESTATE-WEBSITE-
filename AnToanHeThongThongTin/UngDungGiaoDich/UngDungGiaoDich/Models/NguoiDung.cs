﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UngDungGiaoDich.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.GiaoDichCoPhieu = new HashSet<GiaoDichCoPhieu>();
            this.GiaoDIchVang = new HashSet<GiaoDIchVang>();
            this.LenhGiaoDich = new HashSet<LenhGiaoDich>();
            this.NhaDat = new HashSet<NhaDat>();
            this.User_CoPhieu = new HashSet<User_CoPhieu>();
        }
            
        public int ID { get; set; }
        [Display(Name = "Tên người dùng")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }


        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }

        [Display(Name = "Tên tài khoản")]
        public string TenTK { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage ="Mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Số tài khoản ngân hàng")]
        public string STKNganHang { get; set; }

        [Display(Name = "Tiền mặt")]
        public Nullable<decimal> Cash { get; set; }
        public string Avatar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDichCoPhieu> GiaoDichCoPhieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDIchVang> GiaoDIchVang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LenhGiaoDich> LenhGiaoDich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhaDat> NhaDat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_CoPhieu> User_CoPhieu { get; set; }
    }
}
