using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11
{
    internal class Member
    {
        private string uid;
        private string name;
        private string hp;
        private int Age;

        public Member(string uid, string name, string hp, int age)
        {
            this.Uid = uid;
            this.Name = name;
            this.Hp = hp;
            Age1 = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age1 { get => Age; set => Age = value; }
    }
}
