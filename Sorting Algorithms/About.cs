using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbMain_Click(object sender, EventArgs e)
        {
            //this.lbMain.Text = "\r\nĐại học Quốc gia Thành phố Hồ Chí Minh";
            //this.lbMain.Text += "\r\nTrường Đại học Công nghệ Thông tin";
            //this.lbMain.Text += "\r\nĐồ án môn Cấu trúc dữ liệu và Giải thuật";
            //this.lbMain.Text += "\r\nViết bởi: Nguyễn Xuân Hảo";
            //this.lbMain.Text += "\r\nMã số sinh viên: 15520203";
            //this.lbMain.Text += "\r\nGiáo viên hướng dẫn: Cáp Phạm Đình Thăng";
            //this.lbMain.Text += "\r\n";
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
