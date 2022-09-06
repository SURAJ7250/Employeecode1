using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart",20,2,10);//creating dmart object
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);//creating reliance object
            dmart.computeEmpWage();
            Console.WriteLine(dmart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
            
        }
    }
}