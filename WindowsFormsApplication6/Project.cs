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
                    HelperClass.makefields(panel1);
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
            try
            {
                ProjectId = Convert.ToInt32(dgvprojectdetails.SelectedRows[0].Cells["ProjectId"].Value.ToString());
                txtpname.Text = dgvprojectdetails.SelectedRows[0].Cells["ProjectName"].Value.ToString();
                dtpstart.Text = dgvprojectdetails.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtpend.Text = dgvprojectdetails.SelectedRows[0].Cells["EndDate"].Value.ToString();
                txtdescription.Text = dgvprojectdetails.SelectedRows[0].Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
