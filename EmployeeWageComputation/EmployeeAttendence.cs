using System;

namespace EmployeeWageComputation
{
    class EmployeeAttendence
    {
        public static void Attendence() 
        {
            Random random = new Random();
            int empcheck = random.Next(0,2);
            if (empcheck == 0)
                Console.WriteLine("Employee is Present");
            else Console.WriteLine("Employeee is Absent");
        }
    }
}
