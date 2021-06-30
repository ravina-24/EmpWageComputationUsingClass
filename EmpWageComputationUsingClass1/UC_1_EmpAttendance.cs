using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingClass1
{
   public class UC_1_EmpAttendance
    {


      public  static void AttendaceCheck() 
        {
            //constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)

            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }   
    }
}
