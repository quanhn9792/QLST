using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagement
{
    public partial class FrmLogin : Form
    {
        FrmMain Main = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnOK.PerformClick();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            try
            {
                using (SMManagementEntities test = new SMManagementEntities())
                {
                    var query = from o in test.SM_User
                                where o.UserName == txtUser.Text&& o.PassWord == txtPass.Text
                                select o;
                    if(query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("You have been successfully Logged in.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //Add your code process login here
                        if (Main == null || this.Main.IsDisposed)
                            Main = new FrmMain();
                        Main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
