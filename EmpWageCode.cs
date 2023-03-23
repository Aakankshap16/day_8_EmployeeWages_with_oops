namespace EmployeeWagesProblemWithuseObj
{
    using System;
    using System.Collections.Generic;
    public class EmpWagesCode
    {
        public interface ParentComputeEmpWage
        {
            void EmpWageBuilder();
            void PrintDailyWages();
        }

        public class CompanyEmpWage : ParentComputeEmpWage
        {
            List<int> DailyWages = new List<int>();
            public const int IsFullTime = 1;
            public const int IsPartTime = 2;

            public string CompanyName;
            public int EmpWagePerHour;
            public int WorkingDaysPerMonth;
            public int TotalWorkingHours;
            public int empHrs;
            public int totalWage;
            public int totalEmpWage;

            public CompanyEmpWage()
            {
                Console.Write("Enter the Company Name: ");
                CompanyName = Console.ReadLine();
                Console.Write("Enter the Employee Wage Per Hour: ");
                EmpWagePerHour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Total Working Days for an Employee in a Month: ");
                WorkingDaysPerMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Total Working Hours for an Employee in a Month: ");
                TotalWorkingHours = Convert.ToInt32(Console.ReadLine());
            }

            public void EmpWageBuilder()
            {
                int  empWagePerDay, empWagePerMonth = 0, totalWorkingDays = 0, totalEmpHours = 0 ;

                while (totalEmpHours <= TotalWorkingHours && totalWorkingDays < WorkingDaysPerMonth)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(3);
                    switch (empCheck)
                    {
                        case IsFullTime:
                            Console.WriteLine("Employee is Doing Full Time!");
                            empHrs = 8;
                            break;
                        case IsPartTime:
                            Console.WriteLine("Employee is Doing Part Time!");
                            empHrs = 4;
                            break;
                        default:
                            Console.WriteLine("Employee is Absent!");
                            empHrs = 0;
                            break;
                    }
                    totalEmpHours += empHrs;
                    empWagePerDay = empHrs * EmpWagePerHour;
                    empWagePerMonth += empWagePerDay;
                    Console.WriteLine("Employee Wage per Day: " + empWagePerDay);

                    DailyWages.Add(empWagePerDay);
                }
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("Employee Wage Per Month : " + empWagePerMonth);
                totalWage = empWagePerMonth * 12;
                Console.WriteLine("Total Wage of the Employee Per Year: " + totalWage);
                Console.WriteLine();
            }

            public void PrintDailyWages()
            {
                Console.WriteLine("Daily Wages:");
                for (int i = 0; i < DailyWages.Count; i++)
                {
                    Console.WriteLine("Day " + (i + 1) + ": " + DailyWages[i]);
                }
                Console.WriteLine("Total Wage: " + (EmpWagePerHour * empHrs * WorkingDaysPerMonth));
            }
        }
    }
}
