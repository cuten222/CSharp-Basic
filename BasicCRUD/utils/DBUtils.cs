using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD.utils
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection() {
            string host = "localhost";
            int port = 3306;
            string database = "new_schema";
            string username = "root";
            string password = "123456";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
