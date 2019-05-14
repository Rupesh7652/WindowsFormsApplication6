using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageusers ms = new Manageusers();
            ms.MdiParent = this;
            ms.Dock = DockStyle.Left;
            ms.Show();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project pr = new Project();
            pr.MdiParent = this;
            pr.Dock = DockStyle.Left;
            pr.Show();
        }

        private void addBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugForm ab = new BugForm();
            ab.MdiParent = this;
            ab.Dock = DockStyle.Left;
            ab.Show();
        }

        private void searchBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchform sf = new searchform();
            sf.MdiParent = this;
            sf.Dock = DockStyle.Left;
            sf.Show();
        }

        private void viewBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewbug vb = new Viewbug();
            vb.MdiParent = this;
            vb.Dock = DockStyle.Left;
            vb.Show();
        }

        private void solutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solutionform sm = new solutionform();
            sm.MdiParent = this;
            sm.Dock = DockStyle.Left;
            sm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            this.label2.Text = datetime.ToString();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
