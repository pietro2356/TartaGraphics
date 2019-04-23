using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLGraficaTartaruga
{
    public class Alberi: Fractal
    {
        public void Tree(double lTronco, double alfa, int order)
        {
            Gradiente grad = new Gradiente(Color.Green, Color.Brown, order+1);
            Color = Color.Brown;
            if (order == 0)
            {
                //disegna foglia
            }
            else
            {
                Segment(lTronco, alfa, order, grad[order]);

                double sX = Xc;
                double sY = Yc;
                Tree(lTronco * 3 / 4, alfa - 30, order - 1);
                MoveTo(sX, sY);
                Tree(lTronco * 3 / 4, alfa + 30, order - 1);
            }
        }
    }
}
