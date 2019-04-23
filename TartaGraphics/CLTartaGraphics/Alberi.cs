using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLTartaGraphics
{
    public class Alberi: Fractal
    {
        public override void DrawTree(double lTronco, double alfa, int order)
        {
            Gradiente grad = new Gradiente(Color.Green, Color.Brown, order + 1);
            Colore = Color.Brown;
            if (order == 0)
            {
                ///TODO: Disegna Foglia;
            }
            else
            {
                Segment(lTronco, alfa, order, grad[order]);

                double sX = Xc;
                double sY = Yc;
                DrawTree(lTronco * 3 / 4, alfa - 30, order - 1);
                MoveTo(sX, sY);
                DrawTree(lTronco * 3 / 4, alfa + 30, order - 1);
            }
        }
    }
}
