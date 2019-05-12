using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataAccessLayer
{
  public  class Connectionclass
    {
        public static string ConnectionString
        {
            get {
                return "Data Source=(local);Initial Catalog=bugtrackingsystem;Integrated Security=True";
            }
        }
    }
}
