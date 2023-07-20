using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage Wage = new EmployeeWage();
            Wage.CompanyArray("Apple", 200, 20, 8);
            Wage.CompanyArray("Amazon", 250, 22, 9);
            Wage.CompanyArray("FlipKart", 230, 20, 9);
            Wage.CalculateWage();
           

        }
    }
}