//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asp_mvc_2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class outbond
    {
        public outbond()
        {
            this.laporans = new HashSet<laporan>();
        }
    
        public int id_outbond { get; set; }
        public string keterangan { get; set; }
        public int harga { get; set; }
        public Nullable<System.DateTime> tgl_pesan { get; set; }
        public Nullable<System.DateTime> tgl_mulai { get; set; }
    
        public virtual ICollection<laporan> laporans { get; set; }
    }
}
