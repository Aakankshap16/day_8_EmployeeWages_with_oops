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
        public  void CheckCase()
        {


            int empWage = 0;
            int empHrs = 0;
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
            empWage = empHrs * EmpRatePerHr;
            Console.WriteLine("wages of employee is :" + empWage);
        }
    }
}
