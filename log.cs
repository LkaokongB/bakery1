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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM userstable WHERE Username = '" + textUsername.Text + "'AND Password = '" + textPassword.Text + "'";

            MySqlConnection con = new MySqlConnection("host=localhost;user=admin;password=130943;database=usersdatabase");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {
                    
                }
            menu one = new menu();
            one.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register rgt = new register();
            rgt.Show();
            Close();
        }
    }
}
