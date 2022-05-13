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
    public partial class FormDongHo : Form
    {
        public int ThoiGian { get; private set; } = 1;
        public int RoiXuong { get; private set; } = 1;

        public FormDongHo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString();
        }

        private void FormDongHo_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int y = RoiXuong * 2 * ThoiGian;
            ThoiGian++;
            int positionX = pictureBox1.Location.X;
            int positionY = pictureBox1.Location.Y;
            positionY += y;
            // cận dưới
            if (positionY + pictureBox1.Height + 50 >= this.Height)
            {
               
                ThoiGian = 1;
                RoiXuong = -1;
                timer2.Stop();
                return;

            }
            // cận trên
            if (positionY-25 <= 0)
            {
                ThoiGian = 1;
                RoiXuong = 1;
            }
            //if (positionX+ pictureBox1.Width >= this.Width) {
            //    positionX = 0;
            //}
            //positionX = 2 * ThoiGian;
            pictureBox1.Location = new Point(
                positionX , positionY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            RoiXuong = -1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int positionX = pictureBox2.Location.X;
            int positionY = pictureBox2.Location.Y;
            positionX= positionX - 10;
            if (positionX <= 0) {
                positionX = Width;
            }
            pictureBox2.Location = new Point(positionX,positionY);
        }
    }
}
