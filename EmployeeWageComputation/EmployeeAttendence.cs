using System;

namespace EmployeeWageComputation
{
    class EmployeeAttendence
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        public static void Attendence() 
        {
            Random random = new Random();
            int empcheck = random.Next(0,2);
            if (empcheck == 0)
                Console.WriteLine("Employee is Present");
            else Console.WriteLine("Employeee is Absent");
        }
        public static void CalculateEmpWage()
        {
            int dailyEmpwage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(dailyEmpwage);
        }

    }
}
