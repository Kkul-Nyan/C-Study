using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._006단계
{
    internal class 문자열003
    {
        
        static void Main1(string[] args)
        {
            List<string> words = new List<string>();
            string word = Console.ReadLine();
            for(int i =0; i < word.ToString().Length; i++)
            {
                words[i] = word[i].ToString();
                Console.WriteLine(word[i]);

            }

        }
       


    }
}
