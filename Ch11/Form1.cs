namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void subtitle_label_Click(object sender, EventArgs e)
        {

        }

        private void BT_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼1 클릭");
        }

        private void BT_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼2 클릭");
        }

        private void BT_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼3 클릭");
        }

        private void BT_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼4 클릭");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string uid = textUID.Text;
            labelresult1.Text = "결과 : " + uid;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            labelresult2.Text = "결과 : " + textName.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            labelresult3.Text = "결과 : " + textHp.Text;
        }

        private void labelresult1_Click(object sender, EventArgs e)
        {
            
        }

        private void Fbutten1_Click(object sender, EventArgs e)
        {
            CheckBox[] Fboxs = { Fbox1, Fbox2, Fbox3, Fbox4, Fbox5 };
            List<string> fruits = new List<string>();
            foreach(CheckBox chb in Fboxs)
            {
                if(chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbresultF.Text = "선택한 과일 : " + String.Join(", ", fruits);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void content2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MBT_Click(object sender, EventArgs e)
        {
            if(maleRB.Checked)
            { Mresult.Text = "결과 : 남성"; }
            else
            { Mresult.Text = "결과 : 여성"; }
        }

        private void ABT_Click(object sender, EventArgs e)
        {
            if(ARB1.Checked)
            {
                Aresult.Text = "결과 : 1학년";
            }
            else if(ARB2.Checked)
            {
                Aresult.Text = "결과 : 2학년";
            }
            else if(ARB3.Checked)
            {
                Aresult.Text = "결과 : 3학년";
            }
            else 
            {
                Aresult.Text = "결과 : 4학년";
            }

        }

        private void BTFrom2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}