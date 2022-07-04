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
    public partial class word : Form
    {
        private int no = 0;
       
        int right = 0;
        int wrong = 0;
        int total = 0;

        List<string> tables = new List<string>();
        List<string> contents = new List<string>();



        private int PopUp()
        {
            Random popup = new Random();
            return popup.Next(0, tables[no].Count()) ;
        }

        BaseAccessForPlayer player = new BaseAccessForPlayer();

       private void content()
        {
            MySqlConnection conn = player.Connect();
            string a;
            try
            {
                //데이터베이스 접속
                conn.Open();
                //Sql실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Select `contents` From {tables[no]} Where `cid` = '{PopUp()}' ";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    a = reader[1].ToString();
                    contents.Add(a);
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
        }
        
        private void Reset()
        {
            right = 0;
            wrong = 0;
            total = 0;
            txtTyping.Clear();
            txtShow.Clear();
            label1.Text = "총횟수 : " +  0;
            label2.Text = "맞춘횟수 : " + 0;
            label3.Text = "틀린횟수 : " + 0;
            label4.Text = "정확도 : " + 0;
        }

        private void startword()
        {
           if (no == 1)
            {
                PopUp();

                txtShow.Text = null;
            }
            else if (no == 2)
            {
                PopUp();
                txtShow.Text = null;
            }
            else
            {
                PopUp();
                txtShow.Text = null;
            }
        }
        public word()
        {
            InitializeComponent();

            MySqlConnection conn = player.Connect();
            string a;
            try
            {
                //데이터베이스 접속
                conn.Open();
                //Sql실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SHOW TABLES";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    a = reader[0].ToString();
                    tables.Add(a);
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
        }

        private void word_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startword();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTyping_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string label = txtTyping.Text.ToString();
                string check1 = txtShow.Text.ToString();
                if (no == 1)
                {
                    if (label == check1)
                    {
                        ++right; ++total;
                        startword();
                        txtTyping.Clear();
                        label1.Text = "총횟수 : " + total;
                        label2.Text = "맞춘횟수 : " + right;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                    }
                    else
                    {
                        ++wrong; ++total;
                        MessageBox.Show("틀렸습니다.다시 타이핑해주세요.");
                        label1.Text = "총횟수 : " + total;
                        label3.Text = "틀린횟수 : " + wrong;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                    }
                }
                else if (no == 2)
                {
                    if (label == check1)
                    {
                        ++right; ++total;
                        startword();
                        txtTyping.Clear();
                        label1.Text = "총횟수 : " + total;
                        label2.Text = "맞춘횟수 : " + right;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                    }
                    else
                    {
                        ++wrong; ++total;
                        label1.Text = "총횟수 : " + total;
                        label3.Text = "틀린횟수 : " + wrong;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                        MessageBox.Show("틀렸습니다.다시 타이핑해주세요.");
                    }
                }
                else
                {
                    if (label == check1)
                    {
                        ++right; ++total;
                        startword();
                        txtTyping.Clear();
                        label1.Text = "총횟수 : " + total;
                        label2.Text = "맞춘횟수 : " + right;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                    }
                    else
                    {
                        ++wrong; ++total;
                        label1.Text = "총횟수 : " + total;
                        label3.Text = "틀린횟수 : " + wrong;
                        label4.Text = "정확도 : " + (right * 100 / total) ;
                        MessageBox.Show("틀렸습니다.다시 타이핑해주세요.");
                    }

                }
            }
        }
        private void btnKor_Click(object sender, EventArgs e)
        {
            no = 0;
            Reset();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            no = 1;
            Reset();
        }

        private void btnKE_Click(object sender, EventArgs e)
        {
            no = 2;
            Reset();
        }



    }
}
