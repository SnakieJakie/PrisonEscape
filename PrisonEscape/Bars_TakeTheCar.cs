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
    public partial class Bars_TakeTheCar : Form
    {
        public Bars_TakeTheCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cave = new Rent_Thinking();
            cave.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cave = new Rent_TurnCourtRoom();
            cave.Show();
            this.Hide();
        }
    }
}
