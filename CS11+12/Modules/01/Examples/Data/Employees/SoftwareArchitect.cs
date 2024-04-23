namespace Wincubate.CS10.Data.Employees
{
    public enum SoftwareArchitectLevel
    {
        Senior,
        Lead,
        Chief
    }

    public class SoftwareArchitect : Employee
    {
        public SoftwareArchitectLevel? Level { get; set; }
        public int VisioDrawingsProduced { get; set; }
    }
}
