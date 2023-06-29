using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProgram
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation Program");

            Console.WriteLine("Use_Case-8 for Calculating Employee Wages for Multiple Companies");

            EmpWage_UseCases employeeWage_UseCases = new EmpWage_UseCases();

            employeeWage_UseCases.Employee_Attendance("Suzuki", 1100, 30, 240);

            employeeWage_UseCases.Employee_Attendance("Tata", 1500, 31, 230);

            employeeWage_UseCases.Employee_Attendance("Hyundai", 1105, 29, 215);

            employeeWage_UseCases.Employee_Attendance("Mahindra", 1035, 28, 235);

            Console.ReadLine();
        }
    }
}
    

