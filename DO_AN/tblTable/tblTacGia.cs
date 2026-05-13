using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAO
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
        public DateTime NamSinh { get; set; }

        [Required]
        [StringLength(100)]
        public string QuocGia { get; set; }

        [Required]
        public string TieuSu { get; set; }
        [Required]
        public DateTime NgayThem { get; set; }
        [Required]
        public DateTime NgaySua { get; set; }
    }
}

