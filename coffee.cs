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
    public partial class coffee : Form
    {
        public coffee()
        {
            InitializeComponent();
        }

        private void coffee_Load(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu two = new menu();
            two.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DRINK five = new DRINK();
            five.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = int.Parse(numericUpDown1.Text);
            int b = int.Parse(comboBox2.Text);
            int outcome;
            {
                outcome = b * c;
                textBox2.Text = outcome.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM bakerytable";
            sql = "INSERT INTO bakerytable(ชื่อรายการ,จำนวน,ราคา,หมายเหตุ)VALUES('" + comboBox1.Text + "','" + numericUpDown1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')";

            MySqlConnection meneu = new MySqlConnection("host=localhost;user=admin;password=130943;database=bakeryDatabase");
            MySqlCommand cmd = new MySqlCommand(sql, meneu);
            meneu.Open();
            cmd.ExecuteNonQuery();
            meneu.Close();
            MessageBox.Show("เพิ่มสินค้าเรียบร้อยแล้วค่ะ !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Showmenu menu = new Showmenu();
            menu.Show();
            Close();
        }
    }
}
