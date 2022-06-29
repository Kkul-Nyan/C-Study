using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1
{
    internal interface IAccessFordatabase
    {
        protected const string SERVER = "127.0.0.1";
        protected const string PORT = "3306";
        protected const string DATABASE = "typingtraining";
        
        string SERVER1 { get; }
        string PORT1 { get; }
        string DATABASE1 { get; }
        

        public MySqlConnection Connect();
        public void UseforTyping();
        public void Insert();
        public void Update();
        public void Delete();
        public void Search();
        public void Find();
    }
}
