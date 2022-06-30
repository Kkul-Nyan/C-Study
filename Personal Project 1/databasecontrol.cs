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

            BaseAccessForManager managerAcess = new BaseAccessForManager("admin", "1234");
           
            MySqlConnection conn = managerAcess.Connect();

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

            else if (textBox1.Text.ToString() == "admin")
            {
                data1 dat1 = new data1();
                dat1.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디,비밀번호를 다시 확인해주세요.", "오류");
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
            BaseAccessForManager managerAcess = new BaseAccessForManager(textBox1.Text.ToString(), textBox2.Text.ToString());
            MySqlConnection conn = managerAcess.Connect();
               
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

                else if (textBox1.Text.ToString() == "admin")
                {
                    data1 dat1 = new data1();
                    dat1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("아이디,비밀번호를 다시 확인해주세요.", "오류");
                }
            }
        }


    }
}
