using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_System.Classes.Database
{
    public abstract class DbConfig
    {
        //name of database file, use .db3 or .sqlite3
        private string dbName = "localDatabase.db3";
        //determines the method in which the app will operate with the database
        //GATEWAY: Routes commands through the userGateway and uses plain sql.
        //OBJECT: Uses sqlite-pcl-net's object based approach.
        private string databaseMode = "GATEWAY";

        /// <summary>
        /// Return database name.
        /// </summary>
        /// <returns>
        /// {String} dbName
        /// </returns>
        public string GetDatabaseName()
        {
            return dbName;
        }

        public string GetDatabaseMode()
        {
            return databaseMode;
        }
    }
}
