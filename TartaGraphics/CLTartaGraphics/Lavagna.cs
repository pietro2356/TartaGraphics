using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLTartaGraphics
{
    public class Lavagna: Panel
    {
        private Graphics canvas;
        private Color colore;
        private double xc;
        private double yc;
        private float spessore;

        public Graphics Canvas { get => canvas; set => canvas = value; }
        public Color Colore { get => colore; set => colore = value; }
        public double Xc { get => xc; set => xc = value; }
        public double Yc { get => yc; set => yc = value; }
        public float Spessore { get => spessore; set => spessore = value; }

        public Lavagna()
        {
            BorderStyle = BorderStyle.FixedSingle;
            Resize += Lavagna_Resize;
            Dock = DockStyle.Fill;
            Colore = Color.Black;
        }
        public Lavagna(Graphics _canvas, double _xc, double _yc, float spessore, Color _colore)
        {
            canvas = _canvas;
            Xc = _xc;
            Yc = _yc;
            colore = _colore;
        }

        public void Clear()
        {
            canvas.Clear(BackColor);
        }
        private void Lavagna_Resize(object sender, EventArgs e)
        {
            Canvas = CreateGraphics();
            Xc = Width / 2;
            Yc = Height / 2;
        }
        public void MoveTo(double x, double y)
        {
            Xc = x;
            Yc = y;
        }

        public virtual void Segment(double dx, double alfa, float spessore, Color colore)
        {
            Spessore = spessore;
            Colore = colore;
            double x = Xc + dx * Math.Cos((alfa * Math.PI) / 180);
            double y = Yc + dx * -Math.Sin((alfa * Math.PI) / 180);
            canvas.DrawLine(new Pen(Colore, Spessore), (float)Xc, (float)Yc, (float)x, (float)y);
            MoveTo(x, y);
        }
        public virtual void DrawFractal(double l, double alfa, int order) { }
        public virtual void DrawTree(double lTronco, double alfa, int order) { }
    }
}