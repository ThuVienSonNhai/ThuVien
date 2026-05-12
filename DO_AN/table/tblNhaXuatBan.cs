using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DO_AN.table
{
    internal class tblNhaXuatBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDNXB { get; set; }
        [Required]
        [StringLength(200)]
        public string NameNXB { get; set; }
        [Required]
        [StringLength(300)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(20)]
        public string SDT { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
