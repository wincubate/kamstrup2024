using System;
using System.Collections.Generic;
using Wincubate.CS10.Data.Employees;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee employee in all)
{
    string? description = Evaluate(employee);
    Console.WriteLine($"{employee.FullName} - {description}");
}

static string Evaluate(Employee employee) =>
    employee switch
    {
        SoftwareEngineer { Level: SoftwareEngineerLevel.Lead, FirstName: "Jesper" } => $"You suck..:!",
        SoftwareEngineer { Level: SoftwareEngineerLevel.Lead } => $"{employee.FullName} does great work",
        SoftwareArchitect { Level: SoftwareArchitectLevel.Chief } => $"You da boss, {employee.FullName}",
        _ => $"Well done making the company thrive... :-)"
    };

//static void HailTheKing(Employee employee)
//{
//    if (employee is SoftwareEngineer { Level: SoftwareEngineerLevel.Chief, FullName: "Uncle Bob" })
//    {
//        Console.WriteLine("All hail to the king");
//    }
//}
