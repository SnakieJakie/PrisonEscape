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
    public partial class Rent_Fail : Form
    {
        public Rent_Fail()
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
// Note to self, don't copy stuff and then call it a day.