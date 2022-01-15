using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class UC2EmployeeWage
    {
        public static void Display() // creting method for a class
        {
            int isFullTime = 1;
            int empHrs = 0;
            int empRatePerHr = 20;
            int employeeWage = 0;
        Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)   //If random value 1 then it will execute the block statemnt
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            // Employee wage calculation
            employeeWage = empHrs * empRatePerHr;
            Console .WriteLine("Employee Wage:"+employeeWage );
        }
    }
}
