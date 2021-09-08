using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCheckListBox
{
    public partial class Form1 : Form
    {
        private string[] arr;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {    
                CheckedListBox.CheckedItemCollection items;
                arr = new string[10];
                int i = clbMonHoc.SelectedIndex;
                items = this.clbMonHoc.CheckedItems;
                foreach (object item in items)
                {
                    arr[i] += item.ToString() + "\n";
                }

            }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var item in arr)
            {
                s += item + "\n";

            }
            MessageBox.Show("Môn học đã đăng ký thành công:" + s);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

