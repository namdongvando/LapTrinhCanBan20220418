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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = string.Format(
                "SELECT * FROM Products"
                , txtTuKhoa.Text);
            ShowDataBySql(sql);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.northwindDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getProductsByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.GetProductsByName(this.northwindDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getProductsByNameToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void getProductsByKeywordToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.GetProductsByKeyword(this.northwindDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text.Length >= 2)
            {
                string sql = string.Format(
              "SELECT * FROM Products where ProductName like '%{0}%'"
              , txtTuKhoa.Text);
                ShowDataBySql(sql);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format(
               "SELECT * FROM Products where ProductName like '%{0}%'"
               , txtTuKhoa.Text);
            ShowDataBySql(sql);

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

        private void quảngLýDanhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fdm = new FormDanhMucSanPham();
            fdm.ShowDialog();
        }
    }
}
