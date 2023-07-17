using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeAttendence.Attendence();
            EmployeeAttendence employeeattendence1 = new EmployeeAttendence();
            employeeattendence1.CalculateEmpWage( "Amazon",200,20,8);
            EmployeeAttendence employeeattendence2 = new EmployeeAttendence();
            employeeattendence2.CalculateEmpWage("Flipkart",300,20,8);
        }
    }
}