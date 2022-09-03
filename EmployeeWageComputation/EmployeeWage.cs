﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 4, WORKING_DAYS = 20;
        public static int computeEmpWage( String company,int empRatePerHour,int numberOfWorkingDays,int maxHourPerMonth)
        int totalEmpWage = 0, empHrs = 0,totalWorkingDays=0,totalEmpHrs=0,empRatePerHour=0;//variables
        public void Attendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void CalculateEmpWage(string v, int v1)
        {
            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS && empHrs < 100; i++)
            {
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
            }

            int totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine(totalEmpWage);
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine(" totalEmpWage for the company : " + company + "is: " + totalEmpWage);
        }
    }
}