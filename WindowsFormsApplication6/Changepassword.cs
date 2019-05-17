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
using System.Data.SqlClient;
namespace WindowsFormsApplication6
{

    public partial class Changepassword : Form
    {
        public Changepassword()
        {
            InitializeComponent();


        }
        BusinessLogicClass blc = new BusinessLogicClass();
        UserClass uc = new UserClass();

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }

        private void Changepassword_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnnect = new SqlConnection(Connectionclass.ConnectionString);
            try
            {
                string username = txtusername.Text;
                string password = txtold.Text;
                string newPassword = txtnew.Text;

                

                SqlCommand cmd = new SqlCommand("Update UsersTable set Password=@new where Username=@un AND Password=@old", cnnect);
                cmd.Parameters.AddWithValue("@new", newPassword);
                cmd.Parameters.AddWithValue("@un", username);
                cmd.Parameters.AddWithValue("@old", password);
                cnnect.Open();
                int r = cmd.ExecuteNonQuery() ;
                cnnect.Close();
                if (r>0)
                {
                    MessageBox.Show("Password Changed");
                }
                else
                {
                    MessageBox.Show("Password not Changed");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    } }



