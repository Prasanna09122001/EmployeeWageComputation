using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        EmployeeAttendence[] Array = new EmployeeAttendence[10];
        int companycount = 0;
        public void CompanyArray(string CompanyName, int WAGE_PER_HR, int TOTAL_WORKING_DAYS, int TOTAL_WORKING_HRS)
        {
            Array[companycount] = new EmployeeAttendence(CompanyName, WAGE_PER_HR, TOTAL_WORKING_DAYS, TOTAL_WORKING_HRS);
            companycount++;
        }
        public void CalculateWage()
        {
            for (int i = 0; i < companycount; i++)
            {
                EmployeeAttendence empwage = Array[i];
                empwage.CalculateEmpWage();
                empwage.Companywage();
            }
        }
    }
}
