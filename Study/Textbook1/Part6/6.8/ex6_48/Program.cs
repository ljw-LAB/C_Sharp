using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
// 참조에서 추가 들어가서 System.Configuration 추가 할 것

namespace ex6_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;

                // DB에 연결하고,
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "SELECT * FROM MemberInfo";

                SqlDataReader reader = cmd.ExecuteReader();

                // …… [reader를 이용해 레코드를 하나씩 조회] ……
            }
        }
    }

}
