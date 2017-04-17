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
    using System.ComponentModel.DataAnnotations;

    public partial class pelanggan
    {
        public pelanggan()
        {
            this.laporans = new HashSet<laporan>();
        }
    
        [Display(Name="ID Pelanggan")]
        public int id_pelanggan { get; set; }

        [Display(Name = "No ID")]
        [Required(ErrorMessage = "Anda Belum Mengisi No ID ")]
        public string no_id { get; set; }

        [Display(Name = "Nama")]
        [Required(ErrorMessage="Anda Belum Mengisi Nama")]
        public string nama { get; set; }

        [Display(Name = "Alamat")]
        [Required(ErrorMessage = "Anda Belum Mengisi Alamat")]
        public string alamat { get; set; }

        [Display(Name = "No Telepon 1")]
        [Required(ErrorMessage = "Anda Belum Mengisi No Telp1")]
        public string no_tlp1 { get; set; }

        [Display(Name = "No Telepon 2")]
        [Required(ErrorMessage = "Anda Belum Mengisi No Telp2")]
        public string no_tlp2 { get; set; }
    
        public virtual ICollection<laporan> laporans { get; set; }
    }
}
