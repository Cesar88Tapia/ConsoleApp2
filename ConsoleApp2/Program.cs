﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool flag = true;
            string chain = "1245784";
            DateTime date = DateTime.MinValue;
            i = Convert.ToInt32(chain);
            Console.WriteLine("The value of i is: {0}", i);
            Console.WriteLine("The value of x is: {0:C}", x);
            Console.WriteLine("The value of flag is: " + flag.ToString());
            Console.WriteLine("The value of chain: " + chain);
            Console.WriteLine("Teh value of date: " + date.ToShortDateString());
            Console.ReadKey();
        }
    }
}
