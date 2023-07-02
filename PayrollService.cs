using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    internal class PayrollService
    {
        public static SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog= master; integrated security= true");
        public static void CreateDatabase()
        {

            try
            {

                con.Open();
                string query = "create database PayrollService;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("database created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
