using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Policy Policy = new Policy();
            string insuredName = Policy.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
