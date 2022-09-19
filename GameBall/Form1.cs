using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBall
{
    public partial class Form1 : Form
    {
        Timer t;
        Brush brush = Brushes.Green;
        int x=200, incX=1;
        int y = 200, incY = 1;
        Image img;
        

        public Form1()
        {
            InitializeComponent();
    
        }
        private void GameLoop(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(brush, x, y, 40, 40);
            e.Graphics.DrawImage(img, x, y, 40, 40);

            x = x + incX;
            y = y + incY;

            if(y > this.ClientRectangle.Height -  40)
            {
                brush = Brushes.Red;
                incY = -1;
            }
            
            if (y < 0)
            {
                brush = Brushes.Blue;
                incY = 1;
            }

            if (x > this.ClientRectangle.Width - 40)
            {
                brush = Brushes.Yellow;
                incX = -1;
            }
            if (x < 0)
            {
                brush = Brushes.Green;
                incX = 1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);
            t.Start();
            img = Image.FromFile("nave.png");
            
        }
        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }
       
    }
}
