using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblTacGia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTacGia { get; set; }

        [Required]
        [StringLength(150)]
        public string NameTacGia { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime NamSinh { get; set; }
        [Required]
        [StringLength(100)]
        public string QuocGia { get; set; }
        [Required]
        public string TieuSu { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayThem { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime NgaySua { get; set; }
    }
}
