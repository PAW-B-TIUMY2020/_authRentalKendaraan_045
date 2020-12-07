using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan wajib diisi!")]
        public string NamaKendaraan { get; set; }
        [MinLength(7, ErrorMessage = " No Polisi tidak boleh kurang dari 7 angka")]
        [MaxLength(8, ErrorMessage = " No Polisi tidak boleh lebih dari 8 angka")]
        [Required(ErrorMessage = "No Polisi wajib diisi!")]
        public string NoPolisi { get; set; }
        [MinLength(7, ErrorMessage = " No STNK tidak boleh kurang dari 7 angka")]
        [MaxLength(8, ErrorMessage = " No STNK tidak boleh lebih dari 8 angka")]

        [Required(ErrorMessage = "No STNK wajib diisi!")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "Jenis Kendaraan wajib diisi!")]
        [DisplayName("Jenis Kendaraan")]
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan wajib diisi!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
