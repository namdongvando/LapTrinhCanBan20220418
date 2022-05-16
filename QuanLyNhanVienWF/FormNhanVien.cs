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

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                //b1: chọn file
                string filePath = openFileDialog1.FileName;
                MessageBox.Show(filePath);
                // b2: dọc file
                string content = File.ReadAllText(filePath);
                // chuyển text-> json
                 List<NhanVien> DsNhanVien = JsonConvert.DeserializeObject
                    <List<NhanVien>>(content);
                // chuyển vào Class Nhan Viên
                NhanVien.DanhSachNhanVien = DsNhanVien;
                // Cap nhật datagridview
                dgvDanhSach.DataSource = DsNhanVien.ToList();

            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNv = dgvDanhSach.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            string tenNv = dgvDanhSach.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            string ngaySinh = dgvDanhSach.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            string diaChi = dgvDanhSach.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            string sdt = dgvDanhSach.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            string email = dgvDanhSach.Rows[e.RowIndex].Cells["Email"].Value.ToString();

            NhanVien.NhanVienSua = new NhanVien() {
                MaNV = maNv,
                TenNV = tenNv,
                DiaChi = diaChi,
                Email = email,
                NgaySinh = DateTime.Parse(ngaySinh),
                SDT = sdt
            };
            // gán giá trị mặc định cho form
            SetInputForm(NhanVien.NhanVienSua);
        }

        private void SetInputForm(NhanVien nhanVienSua)
        {
            txtMaNv.Text = nhanVienSua.MaNV;
            txtTenNv.Text = nhanVienSua.TenNV;
            txtDiaChi.Text = nhanVienSua.DiaChi;
            dtpNgaySinh.Value = nhanVienSua.NgaySinh;
            txtSDT.Text = nhanVienSua.SDT;
            txtEmail.Text = nhanVienSua.Email;
        }

        private void button3_Click(object sender, EventArgs e)
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

                if (txtEmail.Text != "" && IsValidEmail(txtEmail.Text) == false)
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
                nv.Update(nv);
                dgvDanhSach.DataSource = nv.GetAll().ToList(); 
                SetInputForm(new NhanVien()
                {
                    MaNV = string.Format("NV-00{0}",
                  nv.GetAll().Count() + 1)
                    ,NgaySinh = DateTime.Now,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn muốn xóa Nhân Viên Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (isXoa != DialogResult.Yes) {
                return;
            }

            string maNv = txtMaNv.Text;
            NhanVien nv = new NhanVien();
            nv.Delete(maNv);
            dgvDanhSach.DataSource = 
                nv.GetAll().ToList();
        }
    }
}
