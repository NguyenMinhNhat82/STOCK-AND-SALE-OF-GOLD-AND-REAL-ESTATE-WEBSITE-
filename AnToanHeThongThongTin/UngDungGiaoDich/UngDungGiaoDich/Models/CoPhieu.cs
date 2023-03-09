//------------------------------------------------------------------------------
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
    
    public partial class CoPhieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoPhieu()
        {
            this.LenhGiaoDich = new HashSet<LenhGiaoDich>();
            this.User_CoPhieu = new HashSet<User_CoPhieu>();
        }
    
        public int ID { get; set; }
        public string Ten { get; set; }
        public string TheLoai { get; set; }
        public Nullable<int> TongSoCoPhieu { get; set; }
        public string ChuSoHuu { get; set; }
        public string DonVi { get; set; }
        public Nullable<double> GiaClose { get; set; }
        public Nullable<double> GiaHigh { get; set; }
        public Nullable<double> GiaLow { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LenhGiaoDich> LenhGiaoDich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_CoPhieu> User_CoPhieu { get; set; }
    }
}