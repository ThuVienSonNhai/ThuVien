using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.tblTable
{
    internal class tblTheLoai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTheLoai { get; set; }

        [Required]
        [StringLength(150)]
        public string NameTheLoai { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
