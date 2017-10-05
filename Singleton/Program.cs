using System;

namespace Singleton
{
     class Program
    {
        static void Main(string[] args)
        {
            //string insuredName = Policy.Instance.GetInsuredName();

            System.Threading.Tasks.Parallel.Invoke(
                () => PrintPolicy(),
                () => PrintPolicy()
                );

            System.Threading.Tasks.Parallel.Invoke(
                () => PrintStudentdetails(),
                () => PrintEmployeeDetails()
                );
        }

        private static void PrintPolicy()
        {
            string insuredName = Policy.Instance.GetInsuredName();
            Console.WriteLine(insuredName);
        }

        private static void PrintEmployeeDetails()
        {
            /* * Assuming Singleton is created from employee class * we refer to the GetInstance property from the Singleton class */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }
        private static void PrintStudentdetails()
        {
            /* * Assuming Singleton is created from student class * we refer to the GetInstance property from the Singleton class */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

    }
}
