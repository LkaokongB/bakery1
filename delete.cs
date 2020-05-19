using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM bakerytable";
            sql = "DELETE FROM bakerytable WHERE ชื่อรายการ = '" + textBox1.Text + "'";

            MySqlConnection meneu = new MySqlConnection("host=localhost;user=admin;password=130943;database=bakeryDatabase");
            MySqlCommand cmd = new MySqlCommand(sql, meneu);
            meneu.Open();
            cmd.ExecuteNonQuery();
            meneu.Close();
            MessageBox.Show("ลบสินค้าเรียบร้อยแล้วค่ะ !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Showmenu menu = new Showmenu();
            menu.Show();
            Close();
        }
    }
}
