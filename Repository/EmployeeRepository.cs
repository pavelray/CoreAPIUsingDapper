using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;

        public EmployeeRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployeeByDateOfBirth(DateTime dateOfBirth)
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE ID = @ID";
                conn.Open();
                var result = await conn.QueryAsync<Employee>(sQuery, param: new { DateOfBirth = dateOfBirth });
                return result;
            }
        }

        public async Task<Employee> GetEmployeeByID(string id)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE ID = @ID";
                    conn.Open();
                    var result = await conn.QueryAsync<Employee>(sQuery, new { ID = id });
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }
    }
}
