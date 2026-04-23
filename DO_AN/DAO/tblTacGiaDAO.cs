using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAO
{
    internal class tblTacGiaDAO
    {

            SQL_CRUD data = new SQL_CRUD();

            public bool them(string NameTacGia, DateTime NamSinh, string QuocGia, string TieuSu, DateTime NgayThem, DateTime NgaySua)
            {
                string select = "INSERT INTO tblTacGia (NameTacGia, NamSinh, QuocGia, TieuSu, NgayThem, NgaySua) VALUES (@NameTacGia, @NamSinh, @QuocGia, @TieuSu, @NgayThem, @NgaySua)";
                using (SqlConnection con = data.GetSqlConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@NameTacGia", NameTacGia);
                    cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
                    cmd.Parameters.AddWithValue("@QuocGia", QuocGia);
                    cmd.Parameters.AddWithValue("@TieuSu", TieuSu);
                    cmd.Parameters.AddWithValue("@NgayThem", NgayThem);
                    cmd.Parameters.AddWithValue("@NgaySua", NgaySua);

                    int kiem = cmd.ExecuteNonQuery();
                    return kiem > 0;
                }
            }

            public bool xoa(int IDTacGia)
            {
                string select = "DELETE FROM tblTacGia WHERE IDTacGia = @IDTacGia";
                using (SqlConnection con = data.GetSqlConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@IDTacGia", IDTacGia);

                    int kiem = cmd.ExecuteNonQuery();
                    return kiem > 0;
                }
            }

            public bool sua(int IDTacGia, string NameTacGia, DateTime NamSinh, string QuocGia, string TieuSu, DateTime NgayThem, DateTime NgaySua)
            {
                string select = "UPDATE tblTacGia SET NameTacGia=@NameTacGia, NamSinh=@NamSinh, QuocGia=@QuocGia, TieuSu=@TieuSu, NgayThem=@NgayThem, NgaySua=@NgaySua WHERE IDTacGia=@IDTacGia";
                using (SqlConnection con = data.GetSqlConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@IDTacGia", IDTacGia);
                    cmd.Parameters.AddWithValue("@NameTacGia", NameTacGia);
                    cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
                    cmd.Parameters.AddWithValue("@QuocGia", QuocGia);
                    cmd.Parameters.AddWithValue("@TieuSu", TieuSu);
                    cmd.Parameters.AddWithValue("@NgayThem", NgayThem);
                    cmd.Parameters.AddWithValue("@NgaySua", NgaySua);

                    int kiem = cmd.ExecuteNonQuery();
                    return kiem > 0;
                }
            }
    }
}
