using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer wajib diisi!")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Nik hanya boleh diisi dengan angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib diisi!")]
        public string Alamat { get; set; }

        [MinLength(11, ErrorMessage = " No Hp tidak boleh kurang dari 10 angka")]
        [MaxLength(13, ErrorMessage = " No Hp tidak boleh lebih dari 13 angka")]
        [Required(ErrorMessage = "No Hp wajib diisi!")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "Data Gender wajib diisi!")]
        public int? IdGender { get; set; }

        [DisplayName("Gender")]
        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
