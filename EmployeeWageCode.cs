using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProblemWithuseObj
{
      public class EmployeeWageCode
        {
            public const int is_Full_Time = 1;
            public const int is_Part_Time = 2;
            public const int EmpRatePerHr = 20;
            public void CheckTime()
            {


                int empWage = 0;
                int empHrs = 0;
                Random random = new Random();
                int empCheck = random.Next(3);
                if (empCheck == is_Full_Time)
                {
                    empHrs = 8;
                }
                else if (empCheck == is_Part_Time)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EmpRatePerHr;
                Console.WriteLine("wages of employee is :" + empWage);
            }      
      }

}
