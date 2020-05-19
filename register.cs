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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM userstable";
            sql = "INSERT INTO userstable(Name,Username,Password)VALUES('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";

            MySqlConnection meneu = new MySqlConnection("host=localhost;user=admin;password=130943;database=usersdatabase");
            MySqlCommand cmd = new MySqlCommand(sql, meneu);
            meneu.Open();
            
            cmd.ExecuteNonQuery();
            meneu.Close();
            MessageBox.Show("สมัครสมาชิกเรียบร้อยแล้วค่ะ !");

            log login = new log();
            login.Show();
            Close();
        }
    }
}
