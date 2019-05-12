using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class UserClass
    {
        SqlConnection cnnect = new SqlConnection(Connectionclass.ConnectionString);
        public int ManageUsers(int UserId, string FullName, string Username, string Password, string Role, int Mode)
        {
            try
            {
                SqlCommand cmm = new SqlCommand("SP_ManageUser", cnnect);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@UserId", UserId);
                cmm.Parameters.AddWithValue("@FullName", FullName);
                cmm.Parameters.AddWithValue("@Username", Username);
                cmm.Parameters.AddWithValue("@Password", Password);
                cmm.Parameters.AddWithValue("@Role", Role);
                cmm.Parameters.AddWithValue("@Mode", Mode);
                cnnect.Open();
                int Result = cmm.ExecuteNonQuery();
                cnnect.Close();
                return Result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { cnnect.Close(); }
        }
        public DataTable GetAllUsers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand("select * from UsersTable", cnnect);
                cnnect.Open();
                SqlDataReader dr = cmm.ExecuteReader();
                dt.Load(dr);
                cnnect.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cnnect.Close(); }
        }

        public string RoleBasedLogin(String FullName, String Username, String Password)
        {
            try
            {
                DataTable dt = new DataTable();
                string Role = "";
                SqlCommand cmm = new SqlCommand("Select Role from UserTable where FullName=@FullName, Username=@Username and Password=@Password", cnnect);
                cmm.CommandType = CommandType.Text;
                cmm.Parameters.AddWithValue("@FullName", FullName);
                cmm.Parameters.AddWithValue("@Username", Username);
                cmm.Parameters.AddWithValue("@Password", Password);
                cnnect.Open();
                SqlDataReader dr = cmm.ExecuteReader();
                dt.Load(dr);
                cnnect.Close();
                Role = dt.Rows[0]["Role"].ToString();
                return Role;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { cnnect.Close(); }
        }
    }
}
