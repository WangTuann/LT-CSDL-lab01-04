using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextbox
{
    public partial class MaskedTestBox : Form
    {
        public MaskedTestBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("So dien thoai cua ban la " + maskedTextBox1.Text + "\nNgay sinh cua ban la" + maskedTextBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
