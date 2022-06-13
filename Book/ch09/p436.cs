using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    interface IBasis
    {

    }
    class Testclass : IBasis
    {
        public int TestInstanceMethod()
        {
            throw new NotImplementedException();
        }

        public int TestProperty
        {
            get 
            {
                throw new NotImplementedException(); 
            }
            set 
            {
                throw new NotImplementedException(); 
            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("인터페이스 생성");  
        }
    }
}
