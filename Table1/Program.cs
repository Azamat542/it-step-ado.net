using Crypt.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Table1
{
    class Program
    {
        public static Client[] ReadAllEmployeesFromCompanies(params string[] companyBins)
        {
            var employees = new List<Client>();

            string connectionString =
                "Server=10.8.0.1;" +
                "Database=IDocsDb;" +
                "User Id=iDocsDeveloper;" +
                "Password=dev_iDocsDevStream2019!;";

            using var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            var companyBinsFormatted = new List<string>();
            foreach (var item in companyBins)
                companyBinsFormatted.Add($"'{item}'");


            var companyBinsStr = string.Join(" , ", companyBinsFormatted);

            var query = "SELECT Id as id, FirstName as first_name, LastName as last_name, " +
                "IIN as iin, PositionName as position_name from [Employees] where " +
                $"CompanyId in (SELECT Id FROM [Companies] WHERE BIN in ({companyBinsStr}))";

            var readAllEmployeesCommand = new SqlCommand(query, sqlConnection);

            var cursor = readAllEmployeesCommand.ExecuteReader();

            while (cursor.Read())
            {
                var id = cursor.GetGuid(0).ToString();
                var firstName = cursor.GetString(1);
                var lastName = cursor.GetString(2);
                var iin = cursor.GetString(3);
                var position = cursor.GetString(4);

                var employee = new Client(id, firstName, lastName, iin, position);
                employees.Add(employee);
            }

            return employees.ToArray();
        }

        public static Client[] ReadAllEmployees()
        {
            var employees = new List<Client>();

            string connectionString =
                "Server=10.8.0.1;" +
                "Database=IDocsDb;" +
                "User Id=iDocsDeveloper;" +
                "Password=dev_iDocsDevStream2019!;";

            using var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            // SELECT + any modification - SELECT + innert SELECT, SELECT + JOIN, SELECT + GROUP BY
            var readAllEmployeesQuery = "SELECT " +
                "Id as id, FirstName as first_name, LastName as last_name, IIN as iin, " +
                "PositionName as position_name " +
                "FROM [Employees]";

            var readAllEmployeesCommand = new SqlCommand(
                readAllEmployeesQuery,
                sqlConnection);

            var cursor = readAllEmployeesCommand.ExecuteReader();

            while (cursor.Read())
            {
                var id = cursor.GetGuid(0).ToString();
                var firstName = cursor.GetString(1);
                var lastName = cursor.GetString(2);
                var iin = cursor.GetString(3);
                var position = cursor.GetString(4);

                var employee = new Client(id, firstName, lastName, iin, position);
                employees.Add(employee);
            }

            return employees.ToArray();
        }
        static void Main(string[] args)
        {
            string connectionString =
                 "Server=(localdb)\\MSSQLLocalDB;" +
                 "Database=Crypt;" +
                 "Trusted_Connection=True";

        }
    }
}
