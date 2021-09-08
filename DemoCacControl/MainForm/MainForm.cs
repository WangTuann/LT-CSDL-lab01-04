using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class mainForm : Form
    {
        List<DiningTable> tableList;
        public mainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (login.ShowDialog()!=DialogResult.OK)
            {
                Application.Exit();
            }

            tableList = new List<DiningTable>();
            Random r = new Random();
            for (int i = 1;  i< 27; i++)
            {
                DiningTable table = new DiningTable();
                table.TableName=$"bàn{i}";
                table.TableID = i;
                table.Status = r.Next(0, 2);
                table.Floor = r.Next(1, 4);

                tableList.Add(table);
            }

            LoadTableListFLP();
           // LoadTableListv();
            LoadListViewTableToLvDetail();


        }
        private void LoadTableListFLP()
        {
            var floors = new[] { flpFloor1, flpFloor2, flpFloor3 };
            foreach (var table in tableList)
            {
                Button btn = new Button();
                btn.Text = table.TableName + "\r\n" + (table.Status == 1 ? "Có người" : "Trống");
                btn.BackColor = (table.Status == 1 ? Color.Aquamarine : Color.Orange);
                btn.Height = 40;
                btn.Width = 80;
                ttFloor.SetToolTip(btn, $"Tầng {table.Floor}");

                floors[table.Floor - 1].Controls.Add(btn);
            }
        }
        private void LoadTableListv()
        {
            ListViewGroup floorOne = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
            ListViewGroup floorTwo = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
            ListViewGroup floorThree = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);

            lvTableList.Groups.Add(floorOne);
            lvTableList.Groups.Add(floorTwo);
            lvTableList.Groups.Add(floorThree);

            var floorsGroup = new[] { floorOne, floorTwo, floorThree };

            foreach (var table in tableList)
            {
                ListViewItem item = new ListViewItem(table.TableName,table.Status);

                item.Group = floorsGroup[table.Floor - 1];
                lvTableList.Items.Add(item);

            }
        }
        private void LoadListViewTableToLvDetail()
        {
            foreach (var table in tableList)
            {
                ListViewItem item = new ListViewItem(table.TableID.ToString());
                item.SubItems.Add(table.TableName);
                item.SubItems.Add(table.Status==1?"Có người":"Trống");
                item.SubItems.Add(table.Floor.ToString());

                lvTableList.Items.Add(item);
            }
        }

        private void lvTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var count = lvTableList.SelectedItems.Count;
            if (count>0)
            {
                var item = lvTableList.SelectedItems[0];
                txtTableID.Text = item.SubItems[0].Text;
                txtTableName.Text = item.SubItems[1].Text;
                cbbFloor.SelectedIndex = int.Parse(item.SubItems[3].Text) - 1;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var tableName = txtTableName.Text;
            var floor = int.Parse(cbbFloor.SelectedText);
            var tableID = tableList.Max(p => p.TableID) + 1;


           

        }
    }
}
