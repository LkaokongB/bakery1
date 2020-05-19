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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAKERY bakery = new BAKERY();
            bakery.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coffee four = new coffee();
            four.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DRINK five = new DRINK();
            five.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Showmenu menu = new Showmenu();
            menu.Show();
            Close();
        }
    }
}
