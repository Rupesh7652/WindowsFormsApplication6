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
        public bool ManageUsers(int UserId, string FullName, string Username, string Password, string Role, int Mode)
        {
            try
            {
                int result = uc.ManageUsers(UserId, FullName, Username, Password, Role, Mode);
                if (result > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool User(int v1, string text1, string text2, string text3, string text4, int v2)
        {
            throw new NotImplementedException();
        }
    }
  
    }

        

