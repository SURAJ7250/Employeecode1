using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage workingdays = new EmployeeWage();
            workingdays.computeEmpWage("Dmart", 20, 2, 10);
            workingdays.computeEmpWage("Jio", 30, 4, 20);
        }
    }
}