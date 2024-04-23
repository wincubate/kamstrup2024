namespace Wincubate.Module05.Data.Employees;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll();
    void Add(Employee employee);
}
