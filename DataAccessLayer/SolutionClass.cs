using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class SolutionClass
    {
        SqlConnection cnnect = new SqlConnection(Connectionclass.ConnectionString);
        public int ManageSolution(int SolutionId, DateTime Date, int ProjectId, int BugId, string Class, string Code, string Block, string Method, string ClassLibrary, int LineNumber, string Solvedby, string SolutionDetail, byte[] Error, int Mode)
        {
            try
            {
                SqlCommand cmm = new SqlCommand("SP_ManageSolution", cnnect);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@SolutionId", SolutionId);
                cmm.Parameters.AddWithValue("@Date", Date);
                cmm.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmm.Parameters.AddWithValue("@BugId", BugId);
                cmm.Parameters.AddWithValue("@Class", Class);
                cmm.Parameters.AddWithValue("@Code", Code);
                cmm.Parameters.AddWithValue("@Block", Block);
                cmm.Parameters.AddWithValue("@Method", Method);
                cmm.Parameters.AddWithValue("@ClassLibrary", ClassLibrary);
                cmm.Parameters.AddWithValue("@LineNumber", LineNumber);
                cmm.Parameters.AddWithValue("@Solvedby", Solvedby);
                cmm.Parameters.AddWithValue("@SolutionDetail", SolutionDetail);
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
        public DataTable GetAllSolutions()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand("select * from SolutionTable", cnnect);
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
        public DataTable GetSolutionByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("Select * from SolutionTable where ProjectId=@ProjectId", cnnect);
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
        public DataTable GetSolutionByBug(int BugId)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("Select * from SolutionTable where BugId=@BugId", cnnect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BugId", BugId);
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
        public DataTable GetSolutionByUser(int UserId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from SolutionTable where UserId=@UserId", cnnect);
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
    }
}