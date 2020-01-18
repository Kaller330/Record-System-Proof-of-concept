using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_System.Gateways
{
    public class Gateway
    {
        private string connectionString;


        public SqlConnection GetConnection()
        {
            try
            {
               
                return new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Library.ErrorHandler(e);
                return null;
            }
        }
    }
}
