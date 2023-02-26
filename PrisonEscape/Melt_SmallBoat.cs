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
    public partial class Melt_SmallBoat : Form
    {
        public Melt_SmallBoat()
        {
            InitializeComponent();
        }

        private void Melt_SmallBoat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cave = new StartOfGame();
            cave.Show();
            this.Hide();
        }
    }
}
