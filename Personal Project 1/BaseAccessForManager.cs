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
 
        public List<PopupDatatable> UseData(string table, string content)
        {
            throw new NotImplementedException();
        }

        

        public void Insert(string table,int cid, string content)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
               cmd.CommandText = $"INSERT INTO `{table}` VALUES ('{cid}', '{content}')";

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

        public void Update(string table, int cid, string content)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE `{table}` SET `content` = '{content}' WHERE `cid` = '{cid}' ";

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
            MessageBox.Show("데이터가 수정되었습니다.", "완료");
        }
    

        public void Delete(string table, int cid)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from `{table}` WHERE `cid` = '{cid}' ";

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
            MessageBox.Show("데이터가 삭제되었습니다.", "완료");
        }
    

        public List<Datatable> Search(string table)
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
                        datatable.Cid = Convert.ToInt32(reader[0]);
                        datatable.Content = reader[1].ToString();

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

        public string Find(string table, int cid)
        {
            string A = "Null";
            MySqlConnection conn = Connect();

            try
            {
               conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{table}` WHERE `cid` ={cid} ";

                MySqlDataReader reader = cmd.ExecuteReader();
                
                while(reader.Read())
                {
                    Console.WriteLine(reader[1].ToString());
                    A = reader[1].ToString();
                }


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
            return A;
        }

    }
}
