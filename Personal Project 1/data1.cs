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
    public partial class data1 : Form
    {
        BaseAccessForManager managerAccess = new BaseAccessForManager("admin", "1234");
        
        public data1()
        {
            InitializeComponent();

            MySqlConnection conn = managerAccess.Connect();
            List<string> tablenames = new List<string>();
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
                    tablenames.Add(a);
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
            tablename.DataSource = tablenames;
        }

        private void data1_Load(object sender, EventArgs e)
        {
            
        }

        private void tablename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string table = tablename.Text.ToString();
            List<Datatable> datatables = managerAccess.Search(table);
            dataGridView1.DataSource = datatables;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int cid = 0;
            string table = tablename.Text.ToString();

            try
            {
                cid = Convert.ToInt32(textBox1.Text);
                if( cid == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("찾을 내용을 입력해주세요.", "오류");
            }
            textBox2.Text = managerAccess.Find(table, cid);
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string table = tablename.Text.ToString();
            int cid = Convert.ToInt32(textBox1.Text);
            string content = textBox2.Text.ToString();

            managerAccess.Insert(table,cid,content);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string table = tablename.Text.ToString();
            int cid = Convert.ToInt32(textBox1.Text);
            string content = textBox2.Text.ToString();
            managerAccess.Update(table, cid, content);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string table = tablename.Text.ToString();
            int cid = Convert.ToInt32(textBox1.Text);

            managerAccess.Delete(table, cid);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("리셋되었습니다.", "완료");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            string cid = row.Cells[0].Value.ToString();
            string content = row.Cells[1].Value.ToString();

            textBox1.Text = cid;
            textBox2.Text = content;
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
