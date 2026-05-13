using DO_AN.DAO;
using DO_AN.tblTable;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
    internal class sql_crud : DbContext
    {
        public sql_crud() : base("name=link_sql")
        {

        }
        public DbSet<tblBook> Book { get; set; }    
        public DbSet<tblTacGia> TacGia { get; set; }
        public DbSet<tblKhachHang> KhachHang { get; set; }
        public DbSet<tblTheLoai> TheLoai { get; set; }
    }
}
