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
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void btnWordinvaders_Click(object sender, EventArgs e)
        {
            wordinvaders wordinvaders = new wordinvaders();
            wordinvaders.ShowDialog();

        }

        private void btnRain_Click(object sender, EventArgs e)
        {
            rain rain = new rain();
            rain.ShowDialog();
        }

        private void btnBreakBlocks_Click(object sender, EventArgs e)
        {
            breakBlock breakblocks = new breakBlock(); 
            breakblocks.ShowDialog();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            ranking ranking = new ranking();
            ranking.ShowDialog();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
