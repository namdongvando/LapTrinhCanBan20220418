using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class FormKhachHang : Form
    {
        BanHangDataContext _db = new BanHangDataContext();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            dataGridView1.DataSource =
                _db.Customers.ToList();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = textBox1.Text;
            if(tukhoa.Length < 2) {
                return;
            }
            dataGridView1.DataSource = 
            _db.Customers.Where(
                kh => kh.CompanyName.Contains(tukhoa)
            ||  kh.CustomerID.Contains(tukhoa)).ToList();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormThemKhachHang();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form fsua = new FormSuaKhachHang();
            fsua.ShowDialog();

        }
    }
}
