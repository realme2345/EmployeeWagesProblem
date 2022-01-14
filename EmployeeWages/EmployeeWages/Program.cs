using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random  random = new Random();
            int empCheck = random.Next(0, 2);
            if( empCheck == isPresent)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            // EmployeeWage.Display();
            //AddPartTimeWage.DisplayWage();
            //CaseStatement.DisplayCase();
            // EmployeeWagePerDays.DisplayWagePerDays();
            EmployeeWagesPerHours.DisplayWagePerHours();
        }


    }
}
