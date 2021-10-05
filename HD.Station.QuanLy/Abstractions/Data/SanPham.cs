using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Data
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [StringLength(6), Required]
        [Display(Name = "Mã sản phẩm")]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string TenSp { get; set; }

        [StringLength(10)]
        [Display(Name = "Đơn vị tính")]
        public string DonViTinh { get; set; }

        [Column(TypeName = "numeric"), DisplayFormat()]
        [Display(Name = "Đơn giá")]
        public decimal DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
