namespace Lab03_Part4_Exercise2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Sin = sin;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Address: {2}, Sin: {3}, Salary: {4}", FirstName,
                LastName, Address, Sin, Salary);
        }
    }
}