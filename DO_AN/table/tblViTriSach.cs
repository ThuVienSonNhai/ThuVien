using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblViTriSach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDViTri { get; set; }
        [Required]
        [StringLength(50)]
        public string NameViTri { get; set; }
        [Required]
        public int? Tang { get; set; }
        [Required]
        [StringLength(200)]
        public string MoTa { get; set; }
    }
}
