using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_1
{
    public partial class databasecontrol : Form
    {
        private string SERVER = "127.0.0.1";
        private string PORT = "3306";
        private string USERNAME = "root";
        private string PASSWORD = "1234";
        private string DATABASE = "typingtraining";

        public databasecontrol()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            USERNAME = textBox1.Text.ToString();
            PASSWORD = textBox2.Text.ToString();
            BaseAccess bassacess = new BaseAccess(USERNAME, PASSWORD);
            MySqlConnection conn = bassacess.Connect();

            try
            {
                conn.Open();
                
                data1 dat1 = new data1();
                dat1.ShowDialog();
                this.Close();
            }

            catch (Exception except)
            {
                Console.WriteLine(except.Message);
                MessageBox.Show("아이디,비밀번호를 다시 확인해주세요.", "오류");
                
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
