﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p165
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("do while 반복문 활용");

            string input;
            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
