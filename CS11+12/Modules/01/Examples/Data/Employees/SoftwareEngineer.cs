namespace Wincubate.CS10.Data.Employees
{
    public enum SoftwareEngineerLevel
    {
        AssociateJunior,
        Senior,
        Lead,
        Chief
    }

    public class SoftwareEngineer : Employee
    {
        public SoftwareEngineerLevel? Level { get; set; }
        public int CodeLinesProduced { get; set; }
    }
}
