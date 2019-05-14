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
    public partial class solutionform : Form
    {
        public solutionform()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        UserClass uc = new UserClass();
        ProjectClass pc = new ProjectClass();
        BugClass bc = new BugClass();
        SolutionClass sc = new SolutionClass();
        public int BugId;
        public int ProjectId;
        public int UserId;
        public int SolutionId;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pberror.Image.Save(ms, ImageFormat.Jpeg);
                byte[] pic = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic, 0, pic.Length);
                bool rs = blc.ManageSolution(0,
                   Convert.ToDateTime(dtpdate.Text),
              Convert.ToInt32(cmbproject.SelectedValue.ToString()),
                       Convert.ToInt32(cmbbugid.SelectedValue.ToString()),
                    txtclass.Text,
                    txtblock.Text,
                    txtcode.Text,
                    txtmethod.Text,
                    txtclasslibrary.Text,
                  Convert.ToInt32(txtline.Text),
                    cmbsolvedby.Text,
                    txtsolutiondetail.Text,
                    pic,
                    1);
                if (rs == true)
                {
                    DialogResult dr = MessageBox.Show("Do you want to add solution information?", "Add the new solution",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        MessageBox.Show("Solution Successfully Added");
                    HelperClass.makefields(panel1);
                }
                else
                {
                    MessageBox.Show("Error in Adding Solution");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void solutionform_Load(object sender, EventArgs e)
        {
            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectId";
            cmbproject.SelectedIndex = -1;
            cmbbugid.DataSource = bc.GetAllBugs();
            cmbbugid.DisplayMember = "BugName";
            cmbbugid.ValueMember = "BugId";
            cmbbugid.SelectedIndex = -1;
            cmbsolvedby.DataSource = uc.GetAllUsers();
            cmbsolvedby.DisplayMember = "UserName";
            cmbsolvedby.ValueMember = "UserId";
            cmbsolvedby.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pberror.Image = new Bitmap(open.FileName);
            }
        }

    }
}
