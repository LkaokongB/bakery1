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
    public partial class BAKERY : Form
    {
        public BAKERY()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu two = new menu();
            two.Show();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            coffee four = new coffee();
            four.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void BAKERY_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
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
    }
}
