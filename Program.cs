//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Day8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");

            //AttendanceCheck x = new AttendanceCheck();
            //x.EmpAttendace();

            //DailyEmpWage_UC2 dailyWage = new DailyEmpWage_UC2();
            //dailyWage.DailyWage();

            //PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
            //partTimeEmpWage.CheckPartTimeEmp_Wage();

           // UsingSwitchCase UsingSwitchCase = new UsingSwitchCase();
            //UsingSwitchCase.CalculateEmpWage();

            //WagesForMonth_UC5 WagesForMonth = new WagesForMonth_UC5();
            //WagesForMonth.WagesForMonth();

           Wages_Till_WorkingDay_Hour  WagesTillWorkingDayHour = new Wages_Till_WorkingDay_Hour();
           WagesTillWorkingDayHour.WagesTillWorkingDayHour();

            //RefactorEmpWageComputation RefactorEmpWageComputation = new RefactorEmpWageComputation();
            //RefactorEmpWageComputation.RefactorEmpWage();
        }
    }
}