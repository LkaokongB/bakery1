using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Showmenu : Form
    {
        public Showmenu()
        {
            InitializeComponent();
        }

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM bakerytable";

            MySqlConnection meneu = new MySqlConnection("host=localhost;user=admin;password=130943;database=bakeryDatabase");
            MySqlCommand cmd = new MySqlCommand(sql, meneu);
            meneu.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
            meneu.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete zero = new delete();
            zero.Show();
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*e.Graphics.DrawString("ใบรายการสินค้า", new Font("TH SarabunPSK", 20,FontStyle.Bold), Brushes.Black,new Point(350,20));
            e.Graphics.DrawString("ลำดับ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString("ชื่อรายการ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(160, 80));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(460, 80));
            e.Graphics.DrawString("ราคารวม", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(580, 80));
            e.Graphics.DrawString("หมายเหตุ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(710, 80));*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            spend jai = new spend();
            jai.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu one = new menu();
            one.Show();
            Close();
        }
    }
}
