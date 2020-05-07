using System;

namespace JaggedArray
{
    public delegate string InterestDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            

            DesmondLimited Detail1 = new DesmondLimited("Mike Desmond","2 Idiroko Ota","0804523897", 40000M, 0.2, 2);
            DesmondLimited Detail2 = new DesmondLimited("Bolu Shola","56 Obasanjo Street Lagos","0906543287", 20000M, 0.1, 3);

            string[][] Customers = new string[2][];
            Customers[0] = new string[] {Detail1.Name, Detail1.Address, Detail1.PhoneNumber};
            Customers[1] = new string[] {Detail2.Name, Detail2.Address, Detail2.PhoneNumber};

            InterestDelegate interestDelegate = Detail1.SimpleInterest;
            Console.WriteLine(interestDelegate());

            // Console.WriteLine(Detail1.SimpleInterest());
            // Console.WriteLine(Detail1.CompoundInterest());
        }
    }
}
