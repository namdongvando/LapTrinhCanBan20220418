using QuanLyNhanVienWF.Model;
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
    public partial class FormPTB1 : Form
    {
        public FormPTB1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            PhuongTrinh pt = new PhuongTrinh();
            try
            {
               pt = InputForm();
               txtX.Text = pt.Giai().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private PhuongTrinh InputForm()
        {
            PhuongTrinh pt = new PhuongTrinh();
            double a, b;
            if (double.TryParse(txtSoA.Text, out a) ==false){
                // chuyển con trỏ đến textbox
                txtSoA.Focus();
                // chọn tất cả nội dung đang có
                txtSoA.SelectAll();
                throw new Exception("So A Không Hợp Lệ");

            }
            if (double.TryParse(txtSoB.Text, out b) == false)
            {
                // chuyển con trỏ đến textbox
                txtSoB.Focus();
                // chọn tất cả nội dung đang có
                txtSoB.SelectAll();
                throw new Exception("So B Không Hợp Lệ"); 
            }
            pt.SoA = a;
            pt.SoB = b;
            return pt;
        }
    }
}
