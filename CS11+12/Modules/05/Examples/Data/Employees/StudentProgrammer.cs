﻿namespace Wincubate.Module05.Data.Employees;

public record StudentProgrammer(
    string FirstName,
    string LastName,
    Employee MentoredBy
) : Employee(FirstName,LastName)
{
    public override string ToString() =>
        base.ToString() + ($" / Mentor: {MentoredBy}");
}
