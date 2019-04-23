using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CLGraficaTartaruga
{
    public class Turtle : Panel
    {
        Graphics canvas;
        private double xc;
        private double yc;
        private float spessore;
        private Color color;

        public Graphics Canvas { get => canvas; set => canvas = value; }
        public double Xc { get => xc; set => xc = value; }
        public double Yc { get => yc; set => yc = value; }
        public float Spessore { get => spessore; set => spessore = value; }
        public Color Color { get => color; set => color = value; }

        public Turtle()
        {
            BorderStyle = BorderStyle.FixedSingle;
            Resize += Turtle_Resize;
            Dock = DockStyle.Fill;
            Color = Color.OrangeRed;
        }

        private void Turtle_Resize(object sender, EventArgs e)
        {
            canvas = CreateGraphics();
            Xc = Width / 2;
            Yc = Height / 2;
        }

        public Turtle(Graphics canvas, double xc, double yc, float spessore, Color color)
        {
            Canvas = canvas;
            Xc = xc;
            Yc = yc;
            Color = color;
        }
        public void Clear()
        {
            canvas.Clear(BackColor);
        }

        public void MoveTo(double x, double y)
        {
            Xc = x;
            Yc = y;
        }
        public void Segment(double dx, double alfa, float spessore, Color colore)
        {
            Spessore = spessore;
            Color = colore;
            double x = Xc + dx * Math.Cos((alfa * Math.PI) / 180);
            double y = Yc + dx * -Math.Sin((alfa * Math.PI) / 180);
            canvas.DrawLine(new Pen(Color, Spessore), (float)Xc, (float)Yc, (float)x, (float)y);
            MoveTo(x, y);
        }
    }
}
