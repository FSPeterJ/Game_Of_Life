﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class Options : Form
    {

        int timems = 0;
        public Options()
        {
            InitializeComponent();
        }


        public int TimerMS
        {
            get
            {
                return timems;
            }
            set
            {
                timems = value;
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
