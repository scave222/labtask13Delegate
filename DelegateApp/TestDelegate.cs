using System;
namespace DelegateApp
{
    public class TestDelegate
    {
        public string Space(string str)
        {   
                foreach (char item in str)
                {
                    Console.Write(item + " ");
                }
                  return "";
          
        }

       public string Reverse(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
    }
}