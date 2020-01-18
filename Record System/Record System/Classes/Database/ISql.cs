using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Record_System.Classes.Database
{
    public interface ISql
    {
        SQLiteConnection GetConnection();
    }
}
