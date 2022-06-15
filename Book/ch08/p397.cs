using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p397
    {
        class test<T, U>  //2개 이상의 제네릭을 사용하는 클래스
        where T : class  //T는 클래스로 제네틱을 제한
        where U : struct //U는 struct로 제네틱을 제한
        { 
        
        }

    }
}
