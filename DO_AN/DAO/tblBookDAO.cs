using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.DAO
{
    internal class tblBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDBook { get; set; }
        [Required]
        [StringLength(250)]
        public string NameBook { get; set; }

        [Required]
        [StringLength(20)]
        public string ISBN { get; set; }
        [Required]
        [StringLength(50)]
        public string NgonNgu { get; set; }
        [Required]
        public string MoTa { get; set; }
        [Required] public int IDTacGia { get; set; }
        [Required] public int IDTheLoai { get; set; }
        [Required] public int IDNhaXB { get; set; }
        [Required] public int NamXB { get; set; }
        [Required] public int IDKeSach { get; set; }
        [Required] public int SoTrang { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Gia { get; set; }





    }
}
