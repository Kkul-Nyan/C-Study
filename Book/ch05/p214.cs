using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p214
    {
        static void Main(string[] args)
        {
            Console.WriteLine("리스트 요소 추가");
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count : "+list.Count + "\titem: "+ item);
            }

            List<string> animals = new List<string>();
            animals.Add("dog");
            animals.Add("cat");
            animals.Add("fish");
            animals.Add("dragon");
            animals.Add("mause");
            
            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine($" animals{i} item : " + animals[i]);
            }
            

        }
    }
}
