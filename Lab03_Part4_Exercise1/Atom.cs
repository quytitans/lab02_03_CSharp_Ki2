using System;

namespace Lab03_Part4_Exercise1
{
    public class Atom
    {
        public int AtomicNumber { get; set; }
        public string AtomicSymbol { get; set; }
        public string FullName { get; set; }
        public float AtomicWei { get; set; }

        public Atom(int atomicNumber, string atomicSymbol, string fullName, float atomicWei)
        {
            AtomicNumber = atomicNumber;
            AtomicSymbol = atomicSymbol;
            FullName = fullName;
            AtomicWei = atomicWei;
        }

        public Atom()
        {
        }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}  {3}", AtomicNumber, AtomicSymbol, FullName, AtomicWei);
        }
    }
}