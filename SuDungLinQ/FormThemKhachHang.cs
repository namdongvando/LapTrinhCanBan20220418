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
    public partial class FormThemKhachHang : Form
    {
        BanHangDataContext _db = new BanHangDataContext();


        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = new Customer() {
                    CustomerID = txtMa.Text,
                    CompanyName = txtTenCty.Text,
                    City = txtThanhPho.Text,
                    ContactName = txtTenLienHe.Text,
                    ContactTitle = txtChucDanh.Text,
                    Address = txtDiaChi.Text,
                    Country = txtQuocGia.Text,
                    Fax = txtFax.Text,
                    Phone = txtSdt.Text,
                    Region= txtKhuVuc.Text,
                    PostalCode = txtMaBuuChinh.Text
                };

                _db.Customers.InsertOnSubmit(cus);
                _db.SubmitChanges();
                // báo cho form danh sách reset lại danh sách khách hàng
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
