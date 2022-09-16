using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16_09
{
    public class Bola : MyMonoBehaviour
    {
        public Bola(int x, int y, int largura, int altura, Brush brush) : base(x, y, largura, altura, brush)
        {
            this.incX = 1;
            this.incY = 1;
        }
        
    }
}
