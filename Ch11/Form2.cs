using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form2 : Form
    {
       


        public Form2()
        {
            InitializeComponent();
            List<string> positions = new List<string>() { "사원", "대리", "과장", "차장", "부장" };
            cb1.DataSource = positions;

            string[] hobbies = { "등산하기", "운동하기", "영화보기", "독서하기", "게임하기" };
            cb2.DataSource = hobbies;
            //콤보박스 데이터 공급

            //리스트박스 데이터 공급
            string[] country = { "대한민국", "미국", "일본", "중국", "대만",
                                "호주", "영국", "프랑스", "헝가리", "러시아" };
            lstcountry.DataSource = country;
            //데이터그리드뷰 데이터공급
            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", "010-1234-1001", 24));
            members.Add(new Member("a102", "김춘추", "010-1234-1002", 30));
            members.Add(new Member("a103", "장보고", "010-1234-1003", 21));
            members.Add(new Member("a104", "강감찬", "010-1234-1004", 53));
            members.Add(new Member("a105", "이순신", "010-1234-1005", 42));

            dgvmember.DataSource = members;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form2가 로드 될떄 실행
            //콤보박스 데이터공급 여기다 해줘도 된다.



        }

        private void cbbt1_Click(object sender, EventArgs e)
        {
            result1.Text = "결과 :"+cb1.Text;
        }

        private void cbbt2_Click(object sender, EventArgs e)
        {
            result2.Text = "결과 :" + cb2.Text;
        }

        private void lstcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            if (lstcountry.Text == "대한민국")
            {
                pictureBox1.ImageLocation = @"C:\Users\1302\Desktop\C-Study\Ch11\Resources\mpvi15000014.jpg";
                pictureBox1.Visible = true; 
            }
            else if (lstcountry.Text == "미국")
            {
                pictureBox1.ImageLocation = @"C:\Users\1302\Desktop\C-Study\Ch11\Resources\03.jpg";
                pictureBox1.Visible = true;
            }
            else
            { 
                pictureBox1.Visible = false; 
            }
            lstresult.Text = "결과 : " + lstcountry.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebutten_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path1 = @"C:\Users\1302\Desktop\SampleSave.txt";
                FileStream Save = new FileStream(path1, FileMode.Create, FileAccess.Write);
                StreamWriter save = new StreamWriter(Save);

                save.WriteLine(cbbt1_Click);
                save.WriteLine(result1.Text);
                save.WriteLine("결과 :" + cb1.Text);




            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
