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
    public partial class Bars_HopTheGate : Form
    {
        public Bars_HopTheGate()
        {
            InitializeComponent();
        }

        private void Bars_HopTheGate_Load(object sender, EventArgs e)
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
