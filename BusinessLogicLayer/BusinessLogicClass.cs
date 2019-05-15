using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        UserClass uc = new UserClass();
        ProjectClass pc = new ProjectClass();
        BugClass bc = new BugClass();
        SolutionClass sc = new SolutionClass();

        public bool ManageUsers(int UserId,
            string FullName,
            string Username,
            string Password,
            string Role,
            int Mode)
        {
            try
            {
                int result = uc.ManageUsers(UserId,
                    FullName,
                    Username,
                    Password,
                    Role,
                    Mode);
                if (result > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageProduct(int ProductId,
           string ProductName,
           DateTime StartDate,
           DateTime EndDate,
           string Description,
           int Mode)
        {
            try
            {
                int rs = pc.ManageProduct(ProductId,
                    ProductName,
                    StartDate,
                    EndDate,
                   Description,
                   Mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool ManageBug(int BudId,
            DateTime Date,
            int ProjectId,
            string Bug,
            string Class,
            string Code,
            string Method,
            string ClassLibrary,
            int LineNumber,
            string IdentifiedBy,
            byte[] Error,
            int Mode)
        {
            try
            {
                int rs = bc.ManageBug(BudId,
             Date,
             ProjectId,
             Bug,
             Class,
             Code,
            Method,
            ClassLibrary,
            LineNumber,
            IdentifiedBy,
            Error,
           Mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ManageSolution(int SolutionId,
           DateTime Date,
           int ProjectId,
           int BugId,
           string Class,
           string Code,
           string Method,
           string ClassLibrary,
           int LineNumber,
           string SolvedBy,
           byte[] Error,
           int Mode)
        {
            try
            {
                int rs = sc.ManageSolution(SolutionId,
             Date,
             ProjectId,
             BugId,
             Class,
             Code,
            Method,
            ClassLibrary,
            LineNumber,
            SolvedBy,
            Error,
           Mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

        

