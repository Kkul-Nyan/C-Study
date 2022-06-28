


using MySqlConnector;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<User> users =DBAccess.Instance.SelectUsers();

            //데이터그리드뷰 데이터공급
            dataGridView1.DataSource = users;
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();

            //데이터그리드뷰 데이터공급
            dataGridView1.DataSource = users;
        }

        private void txtUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void nAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.InsertUser(uid, name, hp, age);
            Reset();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            Reset();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.DeleteUser(uid, name, hp, age);
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("click");
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            string uid = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string hp = row.Cells[2].Value.ToString();
            string age = row.Cells[3].Value.ToString();
        
            txtName.Text = name;
            txtUid.Text = uid;
            txtHp.Text = hp;
            nAge.Text = age;
        }
    }
}
