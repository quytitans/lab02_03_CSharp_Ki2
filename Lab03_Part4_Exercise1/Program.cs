using System;

namespace Lab03_Part4_Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("------------------------");
            Atom atom = new Atom();
            Console.WriteLine("Enter atomic number:");
            atom.AtomicNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol:");
            atom.AtomicSymbol = Console.ReadLine();
            Console.WriteLine("Enter full name :");
            atom.FullName = Console.ReadLine();
            Console.WriteLine("Enter atomic weight :");
            atom.AtomicWei = float.Parse(Console.ReadLine());
            atom.ToString();
            Console.ReadLine();
        }
    }
}