using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CD
{
    class Query
    {
         public SqlConnection con;
         DataTable dt;

         public Query(SqlConnection con)
        {
            this.con = con;
        }
        public DataTable QueryList(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(rd);
            return dt;
        }
        public SqlDataReader QuerySingle(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public int Add(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public int Edit(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        public int Remove(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}
