using System;
namespace JaggedArray
{
    public class DesmondLimited
    {
        public string Name{get;set;}
        public string Address{get; set;}
        public string PhoneNumber{get; set;}
        private decimal p;
        private double r;
        private int t;

        public DesmondLimited (string name,string address,string phoneNumber, decimal pp, double rr, int tt )
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            P = pp;
            R = rr;
            T = tt;
        }

        public decimal P{
            get{return p;}
            set{
                if( value > 0){
                    p = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Principal is out of range.");
                }
            }
        }

        public double R{
            get{return r;}
            set{
                if( value > 0 && value <= 100){
                    r = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Rate is out of range.");
                }
            }
        }

        public int T{
            get{return t;}
            set{
                if( value > 0){
                    t = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Time is out of range.");
                }
            }
        }

        // public string SimpleInterest()
        // {
        //     decimal rat = Convert.ToDecimal(R);
        //     decimal tim = Convert.ToDecimal(T);
        //     return $"is {Convert.ToDecimal((P*tim*rat)/100):C}";
        // }

        // public string CompoundInterest()
        // {
        //    decimal subTotal = 0;
        //    for (int i = 0; i <= T; i++)
        //    {
        //        decimal compound = P * (decimal)(Math.Pow((1+R),i));
        //         subTotal += compound;
        //    }
            
        //     return $"is {subTotal:C}";
        // }
        
    }
}