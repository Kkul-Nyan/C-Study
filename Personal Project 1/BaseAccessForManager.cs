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
        public string HiddenUSERNAME => throw new NotImplementedException();
        public string HiddenPASSWORD => throw new NotImplementedException();


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
            string strConn = $"server={IAccessFordatabase.SERVER};port={IAccessFordatabase.PORT};username={USERNAME1};password={PASSWORD1};database={IAccessFordatabase.DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void UseforTyping()
        {
            throw new NotImplementedException();
        }

        public void Insert(int uid, string words)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
               cmd.CommandText = $"INSERT INTO `{table}` VALUES ('{uid}', '{words}')";

                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("데이터가 저장되었습니다.", "완료");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
        private string table;
        public List<Datatable> Search()
        {
            {
                MySqlConnection conn = Connect();
                List<Datatable> datatables = new List<Datatable>();
                try
                {
                    //데이터베이스 접속
                    conn.Open();
                    //Sql실행
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM `{table}`";

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Datatable datatable = new Datatable();
                        datatable.Uid = Convert.ToInt32(reader[0]);
                        datatable.Words = reader[1].ToString();

                        datatables.Add(datatable);
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
                return datatables;
            }
        }

        public void Find()
        {
            throw new NotImplementedException();
        }
    }
}
