using System.Collections.Generic;
using Wincubate.CS10.Data.Employees;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee e in all)
{
    //For software engineers:
    //
    //WriteLine($"{se.FullName} has produced {se.CodeLinesProduced} lines of C#");
}
