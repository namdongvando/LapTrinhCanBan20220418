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
    public partial class FormPTB2 : Form
    {
        public FormPTB2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                PTB2 ptb2 = InputForm();
                txtX.Text = ptb2.X1.ToString();
                txtX2.Text = ptb2.X2.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private PTB2 InputForm()
        {
            double a = 0, b = 0, c = 0; 
            if (double.TryParse(txtSoA.Text, out a) == false)
            {
                txtSoA.Focus();
                txtSoA.SelectAll();
                throw new Exception("Số A Không đúng dịnh dạng");
            }
            if (double.TryParse(txtSoB.Text, out b) == false)
            {
                txtSoB.Focus();
                txtSoB.SelectAll();
                throw new Exception("Số B Không đúng dịnh dạng");
            }
            if (double.TryParse(txtSoC.Text, out c) == false)
            {
                txtSoC.Focus();
                txtSoC.SelectAll();
                throw new Exception("Số C Không đúng dịnh dạng");
            }
            return new PTB2(a, b, c);
        }
    }
}
