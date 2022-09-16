using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16_09
{
    public class MyMonoBehaviour
    {
        public int x;
        public int y;
        public int largura = 50;
        public int altura = 50;
        public int incX = 0;
        public int incY = 0;
        public Brush brush = Brushes.Black;
        public Rectangle colisao;


        public MyMonoBehaviour(int x, int y, int largura, int altura, Brush brush)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;
            this.brush = brush;

            colisao = new Rectangle(x, y, largura, altura);
        }

        public void Mover()
        {
            x = x + incX;
            y = y + incY;

            colisao.X = x;
            colisao.Y = y;
        }

        public void Desenhar(Graphics g)
        {
            g.FillEllipse(brush, x, y, largura, altura);
        }


        public void TrataColisao(int larguraForm, int alturaForm)
        {

            if (x > larguraForm - largura)
            {
                incX = -1;
            }
            else
            if (x < 0)
            {
                incX = 1;
            }


            if (y < 0)
            {
                incY = 1;
            }

        }


    }
}
