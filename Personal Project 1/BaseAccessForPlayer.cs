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

        public BaseAccessForPlayer()
        {
            USERNAME = "player";
            PASSWORD = "1234";
        }

        public string SERVER1 => IAccessFordatabase.SERVER;
        public string PORT1 => IAccessFordatabase.PORT;
        public string DATABASE1 => IAccessFordatabase.DATABASE;
        public string HiddenUSERNAME => throw new NotImplementedException();
        public string HiddenPASSWORD => throw new NotImplementedException();

        public string USERNAME1 { get => USERNAME;  }
        public string PASSWORD1 { get => PASSWORD;  }

        public MySqlConnection Connect()
        {
            string strConn = $"server={IAccessFordatabase.SERVER};port={IAccessFordatabase.PORT};username={USERNAME1};password={PASSWORD1};database={IAccessFordatabase.DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public List<PopupDatatable> UseData(string table, string content)
        {
            MySqlConnection conn = Connect();
            List<PopupDatatable> popupdatatables = new List<PopupDatatable>();
            try
            {
               
                conn.Open();
            
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{table}`";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PopupDatatable popupdatatable = new PopupDatatable();
                    popupdatatable.Content = reader[1].ToString();

                    popupdatatables.Add(popupdatatable);
                }

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
            return popupdatatables;

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
