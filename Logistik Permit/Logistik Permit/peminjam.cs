//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistik_Permit
{
    using System;
    using System.Collections.Generic;
    
    public partial class peminjam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public peminjam()
        {
            this.form_pinjam = new HashSet<form_pinjam>();
        }
    
        public string Id_peminjam { get; set; }
        public string Nama { get; set; }
        public string Divisi { get; set; }
        public string Contact { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<form_pinjam> form_pinjam { get; set; }
    }
}
