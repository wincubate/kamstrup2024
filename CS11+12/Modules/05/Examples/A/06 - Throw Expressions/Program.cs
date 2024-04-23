using static System.Console;
using Wincubate.Module05.Data.Employees;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

//repository.Add(null);

//repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

repository
    .GetAll()
    .ToList()
    .ForEach(WriteLine);
