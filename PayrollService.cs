using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    internal class PayrollService
    {
        public static SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog= PayrollService; integrated security= true");
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
        public static void CreateTable()
        {

            try
            {

                con.Open();
                string query = "create table EmployeePayroll(id int identity(1,1) primary key,name varchar(20),salary bigint,startdate date);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void InsertRecord()
        {
            PayrollModel model = new PayrollModel();
            Console.WriteLine("enter name");
            model.name = Console.ReadLine();
            Console.WriteLine("enter salary");
            model.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter startdate(yyyy-mm-dd)");
            model.start_date = Convert.ToDateTime(Console.ReadLine());
            con.Open();
            string query = "InsertData";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", model.name);
            cmd.Parameters.AddWithValue("@salary", model.salary);
            cmd.Parameters.AddWithValue("@start_date", model.start_date);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
