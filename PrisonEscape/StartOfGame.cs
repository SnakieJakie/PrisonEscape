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
    public partial class StartOfGame : Form
    {
        public StartOfGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cave = new Bars_MainHall();
            cave.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cave = new Melt_Jump();
            cave.Show();
            this.Hide();

        }
    }
}
