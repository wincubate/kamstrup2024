namespace Wincubate.CS10.Data.Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        //public void Deconstruct( out string firstName, out string lastName )
        //{
        //    firstName = FirstName;
        //    lastName = LastName;
        //}
    }
}
