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
using BusinessLogicLayer;

namespace WindowsFormsApplication6
{
    public partial class Manageusers : Form
    {
        public Manageusers()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        UserClass uc = new UserClass();
        public int UserId;

        private void Manageusers_Load(object sender, EventArgs e)
        {
            dgvusersdetails.DataSource = uc.GetAllUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BlankFieldValidation() == false)
            {
                CreateUser();
            }
        }

        private void CreateUser()
        {
            try
            {
                bool result = blc.ManageUsers(0, txtfullname.Text, txtusername.Text, txtpassword.Text, cmbRole.Text, 1);
                if (result == true)
                {
                    DialogResult dr = MessageBox.Show("Do you want to add new user information?", "Add the new user",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("User Successfully Added");
                    dgvusersdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makefields(grpContainer);
                    txtfullname.Focus();
                }
                else
                {
                    MessageBox.Show("Error in Creating User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageUsers(UserId, txtfullname.Text, txtusername.Text, txtpassword.Text, cmbRole.Text, 2);
                if (result == true)
                {
                    DialogResult dr = MessageBox.Show("Are you want to update user information?", "Update the user",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("User Successfully Updated");
                    dgvusersdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makefields(grpContainer);
                    txtfullname.Focus();
                }
                else
                {
                    MessageBox.Show("Error in Updating User");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageUsers(UserId, txtfullname.Text, txtusername.Text, txtpassword.Text, cmbRole.Text, 3);
                if (result == true)
                {
                    DialogResult dr = MessageBox.Show("Are you want to delete user information?", "Delete the user",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("User Successfully Deleted");
                    dgvusersdetails.DataSource = uc.GetAllUsers();
                    HelperClass.makefields(grpContainer);

                }
                else
                {
                    MessageBox.Show("Error in deleting User");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvusersdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool BlankFieldValidation()
        {
            bool res = false;
            if (txtfullname.Text == "")
            {
                MessageBox.Show("Please Provide FullName");
                txtfullname.Focus();
                res = true;
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Please Provide UserName");
                txtusername.Focus();
                res = true;
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Provide Password");
                txtpassword.Focus();
                res = true;
            }

            else if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Role");
                res = true;
            }
           
            return res;
        }
    
        private void dgvusersdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = Convert.ToInt32(dgvusersdetails.SelectedRows[0].Cells["UserId"].Value.ToString());
            txtfullname.Text = dgvusersdetails.SelectedRows[0].Cells["FullName"].Value.ToString();
            txtusername.Text = dgvusersdetails.SelectedRows[0].Cells["Username"].Value.ToString();
            txtpassword.Text = dgvusersdetails.SelectedRows[0].Cells["Password"].Value.ToString();
            cmbRole.Text = dgvusersdetails.SelectedRows[0].Cells["Role"].Value.ToString();
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Brown;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MediumPurple;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Brown;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.MediumPurple;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Brown;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.MediumPurple;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Brown;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.MediumPurple;
        }
    }
    }

