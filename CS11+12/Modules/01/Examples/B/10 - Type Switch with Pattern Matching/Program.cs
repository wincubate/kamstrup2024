using System.Collections.Generic;
using Wincubate.CS10.Data.Employees;
using static System.Console;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee e in all)
{
    switch (e)
    {
        case SoftwareArchitect sa:
            WriteLine($"{sa.FullName} plays with Visio");
            break;

        case SoftwareEngineer se:
            WriteLine($"{se.FullName} has a fun job coding all day");
            break;

        case null:
        default:
            break;
    }

    #region when

    //case SoftwareEngineer se when se.Level == SoftwareEngineerLevel.Lead:
    //    WriteLine($"{se.FullName} is a lead software engineer");
    //    break;

    #endregion
}
