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
                CreateUser();
            }
        }

        private void CreateUser()
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
                    MessageBox.Show("Project Added Sucessfully");
                    dgvprojectdetails.DataSource = pc.GetAllProducts();
                    HelperClass.makefields(dtpstart);
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
            dgvprojectdetails.DataSource = pc.GetAllProducts();
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
                    MessageBox.Show("Project SUCESSFULLY UPDATED");
                    dgvprojectdetails.DataSource = pc.GetAllProducts();
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
                    MessageBox.Show("Project SUCESSFULLY DELETED");
                    dgvprojectdetails.DataSource = pc.GetAllProducts();
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
    }
}
