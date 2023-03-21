using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProblemWithuseObj
{
    internal class EmpWageBuilderObject
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;
        public static int EmpRatePerHr;
        public static int NumOfWorkingDays;
        public static int MaxHrInMonth;


        public void EmpWageBuilder1()
        {
            EmpRatePerHr = 300;
            NumOfWorkingDays = 20;
            MaxHrInMonth = 100;
           Console.WriteLine("Total Company Wage: " + (EmpRatePerHr * MaxHrInMonth));
        }

        public void EmpWageBuilder2()
        {
            EmpRatePerHr = 500;
            NumOfWorkingDays = 23;
            MaxHrInMonth = 120;
            Console.WriteLine("Total Company Wage: " + (EmpRatePerHr * MaxHrInMonth));
        }

        public void ComputeEmpWage()
        {


            int empWage = 0;
            int empHrs = 0;
            int totalEmpWagePerDay = 0;
            int totalEmpWageForMonth = 0;
            int totalEmpWageForYear= 0;
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
                totalEmpWagePerDay = empHrs * EmpRatePerHr;
                Console.WriteLine("Total Emp Wage for company per day :" + totalEmpWagePerDay);
                totalEmpWageForMonth += totalEmpWagePerDay;
            }
            Console.WriteLine("Total Emp Wage for company per month :" + totalEmpWageForMonth);
            totalEmpWageForYear= totalEmpWageForMonth * 12;
            Console.WriteLine("Total Emp Wage for company per year :" + totalEmpWageForYear);

        }

      
    }
}
