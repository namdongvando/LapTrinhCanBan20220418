using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConnectDB
{
    public partial class FormDanhMucSanPham : Form
    {
        public FormDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void FormDanhMucSanPham_Load(object sender, EventArgs e)
        {
            ShowDataBySql("SELECT * FROM Categories");

        }
        private void ShowDataBySql(string sql)
        {
            string connectionString =
                                       ConfigurationManager
                                       .ConnectionStrings["NorthwindConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "GetAllProduct");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "GetAllProduct";
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format(@"SELECT * FROM Categories 
where CategoryName like '%{0}%'",txtTuKhoa.Text);
            ShowDataBySql(sql );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"insert into Categories 
(CategoryName, Description)
values(N'{0}', N'{1}')", txtTen.Text, txtMoTa.Text);

            string connectionString =                    ConfigurationManager
                                      .ConnectionStrings["NorthwindConnectionString"].ToString(); 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            // 
            ShowDataBySql("SELECT * FROM Categories");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ma = dataGridView1.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
            string Ten = dataGridView1.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            string MoTa = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            txtMa.Text = Ma;
            txtTen.Text = Ten;
            txtMoTa.Text = MoTa;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string mota = txtMoTa.Text;
            string sql = string.Format(@"update Categories
set CategoryName = N'{0}'
,Description = N'{1}'
where CategoryID = {2}", ten, mota, ma);

            string connectionString = ConfigurationManager
                                        .ConnectionStrings["NorthwindConnectionString"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            // 
            ShowDataBySql("SELECT * FROM Categories");

        }
    }
}
