using LuhnChallenge;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LuhnCheckEmpty lce = new LuhnCheckEmpty();
            Console.WriteLine("4929573765058314 == true? {0}", lce.IsValidCardNumber("4929573765058314"));
            Console.WriteLine("1 == false {0}", lce.IsValidCardNumber("1"));
            Console.WriteLine("7945648948166414 == false? {0}", lce.IsValidCardNumber("7945648948166414"));
            
        }
    }
}
