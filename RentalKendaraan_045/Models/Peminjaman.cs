using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RentalKendaraan_045.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }


        [DisplayName("ID")]
        [Required(ErrorMessage = "ID Peminjaman wajib diisi!")]
        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal Peminjaman wajib diisi!")]
        [DisplayName("Tanggal Peminjaman")]
        public DateTime? TglPeminjaman { get; set; }
        [Required(ErrorMessage = "Kendaraan wajib diisi!")]
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "Customer wajib diisi!")]
        [DisplayName("Customer")]
        public int? IdCostumer { get; set; }
        [Required(ErrorMessage = "Jaminan wajib diisi!")]
        [DisplayName("Jaminan")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya wajib diisi!")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int? Biaya { get; set; }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Customes wajib diisi!")]
        public Customer IdCostumerNavigation { get; set; }
        [DisplayName("Jaminan")]
        [Required(ErrorMessage = "jamninan wajib diisi!")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        [Required(ErrorMessage = "Kendaraan wajib diisi!")]
        public Kendaraan IdKendaraanNavigation { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
