using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonEscape
{
    public partial class Bars_MainHall : Form
    {
        public Bars_MainHall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cave = new Bars_BackDoor();
            cave.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form cave = new Bars_ParkDoor();
            cave.Show();
            this.Hide();

        }
    }
}
