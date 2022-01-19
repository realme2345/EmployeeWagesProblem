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
             // UC2EmployeeWage.Display();
            //UC3EmployeeWage.DisplayWage();
            //UC4EmployeeWage.DisplayCase();
            // UC5EmployeeWage.DisplayWagePerDays();
           // UC6EmployeeWage.DisplayWagePerHours();
            //UC7EmployeeWage.DisplayUC7();
            //UC8EmployeeWages.DisplayUC8("Dmart", 16, 20, 80);
            //UC8EmployeeWages.DisplayUC8("relieance", 18, 20, 100);
            UC9EmployeeWagescs Dmart = new UC9EmployeeWagescs("Dmart", 26, 27, 100);
            UC9EmployeeWagescs TATA = new UC9EmployeeWagescs("TATA", 22, 25, 70);
            Dmart.DisplayUC9();
            Console.WriteLine(Dmart.toString());
            TATA.DisplayUC9 ();
             Console.WriteLine(TATA.toString());
        }


    }
}
