using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using DO_AN.table;

namespace DO_AN
{
    internal class dbData:DbContext
    {
        public dbData() : base("name=link_sql")
        {

        }
        public DbSet<tblBook> Book { get; set; }
        public DbSet<tblCTMuonSach> CTMuonSach { get; set; }
        public DbSet<tblKhachHang> KhachHang { get; set; }
        public DbSet<tblNhanVien> NhanVien { get; set; }
        public DbSet<tblNhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<tblPhieuMuon> PhieuMuon { get; set; }
        public DbSet<tblSLSach> SLSach { get; set; }
        public DbSet<tblTacGia> TacGia { get; set; }
        public DbSet<tblTheLoai> TheLoai { get; set; }
        public DbSet<tblViTriSach> ViTriSach { get; set; }

    }
}
