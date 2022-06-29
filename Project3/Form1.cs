namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int sizeNun = 30;
        private int sizedol = 28;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;
        
        bool isBlack = true;

        enum STONE { none, black, white };
        STONE[,] dataset = new STONE[19, 19];
        

        public Form1()
        {
            InitializeComponent();
            
            //�׷��� ���� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            this.Text = "���� v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2*margin +18 * sizeNun, 2 * margin + 18 * sizeNun);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;
            Console.WriteLine("x :{0} : y :{1}", x, y);

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizedol,
                                          sizedol);
            if (dataset[x, y] != STONE.none)
            {
                MessageBox.Show("�̵̹��̳����ֽ��ϴ�.", "����");
                return;
            }
            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataset[x, y] = STONE.black;

                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataset[x, y] = STONE.white;

                isBlack = true;
            }

        }

        public void CheckOmok(int x, int y)
        {
            int count = 1;
            if (x <15 && y< 15)
            {

                for (int i = 0; i < 5; i++)
                {
                    if (dataset[x, y] == dataset[x + i, y]) ;
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (dataset[x, y] == dataset[x, y + i]) ;
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < 5; i++)
                { 
                    if (dataset[x, y] == dataset[x+i, y + i])
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }

            }
            else
            {
                for(int i = 0; i<5; i++)
                {
                    if (dataset[x,y] == dataset[x-1,y])
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (dataset[x, y] == dataset[x, y - i]) ;
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (dataset[x, y] == dataset[x - i, y - i])
                    {
                        count++;
                    }
                    if (count != 5)
                    {
                        count = 0;
                    }
                }
            }

            if (count == 5)
            {
                MessageBox.Show("����");
            }

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            //�ٵ��� ���� �׸���
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin ), new Point(margin + sizeNun * i, sizeNun * 18 + margin));
            }
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin , margin + sizeNun * i), new Point(sizeNun * 18 + margin , margin + sizeNun * i));
            }
        }


    }
}