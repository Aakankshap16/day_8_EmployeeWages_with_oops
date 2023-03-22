
using static EmployeeWagesProblemWithuseObj.EmpWagesCode;

namespace EmployeeWagesProblemWithuseObj
{
    class Program
    {
        public static void Main(string[] args)
        {
            ParentComputeEmpWage[] Company = new ParentComputeEmpWage[5];

            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("----------------------------------------------------------------------");

            for (int i = 0; i < Company.Length; i++)
            {
                Console.WriteLine("******************:MENU:******************");
                Console.WriteLine("PRESS 1: To Calculate the wage in a Company.");
                Console.WriteLine("PRESS 2: To EXIT.");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the details:");
                    Company[i] = new CompanyEmpWage();
                    Console.WriteLine("_________________________________________________");
                    Company[i].EmpWageBuilder();
                }
                else
                {
                    i = Company.Length;
                }
            }

        }
    }
}