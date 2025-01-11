using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public abstract class GraphicShape
    {
        private Color lineColor;
        private float lineWidth;
        private Rectangle bounds;

        public Color LineColor { get; set; }
        public float LineWidth { get; set; }
        public Rectangle Bounds { get; set; }

        public GraphicShape() { }

        public GraphicShape( Color lineColor, float lineWidth)
        {
            LineColor = lineColor;
            LineWidth = lineWidth;
        }

        public abstract void Deserialize(string record);
        public abstract void Draw(Graphics g);
        public abstract string Serialize();
    }
}
