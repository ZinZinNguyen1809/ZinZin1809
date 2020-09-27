using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void lblUseName_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn sẽ thoát chương trình ? ","Thông báo ",MessageBoxButtons.OKCancel )!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //bool Login(string userName, string passWord);
        /*{
            return false;
        }*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string userName = txtUseName.Text;
            //string passWord = txtPass.Text;
            //if (Login(userName, passWord))
            //{
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            //}
            //else
            //{
                //MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            //}
        }
    }
}
