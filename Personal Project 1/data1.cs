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

            List<Datatable> datatables = managerAccess.Search(tablename.Text.ToString());
            dataGridView1.DataSource = datatables;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           managerAccess.Insert(tablename.Text.ToString(),Convert.ToInt32(textBox1.Text),textBox2.Text.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            managerAccess.Update(tablename.Text.ToString(), Convert.ToInt32(textBox1.Text), textBox2.Text.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            managerAccess.Delete(tablename.Text.ToString(), Convert.ToInt32(textBox1.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            string uid = row.Cells[0].Value.ToString();
            string words = row.Cells[1].Value.ToString();

            textBox1.Text = uid;
            textBox2.Text = words;
        }
    }
}
