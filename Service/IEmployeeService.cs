using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeByID(string id);
        Task<IEnumerable<Employee>> GetEmployeeByDateOfBirth(DateTime dateOfBirth);
    }
}
