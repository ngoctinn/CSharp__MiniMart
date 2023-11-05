using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_MiniMart.DTO
{
    public class PhanQuyen
    {
        public PhanQuyen()
        {

        }

        public PhanQuyen(string maPhanQuyen, string tenPhanQuyen)
        {
            this.maPhanQuyen = maPhanQuyen;
            this.tenPhanQuyen = tenPhanQuyen;
        }

        public string maPhanQuyen {  get; set; }
        public string tenPhanQuyen { get; set; }
    }
}
