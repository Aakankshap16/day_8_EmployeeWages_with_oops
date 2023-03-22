
using static EmployeeWagesProblemWithuseObj.EmpWagesCode;
namespace EmployeeWagesProblemWithuseObj
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ParentComputeEmpWage> companies = new List<ParentComputeEmpWage>();
           
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("----------------------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("******************:MENU:******************");
                Console.WriteLine("PRESS 1: To Calculate the wage in a Company.");
                Console.WriteLine("PRESS 2: To EXIT.");
              
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the details:");
                    companies.Add(new CompanyEmpWage());
                    Console.WriteLine("_________________________________________________");
                    companies[companies.Count - 1].EmpWageBuilder();
                }
                else if (choice == 2)
                {
                    break;
                }
            }

        }
    }
}