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
    public partial class Form1 : Form
    {
        BanHangDataContext _db = new BanHangDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            dgvDanhMuc.DataSource = _db.Categories
                .Select(cat => new
                {
                    CategoryId = cat.CategoryID,
                    CategoryName = cat.CategoryName,
                    Description = cat.Description
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = new Category()
                { 
                    CategoryName = txtTen.Text,
                    Description = txtMoTa.Text,
                };

                _db.Categories.InsertOnSubmit(cat);
                _db.SubmitChanges();
                LoadDanhMuc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ten = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
            string moTa = dgvDanhMuc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtMoTa.Text = moTa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = new Category()
                {
                    CategoryName = txtTen.Text,
                    Description = txtMoTa.Text,
                };

              var catDb =  _db.Categories.FirstOrDefault
                    (item=>item.CategoryID == int.Parse(txtMa.Text));
                catDb.CategoryName = cat.CategoryName;
                catDb.Description = cat.Description;
                _db.SubmitChanges();
                LoadDanhMuc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Category catDb = _db.Categories.FirstOrDefault(item=>item.CategoryID 
                == int.Parse(txtMa.Text));

                _db.Categories
                    .DeleteOnSubmit(catDb);

                _db.SubmitChanges();
                LoadDanhMuc();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormKhachHang();
            f.ShowDialog();
        }
    }
}
