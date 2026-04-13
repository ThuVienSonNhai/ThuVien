using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DO_AN.DAO
{
    internal class tblBookDAO
    {
        SQL_CRUD data = new SQL_CRUD();
        public bool them(string NameBook, int IDTacGia, int IDTheLoai, int IDNhaXB, int NamXB,string ISBN, string NgonNgu, int SoTrang,decimal Gia, string MoTa, int ViTri)
        {
            string select = "INSERT INTO tblBook (NameBook, IDTacGia, IDTheLoai, IDNhaXB, NamXB, ISBN, NgonNgu, SoTrang, Gia, MoTa, IDKeSach) VALUES (@NameBook, @IDTacGia, @IDTheLoai, @IDNhaXB, @NamXB, @ISBN, @NgonNgu, @SoTrang, @Gia, @MoTa, @IDKeSach)";
            using (SqlConnection con = data.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@NameBook", NameBook);
                cmd.Parameters.AddWithValue("@IDTacGia", IDTacGia);
                cmd.Parameters.AddWithValue("@IDTheLoai", IDTheLoai);
                cmd.Parameters.AddWithValue("@IDNhaXB", IDNhaXB);
                cmd.Parameters.AddWithValue("@NamXB", NamXB);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);
                cmd.Parameters.AddWithValue("@SoTrang", SoTrang);
                cmd.Parameters.AddWithValue("@Gia", Gia);
                cmd.Parameters.AddWithValue("@MoTa", MoTa);
                cmd.Parameters.AddWithValue("@IDKeSach", ViTri);
                int kiem = cmd.ExecuteNonQuery();
                return kiem > 0;
            }
        }
        public bool xoa(int IDBook)
        {
            string select = "Delete from tblBook where IDBook = (@IDBook)";
            using (SqlConnection con = data.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@IDBook",IDBook );
                int kiem = cmd.ExecuteNonQuery();
                return kiem > 0;
            }
        }
        public bool sua(int IDBook, string NameBook, int IDTacGia, int IDTheLoai, int IDNhaXB, int NamXB, string ISBN, string NgonNgu, int SoTrang, decimal Gia, string MoTa, int ViTri)
        {
            string select = "UPDATE tblBook SET NameBook=@NameBook, IDTacGia=@IDTacGia, IDTheLoai=@IDTheLoai, IDNhaXB=@IDNhaXB, NamXB= @NamXB, ISBN=@ISBN, NgonNgu=@NgonNgu, SoTrang=@SoTrang, Gia=@Gia, MoTa=@MoTa, IDKeSach=@IDKeSach WHERE IDBook = @IDBook";
            using (SqlConnection con = data.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(select, con);
                cmd.Parameters.AddWithValue("@IDBook", IDBook);
                cmd.Parameters.AddWithValue("@NameBook", NameBook);
                cmd.Parameters.AddWithValue("@IDTacGia", IDTacGia);
                cmd.Parameters.AddWithValue("@IDTheLoai", IDTheLoai);
                cmd.Parameters.AddWithValue("@IDNhaXB", IDNhaXB);
                cmd.Parameters.AddWithValue("@NamXB", NamXB);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);
                cmd.Parameters.AddWithValue("@SoTrang", SoTrang);
                cmd.Parameters.AddWithValue("@Gia", Gia);
                cmd.Parameters.AddWithValue("@MoTa", MoTa);
                cmd.Parameters.AddWithValue("@IDKeSach", ViTri);
                int kiem = cmd.ExecuteNonQuery();
                return kiem > 0;
            }
        }
    }
}
