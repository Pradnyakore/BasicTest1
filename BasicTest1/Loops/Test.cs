﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest1.Loops
{
    //1)Write a program to print all numbers between 1 and 100 except the numbers which are divisible by 5or 10



    class Test
    {
        static void Main(string[] args)
        {
            int num = 100;
            int i;
            for (i = 1; i <= num; i++)
            {
                if (i % 5 != 0 && i % 10 != 0)
                {

                    Console.WriteLine(i);
                }

            }
        }

    }
}
