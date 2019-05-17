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
    public partial class searchform : Form
    {
        ProjectClass pc = new ProjectClass();
        BugClass bc = new BugClass();
        SolutionClass sc = new SolutionClass();
        public searchform()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = pc.GetAllProjectsbyid(Int32.Parse(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = bc.GetAllBugsbyid(Int32.Parse(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = sc.GetAllSolutionsbyid(Int32.Parse(textBox4.Text));
        }

        private void searchform_Load(object sender, EventArgs e)
        {

        }
    }

}

