using C__Final_Project_MiniMart.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhapForm : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public DangNhapForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void dangNhapButton_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tenDangNhapTextBox.Text;
            string matKhau = matKhauTextBox.Text;

            string message = taiKhoanBUS.KiemTraDangNhap(tenDangNhap, matKhau);

            MessageBox.Show(message);

            if (message.Equals("Đăng nhập thành công!"))
            {
                TrangChuForm trangChuForm = new TrangChuForm(tenDangNhap);

                trangChuForm.ShowDialog();
            }
        }
    }
}
