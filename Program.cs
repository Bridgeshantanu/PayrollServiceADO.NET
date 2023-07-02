using System.Data.SqlClient;

namespace PayrollServiceADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PayrollService.RetrieveSalaryData("ram");
        }

    }
}

