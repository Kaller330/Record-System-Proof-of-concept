using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Record_System.Classes;

namespace Record_System.Gateways
{
    public class RoleGateway
    {

        public RoleGateway()
        {
            
        }

        public Boolean addRole(Role role)
        {

            return true;
        }

        public Boolean removeRole(string roleId)
        {
            return false;
        }

        public Boolean editRole(Role role)
        {
            return false;
        }

        public Role getRole(string roleId)
        {
            return new Role();
        }

    }
}
