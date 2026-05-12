using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblKhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDKhachHang { get; set; }
        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }
        [Required]
        public bool? GioiTinh { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [Required]
        [StringLength(20)]
        public string SDT { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(300)]
        public string DiaChi { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }
    }
}
