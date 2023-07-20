using System;

namespace EmployeeWageComputation
{
    class EmployeeAttendence
    {
        const int FULL_DAY_HR = 8, PART_DAY_HR=4, IS_FULL_TIME=0, IS_PART_TIME=1;
        int TOTAL_WORKING_DAYS, TOTAL_WORKING_HRS, WAGE_PER_HR, totalEmpWage;
        string CompanyName = "";
        Random random = new Random();
        public EmployeeAttendence(string CompanyName,int WAGE_PER_HR,int TOTAL_WORKING_DAYS,int TOTAL_WORKING_HRS)
        {
           this.CompanyName = CompanyName;
           this.WAGE_PER_HR = WAGE_PER_HR;
           this.TOTAL_WORKING_DAYS = TOTAL_WORKING_DAYS;
           this.TOTAL_WORKING_HRS = TOTAL_WORKING_HRS;
        }
        public void Attendence()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
                Console.WriteLine("Employee is Present");
            else Console.WriteLine("Employeee is Absent");
        }
        public void CalculateEmpWage( )
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            for (int i = 0; i < TOTAL_WORKING_DAYS && empHrs < TOTAL_WORKING_HRS; i++)
            {
                
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
        }
        public void Companywage()
        {
            Console.WriteLine(this.CompanyName+" wage is "+totalEmpWage);

        }

    }
}
