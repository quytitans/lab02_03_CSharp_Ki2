using System;

namespace Lab03_Part4_Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Nguyen", "Quy", "136 Ho Tung Mau", 12312312312, 1000);
            calculateTheBonus(0.6,employee1);
        }

        private static void calculateTheBonus(double percent, Employee employee)
        {
            var bonus = employee.Salary * percent;
                Console.WriteLine($"Bonus Salary is: {bonus}");
                Console.ReadLine();
        }
    }
}