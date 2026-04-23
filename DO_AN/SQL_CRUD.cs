using DO_AN.DAO;
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
    }
}
