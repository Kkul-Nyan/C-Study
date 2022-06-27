namespace projecct1
{
    public partial class Form1 : Form
    {
        private int var1 = 0;
        private int var2 = 0;


        private List<int> nums = new List<int>();   
        private List<int> operates = new List<int>();
        private int result = 0;
        private int operate = 0; // 1:puls, 2:minus 3:multi 4: div



        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "1";
            nums.Add(1);
            txtResult.Text = String.Join("",nums);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "2";
            nums.Add(2);
            txtResult.Text = String.Join("", nums);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3";
            nums.Add(3);
            txtResult.Text = String.Join("", nums);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = "4";
            nums.Add(4);
            txtResult.Text = String.Join("", nums);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = "5";
            nums.Add(5);
            txtResult.Text = String.Join("", nums);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = "6";
            nums.Add(6);
            txtResult.Text = String.Join("", nums);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = "7";
            nums.Add(7);
            txtResult.Text = String.Join("", nums);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = "8";
            nums.Add(8);
            txtResult.Text = String.Join("", nums);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = "9";
            nums.Add(9);
            txtResult.Text = String.Join("", nums);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            nums.Add(0);
            txtResult.Text = String.Join("", nums); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            var1 = 0;
            var2 = 0;
            operate = 0;
            nums.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operate = 4;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);
            nums.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operate = 3;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);
            nums.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operate = 2;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);
            nums.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operate = 1;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);
            nums.Clear();
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var2 = int.Parse(currentNum);
            nums.Clear();

            switch (operate)
            {
                case 1:
                    result = var1 + var2;
                    break;
                case 2:
                    result = var1 - var2;
                    break;
                case 3:
                    result = var1 * var2;
                    break;
                case 4:
                    result = var1 / var2;
                    break;
            }

            
            txtResult.Text = result.ToString();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}