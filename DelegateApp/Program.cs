using System;

namespace DelegateApp
{
    public delegate string  strMyDel (string a);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();
            strMyDel del= testDelegate.Space;
            del += testDelegate.Reverse;

            Methodgroupconversion();

             void Methodgroupconversion()
            {
                Console.Write(del("James"));
            }
        }
    }
}
