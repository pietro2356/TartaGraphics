using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLTartaGraphics
{
    public class Fractal: Lavagna
    {
        public override void DrawFractal(double l, double alfa, int order)
        {
            Spessore = 2;
            if (order == 0)
            {
                Segment(l, alfa, order, Color.Red);
            }
            else
            {
                DrawFractal((l / 3), alfa, order - 1);
                DrawFractal((l / 3), alfa + 60, order - 1);
                DrawFractal((l / 3), alfa - 60, order - 1);
                DrawFractal((l / 3), alfa, order - 1);
            }
        }
    }
}
