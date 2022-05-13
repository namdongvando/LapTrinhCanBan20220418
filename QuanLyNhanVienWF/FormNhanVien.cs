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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = txtMaNv.Text
                , TenNV = txtTenNv.Text
                , DiaChi = txtDiaChi.Text
                , SDT = txtSDT.Text
                , Email = txtEmail.Text
                , NgaySinh = dtpNgaySinh.Value.ToString()
            };
            nv.Insert(nv);
            dgvDanhSach.DataSource = nv.GetAll().ToList() ;
        }
    }
}
