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
                txtShow.Text = null;
            }
            else if (language == 2)
            {
                txtShow.Text = null;
            }
            else
            {
                txtShow.Text = null;
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
