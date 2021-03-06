﻿/* Ivan Boychuk
 * Chapter 4 - Flow Control
 * Using do Loops */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble (ReadLine()) / 100.0;
            WriteLine("What balace would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;
            do //executes code at least once
            {
                balance += interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            WriteLine($"In {totalYears} years {(totalYears == 1 ? "" : "s")}"  +
                $"you will have a balance of {targetBalance}");
            ReadKey();
        }
    }
}
