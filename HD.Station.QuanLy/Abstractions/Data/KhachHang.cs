using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLy.src.Abstractions.Data
{
    [Table("KhachHang")]
    public class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(6), Required]
        [Display(Name = "Mã Khách Hàng")]
        public string MaKH { get; set; }

        [StringLength(40), Required]
        [Display(Name = "Họ và Tên")]
        public string HoTenKH { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string DienThoai { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
