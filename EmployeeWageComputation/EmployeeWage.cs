using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 4, WORKING_DAYS = 20;// global variables
        private string company;
        private int empRatePerHour;
        private int maxHourPerMonth;
        private int numberOfWorkingDays;
        private int totalEmpWage;
        private string totalempWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numberOfWorkingDays, int maxHourPerMonth)//parameterised constructor
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;

        }
        public void computeEmpWage()
        { 
            int empHrs = 0, totalWorkingDays = 0, totalEmpHrs = 0;// local variables
        while(totalEmpHrs <= this.maxHourPerMonth && totalWorkingDays < this.numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_TIME_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + "EmpHrs: " + empHrs);
            }
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
                Console.WriteLine(" totalEmpWage for the company : " + company + "is: " + totalEmpWage);
       }
        public string toString()
            {
                return "Total Emp Wage of Company: " + this.company + "is: " + this.totalempWage;
            }
    }
}