using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [Required(ErrorMessage = "Id Kondisi wajib diisi!")]
        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Nama Kondisi wajib diisi!")]
        public string NamaKondisi { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
