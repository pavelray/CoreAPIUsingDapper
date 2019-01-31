using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeByID(string id);
        Task<IEnumerable<Employee>> GetEmployeeByDateOfBirth(DateTime dateOfBirth);
    }
}
