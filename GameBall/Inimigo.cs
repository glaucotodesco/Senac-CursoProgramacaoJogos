using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBall
{
    class Inimigo
    {
        int x = 200;
        int y = 200;
        public int incX = 1;
        public int incY = 1;
        Image img  = Image.FromFile("nave.png");
      

        public Inimigo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Desenhar(Graphics g)
        {
            g.DrawImage(img, x, y, 40, 40);
        }

        public void Move()
        {
            x = x + incX;
            y = y + incY;
        }

        public void Collision(int width, int height)
        {
            if (y > height - 40 || y < 0)
            {
                incY *= -1;
            }

            if (x > width - 40 || x < 0)
            {
                incX *= -1;
            }
        }
    }
}
