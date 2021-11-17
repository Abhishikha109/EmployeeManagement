using System.Collections.Generic;

namespace employeeManagementSystem.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable <Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}