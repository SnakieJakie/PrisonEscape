﻿using System;
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
    public partial class Rent_TurnCourtRoom : Form
    {
        public Rent_TurnCourtRoom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cave = new Rent_BestEnding();
            cave.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cave = new Rent_Fail();
            cave.Show();
            this.Hide();
        }
    }
}
// What how am I understanding this