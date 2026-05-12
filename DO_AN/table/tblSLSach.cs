using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblSLSach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDSoLuongSach { get; set; }

        [Required]
        public int IDBook { get; set; }
        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }
    }
}
