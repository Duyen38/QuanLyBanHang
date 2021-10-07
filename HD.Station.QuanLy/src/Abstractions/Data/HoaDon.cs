using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Data
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        [Column(TypeName = "numeric"), Required]
        [Display(Name = "Mã hóa đơn")]
        public decimal MaHD { get; set; }

        [StringLength(6), Required]
        [Display(Name = "Mã khách hàng")]
        public string MaKH { get; set; }

        [StringLength(6), Required]
        [Display(Name = "Mã nhân viên")]
        public string MaNV { get; set; }


        [Display(Name = "Ngày lập hóa đơn")]
        public DateTime? NgayLapHD { get; set; }

        [Display(Name = "Ngày nhận hàng")]
        public DateTime? NgayNhanHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public KhachHang KhachHang { get; set; }

        public NhanVien NhanVien { get; set; }
    }
}
