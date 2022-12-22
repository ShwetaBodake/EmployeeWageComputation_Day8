using System;
namespace EmployeeWageComputation_Day8
{
	public class DailyEmpWage_UC2
	{
		public void DailyWage()
		{
			int Wage_per_Hour = 20;
			int Full_Day_Hour = 8;
            Random random = new Random();
            int isPresent = random.Next(0, 2);

            //Console.WriteLine(isPresent);
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is PRESENT");
                int DailyWge = Wage_per_Hour * Full_Day_Hour;
                Console.WriteLine("Daily wage of employee is " + DailyWge);

              }
            else
            {
                Console.WriteLine("Employee is Absent");
            }


        }
    }
}

