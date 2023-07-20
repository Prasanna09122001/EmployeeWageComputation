using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeAttendence employeeattendence1 = new EmployeeAttendence("Apple",200,20,8);
            employeeattendence1.Attendence();
            employeeattendence1.CalculateEmpWage();
            employeeattendence1.Companywage();
            EmployeeAttendence employeeattendence2 = new EmployeeAttendence("Amazon",150,20,9);
            employeeattendence2.Attendence();   
            employeeattendence2.CalculateEmpWage();
            employeeattendence2.Companywage();

        }
    }
}