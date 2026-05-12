using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblNhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDNhanVien { get; set; }
        [Required]
        [StringLength(150)]
        public string NameNhanVien { get; set; }
        [Required]
        public bool? GioiTinh { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }
        [Required]
        [StringLength(20)]
        public string SDT { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string ChucVu { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayTuyen { get; set; }
    }
}
