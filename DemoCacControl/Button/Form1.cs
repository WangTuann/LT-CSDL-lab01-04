using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
            {
                this.btnButton.ForeColor = Color.Red;
            }
            else
            {
                this.btnButton.ForeColor = Color.Black;
            }
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
            {
                this.btnButton.BackColor = Color.LightCyan;
            }
            else
            {
                this.btnButton.BackColor = this.btnButtonFlat.BackColor;
            }
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
            {
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
            }
        }
    }
}
