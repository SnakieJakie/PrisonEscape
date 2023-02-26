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
    public partial class Rent_BestEnding : Form
    {
        public Rent_BestEnding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cave = new StartOfGame();
            cave.Show();
            this.Hide();
        }
    }
}
