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
        private string PASSWORD = "1111"; 
        private string SERVER;
        private string PORT;
        private string DATABASE;

        public string SERVER1 => SERVER;
        public string PORT1 => PORT;
        public string DATABASE1 => DATABASE;


        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }


        public void UseforTyping()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

    }
}
