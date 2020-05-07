using System;

namespace JaggedArray
{
    public delegate void InterestDelegate();
    class Program
    {
        static void Main(string[] args)
        {

            InterestDelegate interestDelegate = SimpleInterest;

            InterestDelegate interestDelegate1 = CompoundInterest;

            interestDelegate();
            interestDelegate1();

        }

        static object[][] cus = {
                new object[]{"Mike Desmond","2 Idiroko Ota","0804523897",40000M,0.2, 2},
                new object[]{"Bolu Shola", "56 Obasanjo Street Lagos", "0906543287",20000M, 0.1, 3}
            };


        static public void SimpleInterest()
        {
            DesmondLimited Detail1 = new DesmondLimited(cus[0][0].ToString(),cus[0][1].ToString(),cus[0][2].ToString(),(decimal)cus[0][3],
             (double)cus[0][4], (int)cus[0][5]);

            decimal rat = Convert.ToDecimal(Detail1.R);
            decimal tim = Convert.ToDecimal(Detail1.T);
            
            Console.WriteLine($"The simple interest for {Detail1.Name} is {Convert.ToDecimal((Detail1.P*tim*rat)/100):C}");
        }

        static public void CompoundInterest()
        {
            DesmondLimited Detail2 = new DesmondLimited(cus[1][0].ToString(),cus[1][1].ToString(),cus[1][2].ToString(),(decimal)cus[0][3],
             (double)cus[0][4], (int)cus[0][5]);

           decimal subTotal = 0;
           for (int i = 0; i <= Detail2.T; i++)
           {
               decimal compound = Detail2.P * (decimal)(Math.Pow((1+Detail2.R),i));
                subTotal += compound;
           }
            
            Console.WriteLine($"The compound interest for  {Detail2.Name} is {subTotal:C}");
        }
         
        
    }
}
