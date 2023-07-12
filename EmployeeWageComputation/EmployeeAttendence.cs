using System;

namespace EmployeeWageComputation
{
    class EmployeeAttendence
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_DAY_HR=4, IS_FULL_TIME=0, IS_PART_TIME=1;
        
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
            int totalEmpWage = 0, empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
            }
            if(empCheck == IS_PART_TIME)
            {
                empHrs = PART_DAY_HR;
            }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine(totalEmpWage);
        }

    }
}
