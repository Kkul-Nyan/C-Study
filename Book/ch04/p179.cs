﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p179
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("continue 키워드");
            for (int i = 1; i < 10; i++)
            {
                if(i %2 ==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
        
        
        
        }
    }
}
