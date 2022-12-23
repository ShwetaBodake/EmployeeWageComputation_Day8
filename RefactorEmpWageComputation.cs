using System;
namespace EmployeeWageComputation_Day8
{
	public class RefactorEmpWageComputation
	{
		public const int Is_Part_Time=2;
		public const int Is_Full_Time=1;
	    public const int Emp_Wage_Per_Hour=20;
        public const int Working_Days_In_Month=20;
        public const int Max_Hours_In_Month=100;

		public void RefactorEmpWage()
		{
			int empHour = 0;
			int totalEmpHours = 0;
			int totalWorkingDays = 0;

			while (totalEmpHours <= Max_Hours_In_Month && totalWorkingDays < Working_Days_In_Month)
			{
				totalWorkingDays++;

				Random random = new Random();
				int checkEmp = random.Next(0, 3);

				switch(checkEmp)
				{
					case Is_Full_Time:
						empHour = 8;
						break;
					case Is_Part_Time:
						empHour = 4;
						break;
					default:
						empHour = 0;
						break;
				}
				totalEmpHours += empHour;
				Console.WriteLine("Day:-" + totalWorkingDays + "Emp Hours:- " + empHour);

			}
			int totalEmpWage = totalEmpHours * Emp_Wage_Per_Hour;
			Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
	}
}

