using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblTheLoai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTheLoai { get; set; }
        [Required]
        [StringLength(150)]
        public string NameTheLoai { get; set; }
        [Required]
        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
