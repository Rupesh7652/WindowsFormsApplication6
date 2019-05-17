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
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        UserClass uc = new UserClass();
        ProjectClass pc = new ProjectClass();
        BugClass bc = new BugClass();
        Viewbug vb = new Viewbug();
        public int BugId;
        public int ProjectId;
        public int UserId;
        private void button1_Click(object sender, EventArgs e)
        {
            if (BlankFieldValidation() == false)
            {
                CreateBug();
            }
        }

        private void CreateBug()
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pberror.Image.Save(ms, ImageFormat.Jpeg);
                byte[] pic = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic, 0, pic.Length);
                bool rs = blc.ManageBug(0,
                   Convert.ToDateTime(dtpdate.Text),
              Convert.ToInt32(cmbproject.SelectedValue.ToString()),
                    txtbug.Text,
                    txtclass.Text,
                    txtmethod.Text,
                    txtcode.Text,
                    txtclasslibrary.Text,
                  Convert.ToInt32(txtline.Text),
                    cmbidentifiedby.Text,

                    pic,
                    1);
                if (rs == true)
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add bug information?", "Add the new Bug",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                            MessageBox.Show("Bug Successfully Added");
                    HelperClass.makefields(panel1);
                    }
                else
                {
                    MessageBox.Show("Error in Adding Bug");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void BugForm_Load(object sender, EventArgs e)
        {
            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectId";
            cmbproject.SelectedIndex = -1;
            cmbidentifiedby.DataSource = uc.GetAllUsers();
            cmbidentifiedby.DisplayMember = "UserName";
            cmbidentifiedby.ValueMember = "UserId";
            cmbidentifiedby.SelectedIndex = -1;
          
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool BlankFieldValidation()
        {
            bool res = false;
            if (cmbproject.SelectedIndex == -1)
            {
                MessageBox.Show("Please Provide ProjectId");
                cmbproject.Focus();
                res = true;
            }
            else if (txtbug.Text == "")
            {
                MessageBox.Show("Please Provide BugName");
                txtbug.Focus();
                res = true;

            }
            else if (txtclass.Text == "")
            {
                MessageBox.Show("Please Provide Class");
                txtclass.Focus();
                res = true;
            }
           else if (txtmethod.Text == "")
            {
                MessageBox.Show("Please Provide Method");
                txtmethod.Focus();
                res = true;
            }
         else   if (txtclasslibrary.Text == "")
            {
                MessageBox.Show("Please Provide ClassLibrary");
                txtclasslibrary.Focus();
                res = true;
            }
          else  if (txtcode.Text == "")
            {
                MessageBox.Show("Please Provide Code");
                txtcode.Focus();
                res = true;
            }
         else   if (cmbidentifiedby.SelectedIndex == -1)
            {
                MessageBox.Show("Please Provide IdentifiedBy");
                cmbidentifiedby.Focus();
                res = true;
            }
            else if (cmbidentifiedby.SelectedIndex == -1)
            {
                MessageBox.Show("Please Provide IdentifiedBy");
                cmbidentifiedby.Focus();
                res = true;
            }
            return res;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Brown;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkCyan;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Brown;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkCyan;
        }
    }
}