using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"tran-vmware\SQLEXPRESS";

            string database = "simplehr";
            string username = "sa";
            string password = "1234";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
