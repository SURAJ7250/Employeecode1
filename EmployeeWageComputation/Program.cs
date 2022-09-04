using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeewage = new EmployeeWage();
            employeewage.calculateEmpWage("DMart", 30, 20, 100);
            employeewage.calculateEmpWage("Reliance", 20, 10, 200);
        }
    }
}