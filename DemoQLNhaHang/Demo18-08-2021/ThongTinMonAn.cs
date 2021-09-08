using Demo18_08_2021.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo18_08_2021
{
    public partial class FoodForm : Form
    {
        public int _foodID;
        public FoodForm(int foodID=0)
        {
            InitializeComponent();
            _foodID = foodID;
        }
        public Food ReturnedFood;
        private void ThongTinMonAn_Load(object sender, EventArgs e)
        {
            cbbCategory.DataSource = WorkingContext.CategoryList;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Select Picture";
                dlg.Filter= "Image Files (JPEG, GIF, BMP, etc.)|"
               + "*.jpg;*.jpeg;*.gif;*.bmp;"
               + "*.tif;*.tiff;*.png|"
               + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
               + "GIF files (*.gif)|*.gif|"
               + "BMP files (*.bmp)|*.bmp|"
               + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
               + "PNG files (*.png)|*.png|"
               + "All files (*.*)|*.*";
                dlg.InitialDirectory = Environment.CurrentDirectory;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var fileName = dlg.FileName;
                    txtPic.Text = fileName;
                    pictureBox1.Load(fileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtFood.Text;
            var unit = txtUnit.Text;
            var decription = txtDecription.Text;
            var link = txtPic.Text;
            var price = Convert.ToInt32(nudUnitPrice.Value);
            var categoryId = Convert.ToInt32(cbbCategory.SelectedValue);

            if (_foodID==0)
            {
                int id =WorkingContext.FoodList.Any()? WorkingContext.FoodList.Max(f => f.Id) + 1:1;
                ReturnedFood  = new Food(id, name, unit, price, decription, link, categoryId);
                WorkingContext.FoodList.Add(ReturnedFood);
            }
            else
            {

            }
            DialogResult = DialogResult.OK;
        }


    }
}

