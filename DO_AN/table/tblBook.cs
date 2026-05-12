using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDBook { get; set; }

        [StringLength(250)]
        public string NameBook { get; set; }

        [Required] 
        public int IDTacGia { get; set; }

        public int IDTheLoai { get; set; }

        public int IDNhaXB { get; set; }

        public int NamXB { get; set; }

        [StringLength(20)]
        public string ISBN { get; set; }

        [StringLength(50)]
        public string NgonNgu { get; set; }

        public int SoTrang { get; set; }

        public decimal Gia { get; set; }

        public string MoTa { get; set; } 

        public int IDKeSach { get; set; }
    }
}
