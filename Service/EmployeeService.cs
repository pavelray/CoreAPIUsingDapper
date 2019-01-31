using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repository = repo;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeByDateOfBirth(DateTime dateOfBirth)
        {
            try
            {
                return await _repository.GetEmployeeByDateOfBirth(dateOfBirth);
            }
            catch (Exception ex)
            {
                
            }
            return null;
        }

        public Task<Employee> GetEmployeeByID(string id)
        {
            try
            {
                return _repository.GetEmployeeByID(id);
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
