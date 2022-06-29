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

        public data1()
        {
            InitializeComponent();
            List<string> datatables = new List<string>();

            BaseAccessForManager managerAcess = new BaseAccessForManager("admin", "1234");
            MySqlConnection conn = managerAcess.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Show table";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                datatables.Add(reader[0].ToString());
            }
            tablename.DataSource = datatables;
            

        }

        private void data1_Load(object sender, EventArgs e)
        {
           
            BaseAccessForManager managerAcess = new BaseAccessForManager("admin", "1234");
            
            MySqlConnection conn = managerAcess.Connect();
            managerAcess.Search();
            
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

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
