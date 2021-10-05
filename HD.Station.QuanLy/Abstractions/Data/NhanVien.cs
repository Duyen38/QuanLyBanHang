using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Data
{
    [Table("NhanVien")]
    public class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(6), Required]
        [Display(Name = "Mã nhân viên")]
        public string MaNV { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Họ")]
        public string HoNV { get; set; }

        [Required]
        [StringLength(12)]
        [Display(Name = "Tên")]
        public string TenNV { get; set; }

        [Display(Name = "Giới tính")]
        public bool? GioiTinh { get; set; }

        [Required]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [StringLength(10)]
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
