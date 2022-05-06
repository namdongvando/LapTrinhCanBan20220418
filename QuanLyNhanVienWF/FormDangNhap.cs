using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienWF
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            try
            {
                if (taiKhoan == "admin" && matKhau == "123456") {
                    DialogResult = DialogResult.OK;
                    return; 
                }
                throw new Exception("Tài khoản/ mật khẩu không đúng");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
