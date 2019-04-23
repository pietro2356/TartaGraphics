using System;
using System.Windows.Forms;
using System.Drawing;

namespace CLGraficaTartaruga
{
    public class Fractal: Turtle
    {
        public void DrawFractal(double l, double alfa, int order)
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
