using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1
{
    internal class BaseAccessForPlayer : IAccessFordatabase
    {

        private string USERNAME = "player";
        private string PASSWORD = "1234"; 
        private string? SERVER;
        private string? PORT;
        private string? DATABASE;

        public string SERVER1 => IAccessFordatabase.SERVER;
        public string PORT1 => IAccessFordatabase.PORT;
        public string DATABASE1 => IAccessFordatabase.DATABASE;
        public string HiddenUSERNAME => throw new NotImplementedException();
        public string HiddenPASSWORD => throw new NotImplementedException();

        public MySqlConnection Connect()
        {
            string strConn = $"server={IAccessFordatabase.SERVER};port={IAccessFordatabase.PORT};username={USERNAME};password={PASSWORD};database={IAccessFordatabase.DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void UseforTyping()
        {
            throw new NotImplementedException();
        }

        public void Update(string table, int uid, string words)
        {
            throw new NotImplementedException();
        }

        public void Delete(string table, int uid)
        {
            throw new NotImplementedException();
        }

        public string Find(string table, int cid)
        {
            throw new NotImplementedException();
        }

        public void Insert(string table, int uid, string words)
        {
            throw new NotImplementedException();
        }

         public List<Datatable> Search(string table)
        {
            throw new NotImplementedException();
        }

    }
}
