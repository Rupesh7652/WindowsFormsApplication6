using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace WindowsFormsApplication6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UserClass uc = new UserClass();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrolebasedlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please provide Username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Password");
            }
           
            else
                try
                {
                    string role = uc.RoleBasedLogin(txtUsername.Text, txtPassword.Text);
                    if (role == "Debugger")
                    {
                        Dashboard db = new Dashboard();
                        db.Show();
                    }
                    else if (role == "User")
                    {
                        Dashboard db = new Dashboard();
                        db.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        HelperClass.makefields(groupBox1);
                        txtUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void BTNcANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrolebasedlogin_MouseHover(object sender, EventArgs e)
        {
           btnsignup .BackColor = Color.Orange;
          
        }

        private void btnsignup_MouseLeave(object sender, EventArgs e)
        {
            btnsignup.BackColor = Color.Gray;
        }

        private void BTNcANCEL_MouseHover(object sender, EventArgs e)
        {
            btncancel.BackColor = Color.Orange;
        }

        private void btncancel_MouseLeave(object sender, EventArgs e)
        {
            btncancel.BackColor = Color.Gray;
        }
    }
}
