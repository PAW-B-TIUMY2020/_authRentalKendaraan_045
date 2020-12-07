using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        [Required(ErrorMessage = "Id jaminan wajib diisi!")]
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama jaminan wajib diisi!")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
