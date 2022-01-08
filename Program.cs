using System;

namespace Employee_Wage
{
    class Program
    {
          public static void Main(string[] args)
        {
            UC1_EmpCheck.CheckEmployee();
          UC2_DailyWage.CheckDailySalary();
          UC3_PartTimeEmpAndWage.CheckPartTimeEmpWage();
         UC4_PartTimeEmpWage_usingSwitch.CheckEmpWageUsingSwitch();
         UC5_CalculateEmpSalaryForMonth.CheckFor20DaysInMonth();
          UC6_SalaryForTotalWorkingHrs100_OrMonthsOf20.CheckUC6_SalaryForTotalWorkingHrs100_OrMonthsOf20();
        }
    }
}