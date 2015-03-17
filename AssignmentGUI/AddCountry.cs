﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class AddCountry : Form
    {
        public AddCountry()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Program.newCountryName = newCountryBox.Text;
            this.Close();
        }

        private void newCountryBox_TextChanged(object sender, EventArgs e)
        {
            if (newCountryBox.Text.Length == 1)
            {
                newCountryBox.Text = newCountryBox.Text.ToString().ToUpper();
                newCountryBox.Select(newCountryBox.Text.Length, 0);
            }
        }
    }
}
