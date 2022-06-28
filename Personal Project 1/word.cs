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
        private string[] korwords = new string[]
        {    "안녕", "사과", "젓가락", "숫가락", "마우스", "모니터", "아침햇살", "힘들다", "가방", "고양이",
             "담배", "강아지", "벚꽃나무", "드레곤볼", "프로젝터", "냥냥이", "꿀떡이", "부산", "서울", "대구",
             "바나나", "대전", "청주", "고등어", "도다리", "광어", "다금바리", "전갱이", "아징", "겨울바다",
             "전주", "비빔밥", "약주", "막걸리", "내동생", "부모님", "가족", "애완동물", "친구", "부랄친국",
             "경국지색", "휴대폰", "스마트폰", "연락처", "주소록", "금연", "금주", "희노애락", "고향", "별",
             "은하수", "단비", "소나기", "장마", "태풍", "맑음", "전화번호", "카카오아이디", "뜸북새", "뻐꾸기",
             "태양", "별똥별", "거북이", "토끼", "당근", "브로콜리", "라면", "우동", "우정", "정물화",
             "화요일", "일본", "본드", "드라이버", "버스", "스키", "키스", "스물여덟", "승리", "이발소",
             "소아비만", "만득이", "이차함수", "수영장", "장대비", "비밀친구", "구렁이", "이모님", "임창정", "정복자",
             "자가용", "용가리", "이삿짐", "짐꾼", "이야기꾼", "물병", "점심시간", "배탈", "정글", "탑신병자","미드미아"
        };
        private string[]check = new string[] {"크","","티", "크", "쿠", "티", "크", "쿠", "티","크"
        ,"1","2","3", "4", "5", "6", "7", "8", "9","10"
        ,"크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크"
        ,"크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크"
        ,"크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크"
        ,"크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크"
        ,"크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크",
        "크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크",
        "크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크",
        "크","쿠","티", "크", "쿠", "티", "크", "쿠", "티","크","0"};

        private int language = 0;
       
        int right = 0;
        int wrong = 0;
        int total = 0;
        private int PopUp()
        {
            Random popup = new Random();
            return popup.Next(1, 101);
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
            if (language == 1)
            {
                txtShow.Text = check[PopUp()];
            }
            else if (language == 2)
            {
                txtShow.Text = check[PopUp()];
            }
            else
            {
                txtShow.Text = korwords[PopUp()];
            }
        }
        public word()
        {
            InitializeComponent();
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
                if (language == 1)
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
                else if (language == 2)
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
            language = 0;
            Reset();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            language = 1;
            Reset();
        }

        private void btnKE_Click(object sender, EventArgs e)
        {
            language = 2;
            Reset();
        }

        private void word_Load(object sender, EventArgs e)
        {
            
        }


    }
}
