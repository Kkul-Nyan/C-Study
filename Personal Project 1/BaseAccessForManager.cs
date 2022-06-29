using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1
{
    internal class BaseAccessForManager : IAccessFordatabase
    {
        private string SERVER;
        private string PORT;
        private string DATABASE; 

        public string SERVER1 => IAccessFordatabase.SERVER;
        public string PORT1 => IAccessFordatabase.PORT;
        public string DATABASE1 => IAccessFordatabase.DATABASE;

        private string USERNAME;
        private string PASSWORD;

        public BaseAccessForManager(string uSERNAME, string pASSWORD)
        {
            USERNAME = uSERNAME;
            PASSWORD = pASSWORD;
        }

        public string USERNAME1 { get => USERNAME; set => USERNAME = value; }
        public string PASSWORD1 { get => PASSWORD; set => PASSWORD = value; }



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
