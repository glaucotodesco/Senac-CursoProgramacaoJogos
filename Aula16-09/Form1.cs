using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula16_09
{
    public partial class Form1 : Form
    {
        private Timer t;
        private List<Bola> bolas = new List<Bola>();
        private Raquete player = new Raquete(10, 10, 50, 20, Brushes.Black);
        private bool esquerda, direita;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarObjetos();

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

        private void IniciarObjetos()
        {

            //Posiciona o player no canto inferior do form
            player.x = (this.ClientRectangle.Width / 2) - (player.largura / 2);
            player.y = this.ClientRectangle.Height - player.altura;

            Bola b1 = new Bola(10, 50, 30, 30, Brushes.Black);
            Bola b2 = new Bola(150, 50, 30, 30, Brushes.Black);
            bolas.Add(b1);
            bolas.Add(b2);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: esquerda = false; break;
                case Keys.Right: direita = false; break;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left: esquerda = true; break;
                case Keys.Right: direita = true; break;
            }
        }

        private void GameLoop(object sender, PaintEventArgs e)
        {


            foreach (Bola bola in bolas)
            {
                bola.Mover();
                bola.Desenhar(e.Graphics);
                bola.TrataColisao(this.ClientRectangle.Width, this.ClientRectangle.Height);
                player.TrataColisao(bola);
            }

            if (esquerda)
            {
                player.incX = -1;
            }
            else
            {
                if (direita)
                {
                    player.incX = 1;
                }
                else
                {
                    player.incX = 0;
                }
            }

            player.TrataColisao(this.ClientRectangle.Width, this.ClientRectangle.Height);
            player.Mover();
            player.Desenhar(e.Graphics);




        }
    }
}
