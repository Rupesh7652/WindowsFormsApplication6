using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class ProjectClass
    {
        SqlConnection cnnect = new SqlConnection(Connectionclass.ConnectionString);

        public int ManageProduct(int ProjectId,
            string ProjectName,
            DateTime StartDate,
            DateTime EndDate,
           string Description,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageProject", cnnect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                cnnect.Open();
                int result = cmd.ExecuteNonQuery();
                cnnect.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnnect.Close();
            }

        }
        public DataTable GetAllProducts()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from ProjectTable", cnnect);
                cnnect.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                cnnect.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnnect.Close();

            }
        }
    }
}
