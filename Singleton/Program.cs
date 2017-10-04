using System;

namespace Singleton
{
     class Program
    {
        static void Main(string[] args)
        {
            string insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
