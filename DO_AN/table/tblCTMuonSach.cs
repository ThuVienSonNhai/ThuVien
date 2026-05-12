using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblCTMuonSach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCTMuonSach { get; set; }

        [Required]
        public int IDPhieuMuon { get; set; }

        [Required]
        public int IDBook { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }
        [Required]
        public decimal? TienPhat { get; set; }
        [Required]
        [StringLength(100)]
        public string TinhTrang { get; set; }
    }
}
