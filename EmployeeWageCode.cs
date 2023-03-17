using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProblemWithuseObj
{
    public class CheckEmployeeFullTime
    {
      
            public const int is_Full_Time = 1;
            public const int EmpRatePerHr = 20;
            public  void EmployeeAttendence()
            {


                int empWage = 0;
                int empHrs = 0;
                Random random = new Random();
                int empCheck = random.Next(2);
                if (empCheck == is_Full_Time)
                {
                    empHrs = 8;
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

