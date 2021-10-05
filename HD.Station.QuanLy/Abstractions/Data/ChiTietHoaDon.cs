using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace QuanLy.src.Abstractions.Data
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        [Column(Order = 0, TypeName = "numeric"), Required]
        [Display(Name = "Mã hóa đơn")]
        public decimal MaHD { get; set; }

        public HoaDon HoaDon { get; set; }

        [Column(Order = 1), StringLength(6), Required]
        [Display(Name = "Mã sản phẩm")]
        public string MaSP { get; set; }

        public SanPham SanPham { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Số lượng")]
        public decimal SoLuong { get; set; }
    }
}
