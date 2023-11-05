using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class TaiKhoanDAO
    {
        public TaiKhoanDAO() { }

        public List<TaiKhoan> LayDanhSachTaiKhoan()
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = "SELECT * FROM TaiKhoan WHERE trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool) row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        //Tìm kiếm tài khoản bằng tên tài khoản
        public List<TaiKhoan> TimTaiKhoanBangTenTaiKhoan(string tenTaiKhoan)
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = $"SELECT * FROM TaiKhoan WHERE LOWER(tenTaiKhoan) LIKE '%{tenTaiKhoan}%' AND trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        //Tìm kiếm tài khoản bằng mã phân quyền
        public List<TaiKhoan> TimTaiKhoanBangMaPhanQuyen(string maPhanQuyen)
        {
            List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

            string query = $"SELECT * FROM TaiKhoan WHERE maPhanQuyen = '{maPhanQuyen}' AND trangThai = 1;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.maPhanQuyen = row["maPhanQuyen"].ToString();
                taiKhoan.tenTaiKhoan = row["tenTaiKhoan"].ToString();
                taiKhoan.matKhau = row["matKhau"].ToString();
                taiKhoan.trangThai = (bool)row["trangThai"];

                listTaiKhoan.Add(taiKhoan);
            }

            return listTaiKhoan;
        }

        //Kiểm tra đăng nhập
        public bool KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            string query = $"SELECT * FROM TaiKhoan WHERE trangThai = 1 AND tenTaiKhoan = '{tenTaiKhoan}' AND matKhau = '{matKhau}';";
            
            DataTable dataTable = DbHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        //Kiểm tra tài khoản đã tồn tại
        public bool KiemTraTaiKhoanDaTonTai(string tenTaiKhoan)
        {
            string query = $"SELECT tenTaiKhoan FROM TaiKhoan WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        //Thêm tài khoản mới
        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = $"INSERT INTO TaiKhoan VALUES ('{taiKhoan.maPhanQuyen}', '{taiKhoan.tenTaiKhoan}', '{taiKhoan.matKhau}', 1);";
            
            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(string tenTaiKhoan, string matKhauMoi)
        {
            string query = $"UPDATE TaiKhoan SET matKhau = '{matKhauMoi}' WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool KhoaTaiKhoan(string tenTaiKhoan)
        {
            string query = $"UPDATE TaiKhoan SET trangThai = 0 WHERE tenTaiKhoan = '{tenTaiKhoan}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}
