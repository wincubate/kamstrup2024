using System;
using System.Collections.Generic;
using Wincubate.CS10.Data.Employees;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee employee in all)
{
    Console.WriteLine(Choose(employee) ?? "No information");
}
static string Choose(Employee employee)
{
    switch (employee)
    {
        case SoftwareArchitect sa:
            return $"{sa.FullName} plays with Visio";

        case SoftwareEngineer se when se.Level == SoftwareEngineerLevel.Lead:
            return $"{se.FullName} is a lead software engineer";

        case SoftwareEngineer se:
            return $"{se.FullName} has a fun job coding all day";

        case StudentProgrammer sp:
            return $"Please get coffee and donuts, {sp.FirstName}";
        case null:
        default:
            return "Have a nice day... :-)";
    }
}