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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication6
{
    public partial class Viewbug : Form
    {
        BugClass bc = new BugClass();
        public Viewbug()
        {
            InitializeComponent();
            dgvviewbug.DataSource = bc.GetAllBugs();
        }
        
      

       
    
        private void dgvviewbug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // BugId = Convert.ToInt32(dgvviewbug.SelectedRows[0].Cells["BugId"].Value.ToString());
         //   cmbproject.Text = dgvviewbug.SelectedRows[0].Cells["FullName"].Value.ToString();
         //   txtclass.Text = dgvusersdetails.SelectedRows[0].Cells["Username"].Value.ToString();
          //  txtpassword.Text = dgvusersdetails.SelectedRows[0].Cells["Password"].Value.ToString();
          //  cmbRole.Text = dgvusersdetails.SelectedRows[0].Cells["Role"].Value.ToString();
        }

        private void Viewbug_Load(object sender, EventArgs e)
        {

        }
    }
}
