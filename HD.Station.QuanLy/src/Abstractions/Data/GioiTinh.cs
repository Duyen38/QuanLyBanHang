using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLy.src.Abstractions.Data
{
    [Table("GioiTinh")]
    public class GioiTinh
    {
        public GioiTinh()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public bool Value { get; set; }

        [Display(Name = "Giới tính")]
        public string Name { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
