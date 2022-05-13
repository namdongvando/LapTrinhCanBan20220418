using Newtonsoft.Json;
using QuanLyNhanVienWF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienWF
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            dgvDanhSach.DataSource = nv.GetAll().ToList();
            txtMaNv.Text = string.Format("NV-00{0}",
                nv.GetAll().Count() + 1);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNv.Text == "")
                {
                    txtMaNv.Focus();
                    txtMaNv.SelectAll();
                    throw new Exception("Bạn Chưa Nhập Mã Nhân Viên");
                }
                if (txtTenNv.Text == "")
                {
                    txtTenNv.Focus();
                    txtTenNv.SelectAll();
                    throw new Exception("Bạn Chưa Nhập Tên Nhân Viên");
                }

                if (txtEmail.Text !="" &&  IsValidEmail(txtEmail.Text) == false)
                {
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    throw new Exception("Email Không đúng định dạng");
                }

                NhanVien nv = new NhanVien()
                {
                    MaNV = txtMaNv.Text
              ,
                    TenNV = txtTenNv.Text
              ,
                    DiaChi = txtDiaChi.Text
              ,
                    SDT = txtSDT.Text
              ,
                    Email = txtEmail.Text
              ,
                    NgaySinh = dtpNgaySinh.Value
                };
                nv.Insert(nv);
                dgvDanhSach.DataSource = nv.GetAll().ToList();
                txtMaNv.Text = string.Format("NV-00{0}",
                  nv.GetAll().Count() + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool IsValidEmail(string email)
        {

            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Json files (*.json)|*.json";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                NhanVien nv = new NhanVien();
                string fileContent = 
                    JsonConvert.SerializeObject(nv.GetAll());
                MessageBox.Show(saveFileDialog1.FileName);
                File.WriteAllText(saveFileDialog1.FileName, fileContent);
            }
        }
    }
}
