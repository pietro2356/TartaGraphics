using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLGraficaTartaruga
{
    public class Gradiente : List<Color>
    {
        public Gradiente(Color CStart, Color CEnd, int nColor)
        {
            Delta(CStart, CEnd, nColor);
        }

        private void Delta(Color Cstart, Color CEnd, int nColor)
        {

            int r = Cstart.R;
            int g = Cstart.G;
            int b = Cstart.B;

            for (int i = 0; i < nColor; i++)
            {
                Add(Color.FromArgb(r, g, b));
                r += (CEnd.R - Cstart.R) / nColor;
                g += (CEnd.G - Cstart.G) / nColor;
                b += (CEnd.B - Cstart.B) / nColor;
            }

        }
    }
}
