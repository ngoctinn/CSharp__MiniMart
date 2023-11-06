using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class NhaCungCapDAO
    {
        public NhaCungCapDAO() { }

        public List<NhaCungCap> LayDanhSachNhaCungCap()
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();

            string query = "SELECT * FROM NhaCungCap;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.maNhaCungCap = row["maNhaCungCap"].ToString();
                nhaCungCap.tenNhaCungCap = row["tenNhaCungCap"].ToString();
                nhaCungCap.soDienThoai = row["soDienThoai"].ToString();
                nhaCungCap.email = row["email"].ToString();
                nhaCungCap.diaChi = row["diaChi"].ToString();
                
                listNhaCungCap.Add(nhaCungCap);
            }

            return listNhaCungCap;
        }

        public NhaCungCap LayNhaCungCapTheoTen(string tenNhaCungCap)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();

            string query = $"SELECT * FROM NhaCungCap WHERE tenNhaCungCap = '{tenNhaCungCap}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            nhaCungCap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
            nhaCungCap.tenNhaCungCap = dataTable.Rows[0]["tenNhaCungCap"].ToString();
            nhaCungCap.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
            nhaCungCap.email = dataTable.Rows[0]["email"].ToString();
            nhaCungCap.diaChi = dataTable.Rows[0]["diaChi"].ToString();

            return nhaCungCap;
        }

        public int DemSoNhaCungCap()
        {
            string query = "SELECT COUNT(*) AS SoNhaCungCap FROM NhaCungCap;";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoNhaCungCap"];

            return count;
        }

        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = $"INSERT INTO NhaCungCap VALUES ('{nhaCungCap.maNhaCungCap}', '{nhaCungCap.tenNhaCungCap}', '{nhaCungCap.soDienThoai}', '{nhaCungCap.email}', '{nhaCungCap.diaChi}');";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool KiemTraDaTonTai(string tenNhaCungCap)
        {
            string query = $"SELECT tenNhaCungCap FROM NhaCungCap WHERE LOWER(tenNhaCungCap) = '{tenNhaCungCap}';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = $"UPDATE NhaCungCap SET tenNhaCungCap = '{nhaCungCap.tenNhaCungCap}', soDienThoai = '{nhaCungCap.soDienThoai}', email = '{nhaCungCap.email}', diaChi = '{nhaCungCap.diaChi}' WHERE maNhaCungCap = '{nhaCungCap.maNhaCungCap}';";

            int rowsAffected = DbHelper.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string keyword)
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();

            string query = $"SELECT * FROM NhaCungCap WHERE LOWER(tenNhaCungCap) LIKE '%{keyword}%' " +
                $"OR soDienThoai LIKE '%{keyword}%' OR LOWER(email) LIKE '%{keyword}%' OR LOWER(diaChi) LIKE '%{keyword}%';";

            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap();

                nhaCungCap.maNhaCungCap = row["maNhaCungCap"].ToString();
                nhaCungCap.tenNhaCungCap = row["tenNhaCungCap"].ToString();
                nhaCungCap.soDienThoai = row["soDienThoai"].ToString();
                nhaCungCap.email = row["email"].ToString();
                nhaCungCap.diaChi = row["diaChi"].ToString();

                listNhaCungCap.Add(nhaCungCap);
            }

            return listNhaCungCap;
        }
    }
}
