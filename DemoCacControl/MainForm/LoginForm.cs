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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginName = txtLoginName.Text;
            var passWord = txtPassword.Text;
            if (loginName == "Tuan" && passWord == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu. ";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
