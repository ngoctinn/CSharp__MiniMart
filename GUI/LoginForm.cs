using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__Final_Project_MiniMart.BUS;
using C__Final_Project_MiniMart.DTO;

namespace C__Final_Project_MiniMart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            var taiKhoanBUS = new TaiKhoanBUS();
        }
    }
}
