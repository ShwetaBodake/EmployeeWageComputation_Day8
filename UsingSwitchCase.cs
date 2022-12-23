using System;
namespace EmployeeWageComputation_Day8
{
	public class UsingSwitchCase
	{
		public void CalculateEmpWage()
		{
			  int Is_Part_Time = 1;
         int Is_Full_Time = 2;
         int Emp_Rate_per_Hour = 20;

		int empHours = 0;
		int empWage = 0;
        Random random1= new Random();
        int CheckEmp = random1.Next(0, 3);

			switch (CheckEmp)
			{
			case 1:
                //case 1:
                    empHours = 4;
					break;
			//	case Is_Full_Time:
                case 2:
                    empHours = 8;
					break;
				default:
					empHours = 0;
					break;
			}
			empWage = empHours * Emp_Rate_per_Hour;

			Console.WriteLine("Emp Wage:- " + empWage);


    }
	}
}

