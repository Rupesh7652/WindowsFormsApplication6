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
    public partial class ViewSolution : Form
    {
        SolutionClass sc = new SolutionClass();
        public ViewSolution()
        {
            InitializeComponent();
            dgvsolutions.DataSource = sc.GetAllSolutions();
        }

      
        private void ViewSolution_Load(object sender, EventArgs e)
        {

        }
    }
}
