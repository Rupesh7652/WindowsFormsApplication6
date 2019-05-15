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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        ProjectClass pc = new ProjectClass();

        public int ProjectId;
        private void button1_Click(object sender, EventArgs e)
        {
            if (BlankFieldValidation() == false)
            {
                CreateProject();
            }
        }

        private void CreateProject()
        {
            try
            {
                bool rs = blc.ManageProduct(0,
                    txtpname.Text,
                    Convert.ToDateTime(dtpstart.Text),
                    Convert.ToDateTime(dtpend.Text),
                    txtdescription.Text,
                    1);
                if (rs == true)
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add new project information?", "Add the new project",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("Project Successfully Added");
                        dgvprojectdetails.DataSource = pc.GetAllProjects();
                    HelperClass.makefields(dtpstart);
                    txtpname.Focus();
                }
                else
                {
                    MessageBox.Show("Error in Adding Project");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvprojectdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvprojectdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ProjectId = Convert.ToInt32(dgvprojectdetails.SelectedRows[0].Cells["ProjectId"].Value.ToString());
            txtpname.Text = dgvprojectdetails.SelectedRows[0].Cells["ProjectName"].Value.ToString();
            dtpstart.Text = dgvprojectdetails.SelectedRows[0].Cells["StartDate"].Value.ToString();
            dtpend.Text = dgvprojectdetails.SelectedRows[0].Cells["EndDate"].Value.ToString();
            txtdescription.Text = dgvprojectdetails.SelectedRows[0].Cells["Description"].Value.ToString();

        }

        private void Project_Load(object sender, EventArgs e)
        {
            dgvprojectdetails.DataSource = pc.GetAllProjects();
        }
        public bool BlankFieldValidation()
        {
            bool res = false;
            if (txtpname.Text == "")
            {
                MessageBox.Show("Please Provide ProjectName");
                txtpname.Focus();
                res = true;
            }
            else if (txtdescription.Text == "")
            {
                MessageBox.Show("Please Provide Description");
                txtdescription.Focus();
                res = true;
           
            }

            return res;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = blc.ManageProduct(ProjectId,
                    txtpname.Text,
                    Convert.ToDateTime(dtpstart.Text),
                    Convert.ToDateTime(dtpend.Text),
                    txtdescription.Text,
                    2);
                if (rs == true)
                {
                    DialogResult dr = MessageBox.Show("Are you want to update project information?", "Update the project",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                     MessageBox.Show("Project Successfully Updated");
                    dgvprojectdetails.DataSource = pc.GetAllProjects();
                    HelperClass.makefields(txtpname);
                    txtpname.Focus();
                }
                else MessageBox.Show("ERROR IN UPDATING Project");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = blc.ManageProduct(ProjectId,
                  txtpname.Text,
                  Convert.ToDateTime(dtpstart.Text),
                  Convert.ToDateTime(dtpend.Text),
                  txtdescription.Text,
                3);
                if (rs == true)
                {
                    DialogResult dr = MessageBox.Show("Are you want to delete project information?", "Delete the project",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("Project Successfully Deleted");
                    dgvprojectdetails.DataSource = pc.GetAllProjects();
                    HelperClass.makefields(txtpname);
                    txtpname.Focus();
                }
                else MessageBox.Show("ERROR IN DELETING Project");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Purple;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Purple;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Purple;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }
    }
}
