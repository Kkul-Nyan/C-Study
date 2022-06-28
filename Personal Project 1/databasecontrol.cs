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
        


        public databasecontrol()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }


        private void button1_Click(object sender, EventArgs e)
        {

            BaseAccess bassaccess = new BaseAccess(textBox1.Text.ToString(), textBox2.Text.ToString());
            MySqlConnection conn = bassaccess.Connect();
           
            if (textBox1.Text.ToString() == "player")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception except)
                {
                    MessageBox.Show("아이디,비밀번호를 다시 확인해주세요.", "오류");
                }
            }

            else
            {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
             
            
            BaseAccess bassacess = new BaseAccess(textBox1.Text.ToString(), textBox2.Text.ToString());
            MySqlConnection conn = bassacess.Connect();

                if (textBox1.Text.ToString() == "player")
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception except)
                    {
                        MessageBox.Show("아이디,비밀번호를 다시 확인해주세요.", "오류");
                    }
                }

                else
                {
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
            }
        }
    }
}
