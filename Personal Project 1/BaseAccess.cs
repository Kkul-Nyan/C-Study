using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1
{
    internal class BaseAccess
    {
        private const string SERVER = "127.0.0.1";
        private const string PORT = "3306";
        private const string DATABASE = "typingtraining";
        private string USERNAME;
        private string PASSWORD;

        public BaseAccess(string uSERNAME, string pASSWORD)
        {
            USERNAME = uSERNAME;
            PASSWORD = pASSWORD;
        }

        public static string SERVER1 => SERVER;
        public static string PORT1 => PORT;
        public string USERNAME1 { get => USERNAME; set => USERNAME = value; }
        public string PASSWORD1 { get => PASSWORD; set => PASSWORD = value; }
        public static string DATABASE1 => DATABASE;

        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }
    }
}
