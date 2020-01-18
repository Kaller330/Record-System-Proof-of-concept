using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Record_System.Classes;
using Record_System.Gateways;

namespace Record_System.Managers
{
    public class RoleManager
    {
        RoleGateway gateway = new RoleGateway();
        public RoleManager()
        {

        }

        public Boolean addRole(Role role)
        {
            return gateway.addRole(role);
        }
    }
}
