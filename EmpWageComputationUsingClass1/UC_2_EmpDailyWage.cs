﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingClass1
{
    public class UC_2_EmpDailyWage
    {
        public static void EmpDailyWage()
        {
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}

