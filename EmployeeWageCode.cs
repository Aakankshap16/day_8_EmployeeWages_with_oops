using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProblemWithuseObj
{
    internal class EmployeeWageCode
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;
        public const int EmpRatePerHr = 20;
        public const int NumOfWorkingDays = 20;
        public const int MaxHrInMonth = 100;
        public int ComputeEmpWage()
        {


            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;


            while (totalEmpHours <= MaxHrInMonth && totalWorkingDays < NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {

                    case is_Full_Time:

                        {
                            empHrs = 8;
                            break;
                        }

                    case is_Part_Time:

                        {
                            empHrs = 4;
                            break;
                        }

                    default:

                        {
                            empHrs = 0;
                            break;
                        }


                }
                totalEmpHours += empHrs;

                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs + "Emp Wages:" + empWage);
                empWage = empHrs * EmpRatePerHr;
                totalEmpWage += empWage;

            }
            Console.WriteLine("wages of employee per month is " + totalEmpWage);
            return totalEmpWage;

        }
    }
}
