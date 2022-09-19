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
        
        
        Inimigo[] inimigos = new Inimigo[1000];
      
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            for(int i=0; i < inimigos.Length; i++)
            {
                inimigos[i] = new Inimigo(r.Next(this.ClientRectangle.Width), r.Next(this.ClientRectangle.Height));
                inimigos[i].incX = r.Next(2) == 0 ? 1 : -1;
                inimigos[i].incY = r.Next(2) == 0 ? 1 : -1;
            }
            


        }
        private void GameLoop(object sender, PaintEventArgs e)
        {
            foreach(Inimigo i in this.inimigos)
            {
                i.Desenhar(e.Graphics);
                i.Move();
                i.Collision(this.ClientRectangle.Width, this.ClientRectangle.Height);

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
          
            
        }
        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }
       
    }
}
