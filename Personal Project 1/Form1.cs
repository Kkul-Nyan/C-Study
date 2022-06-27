namespace Personal_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnword_Click(object sender, EventArgs e)
        {
            word word = new word();
            word.ShowDialog();
        }

        private void btnstring_Click(object sender, EventArgs e)
        {
            strings strings = new strings();
            strings.ShowDialog();
        }

        private void btnpage_Click(object sender, EventArgs e)
        {
            page page = new page();
            page.ShowDialog();
        }

        private void btngame_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.ShowDialog();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}