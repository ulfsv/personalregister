using System.Collections.Generic;

namespace personalregister
{
    class Register
    {

        private List<Employee> _employees = new List<Employee>();

        internal void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        internal List<Employee> GetEmployees()
        {
            return new List<Employee>(_employees);
        }
    }
}
