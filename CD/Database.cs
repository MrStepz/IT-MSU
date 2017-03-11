using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CD
{
    class Database
    {
        public SqlConnection conn;
        public Database()
        {
            string Connection = "Server=PIZ\\SQLEXPRESS;Database=MyCD;Integrated Security=true";
            conn = new SqlConnection(Connection);
        }
        public SqlConnection getDatabase()
        {
            return conn;
        }


    }
}
