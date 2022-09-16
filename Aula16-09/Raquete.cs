using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16_09
{
    public class Raquete : MyMonoBehaviour
    {
        public Raquete(int x, int y, int largura, int altura, Brush brush)
            : base(x, y, largura, altura, brush)
        {
        }

        public void TrataColisao(Bola bola)
        {
            if (this.colisao.IntersectsWith(bola.colisao)) {
                bola.incY = -1;
            }

        }

        public new void Desenhar(Graphics g)
        {
            g.FillRectangle(brush, x, y, largura, altura);
        }



    }
}
