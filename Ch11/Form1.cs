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
            MessageBox.Show("��ư1 Ŭ��");
        }

        private void BT_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ư2 Ŭ��");
        }

        private void BT_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ư3 Ŭ��");
        }

        private void BT_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ư4 Ŭ��");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string uid = textUID.Text;
            labelresult1.Text = "��� : " + uid;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            labelresult2.Text = "��� : " + textName.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            labelresult3.Text = "��� : " + textHp.Text;
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

            lbresultF.Text = "������ ���� : " + String.Join(", ", fruits);


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
            { Mresult.Text = "��� : ����"; }
            else
            { Mresult.Text = "��� : ����"; }
        }

        private void ABT_Click(object sender, EventArgs e)
        {
            if(ARB1.Checked)
            {
                Aresult.Text = "��� : 1�г�";
            }
            else if(ARB2.Checked)
            {
                Aresult.Text = "��� : 2�г�";
            }
            else if(ARB3.Checked)
            {
                Aresult.Text = "��� : 3�г�";
            }
            else 
            {
                Aresult.Text = "��� : 4�г�";
            }

        }

        private void BTFrom2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}