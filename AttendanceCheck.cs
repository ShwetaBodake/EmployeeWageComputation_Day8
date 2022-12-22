using System;
namespace EmployeeWageComputation_Day8
{
	public class AttendanceCheck
	{
		public  void  EmpAttendace()
		{
            Random random= new Random();
			int isPresent = random.Next(0, 2);

			Console.WriteLine(isPresent);
			if (isPresent == 1)
			{ Console.WriteLine("Employee is PRESENT"); }
			else
			{
				Console.WriteLine("Employee is Absent");
			}

		}
	}
}

