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

        public List<NhaCungCap> GetAllNhaCungCap()
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
    }
}
