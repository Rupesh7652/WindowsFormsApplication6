using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BugClass
    {
        SqlConnection cnnect = new SqlConnection(Connectionclass.ConnectionString);
        public int ManageBug(int BugId, DateTime Date, int ProjectId, string Bug, string Class, string Code, string Method, string ClassLibrary, int LineNumber, string IdentifiedBy, byte[] Error, int Mode)
        {
            try
            {
                SqlCommand cmm = new SqlCommand("SP_ManageBug", cnnect);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@BugId", BugId);
                cmm.Parameters.AddWithValue("@Date", Date);
                cmm.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmm.Parameters.AddWithValue("@Bug", Bug);
                cmm.Parameters.AddWithValue("@Class", Class);
                cmm.Parameters.AddWithValue("@Code", Code);
                cmm.Parameters.AddWithValue("@Method", Method);
                cmm.Parameters.AddWithValue("@ClassLibrary", ClassLibrary);
                cmm.Parameters.AddWithValue("@LineNumber", LineNumber);
                cmm.Parameters.AddWithValue("@IdentifiedBy", IdentifiedBy);
                cmm.Parameters.AddWithValue("@Error", Error);
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
        public DataTable GetAllBugs()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand("select * from BugTable", cnnect);
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
            finally
            {
                cnnect.Close();
            }
        }
        public DataTable GetBugByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
          
                SqlCommand cmd = new SqlCommand("Select * from BugTable where ProjectId=@ProjectId", cnnect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
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
        public DataTable GetBugByUser(int UserId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugTable where UserId=@UserId", cnnect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserId", UserId);
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
        public DataTable GetAllBugsbyid( int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand("select * from BugTable where BugId =@id", cnnect);
                cmm.CommandType = CommandType.Text;
                cmm.Parameters.AddWithValue("@id", id);
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
            finally
            {
                cnnect.Close();
            }
        }
    }
}
