using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Data
{
    public class ThongKeSanPhamViewModel
    {
        [Key]
        [StringLength(6), Required]
        [Display(Name = "Mã sản phẩm")]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string TenSp { get; set; }

        [Display(Name = "Ngày lập hóa đơn")]
        public DateTime? NgayLapHD { get; set; }

        [StringLength(10)]
        [Display(Name = "Đơn vị tính")]
        public string DonViTinh { get; set; }

        [Column(TypeName = "numeric"), DisplayFormat()]
        [Display(Name = "Đơn giá")]
        public decimal DonGia { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Số lượng")]
        public decimal SoLuong { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Thành tiền")]
        public decimal ThanhTien { get; set; }

    }
}
