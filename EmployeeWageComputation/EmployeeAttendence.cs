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
            int totalEmpWage = 0, empHrs = 0, TOTAL_WORKING_DAYS = 20;
            Random random = new Random();
            for (int i = 0; i < TOTAL_WORKING_DAYS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine(totalEmpWage);
        }

    }
}
