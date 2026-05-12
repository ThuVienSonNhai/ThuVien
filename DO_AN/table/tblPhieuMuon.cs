using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblPhieuMuon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPhieuMuon { get; set; }

        [Required]
        public int IDKhachHang { get; set; }

        [Required]
        public int IDNhanVien { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? HanTra { get; set; }
        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }
    }
}
