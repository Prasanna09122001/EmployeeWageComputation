using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeAttendence employeeattendence1 = new EmployeeAttendence();
            employeeattendence1.Attendence();
            employeeattendence1.CalculateEmpWage();
            employeeattendence1.toString();
            EmployeeAttendence employeeattendence2 = new EmployeeAttendence();
            employeeattendence2.Attendence();   
            employeeattendence2.CalculateEmpWage();
            employeeattendence2.toString();

        }
    }
}