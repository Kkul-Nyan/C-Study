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
        protected const string hiddenUSERNAME = "admin";
        protected const string hiddenPASSWORD = "1234";

        string SERVER1 { get; }
        string PORT1 { get; }
        string DATABASE1 { get; }
        string HiddenUSERNAME { get; }
        string HiddenPASSWORD { get; }


        public MySqlConnection Connect();
        public void UseforTyping();
        public void Insert(string table, int cid, string content);
        public void Update(string table, int cid, string content);
        public void Delete(string table, int cid);
        public List<Datatable> Search(string table);
        public void Find();
    }
}
