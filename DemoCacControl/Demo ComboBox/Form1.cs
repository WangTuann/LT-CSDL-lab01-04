﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn " + this.cbbNgoaiNgu.SelectedItem.ToString());
        }
    }
}