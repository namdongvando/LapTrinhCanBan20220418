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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form fDangNhap = new FormDangNhap();
            fDangNhap.ShowDialog();
        }

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          var kt=   MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông Báo", 
                MessageBoxButtons.YesNo);
            if (kt != DialogResult.Yes) {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new FormPTB1();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new FormPTB2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FormDongHo();
            f.ShowDialog();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormNhanVien();
            f.ShowDialog();
        }
    }
}
