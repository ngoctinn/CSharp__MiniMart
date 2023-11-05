using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart.DAO
{
    public class PhieuNhapDAO
    {
        public PhieuNhapDAO() { }

        public List<PhieuNhap> GetAllPhieuNhap()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap;";


            DataTable dataTable = DbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                phieuNhap.maNhaCungCap = row["maNhaCungCap"].ToString();
                phieuNhap.maNhanVien = row["maNhanVien"].ToString();
                phieuNhap.maQuanLi = row["maQuanLi"].ToString();
                phieuNhap.thoiGianTao = (DateTime)row["thoiGianTao"];
                phieuNhap.thanhTien = (decimal)row["thanhTien"];
                phieuNhap.trangThaiDuyet = (bool)row["trangThaiDuyet"];
                phieuNhap.trangThai = (bool)row["trangThai"];

                listPhieuNhap.Add(phieuNhap);
            }

            return listPhieuNhap;
        }
    }
}
