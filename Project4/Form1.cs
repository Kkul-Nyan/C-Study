namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] ballVisible = new bool[100];
        Rectangle ball;
        

        Brush RedColor = new SolidBrush(Color.Red);
        Brush BlockColor = new SolidBrush(Color.Orange);
        Brush BallColor = new SolidBrush(Color.Gold);

        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int fowmH = 500;

        int nBlocks = 20;
        
        int blockY = 60;
        int blockW = 30;
        int blockH = 20;


        int racketY = 480;
        int racketW = 50;
        int racketH = 10;
        
        int ballW = 10;
        int ballH = 10;

        double slope = 1; //����
        double vDir = 1; //�� �������� ����

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            //��������
            this.ClientSize = new Size(300, 500);
            this.Text = "BlockBreak v1.0";
            
            //�׷��� ��ü ����
            g = this.CreateGraphics();

            //����ʱ�ȭ
            initBlock();

            //��� visible �� �ʱ�ȭ

            //�����ʱ�ȭ
            initRacket();

            //�� �ʱ�ȭ
            initBall();






        }

        public void initBlock() 
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);

                ballVisible[i] = true;


            }
        }
        public void initRacket() 
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void initBall() 
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;
            //���Ⱚ �ʱ�ȭ
            slope = rand.Next(1, 20) / 10.0;
            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            //���� �׸���
            for (int i = 0; i < nBlocks; i++)
            {
                if (ballVisible[i])
                {
                    g.FillRectangle(BlockColor, blocks[i]);
                }
            }

            //���� �׸���
            g.FillRectangle(RedColor, racket);


            //�� �׸���
            g.FillEllipse(BallColor, ball);
            g.DrawEllipse(pen, ball);


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;
            int x = (int)dx;
            int y = (int)(vDir * slope * dx);
            ball.X += x;
            ball.Y += y;
            //���� �¿� ���� �浹�ߴ��� üũ
            if(ball.X<0 || ball.X >formW-ballW)

                slope = -slope;
            
            //���� ���Ͽ� �¾Ҵ��� üũ
            if( ball.Y <0 || racket.IntersectsWith(ball))
            {
                vDir = -vDir;
            }
                
            //���� ������ �¾Ҵ��� üũ
            for(int i = 0; i<nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    vDir = -vDir;
                    ballVisible[i] = false;
                }
            }

            //ball�� �������� ������ ��
            if(ball.Y == ClientSize.Height)
            {
                DialogResult result = MessageBox.Show("�ٽ� ���� �ϰڽ��ϱ�?", "GAME OVER", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    initBlock();
                    initRacket();
                    initBall();
                }
                else
                {
                    this.Close();
                }

                return;
            }

                
           Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if(e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }
            Invalidate();

        }
    }
}