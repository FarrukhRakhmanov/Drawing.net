using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicEllipse : GraphicShape
    {
        private Point bottomRight;
        private Point topLeft;
        public Point BottomRight
		{
			get
			{
				return bottomRight;
			}
			set
			{
				bottomRight = value;
			}
		}
		public Point TopLeft
		{
			get { return topLeft; }
			set { topLeft = value; }
		}
		
        public GraphicEllipse() { }

		public GraphicEllipse(Color lineColor, float lineWidth)
		{
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}

		public GraphicEllipse(Point endPt, Point startPt, Color lineColor, float lineWidth)
        {
            this.BottomRight = endPt;
            this.TopLeft = startPt;
            base.LineColor = lineColor;
            base.LineWidth = lineWidth;
        }
		//public RectangleF GetRect()
		//{
		//	return new RectangleF(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
		//}
		public override void Draw(Graphics g)
		{
			using (Pen pen = new Pen(LineColor, LineWidth))
			{
				g.DrawEllipse(pen, TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
			}
		}
		public override string Serialize()
        {
            throw new NotImplementedException();
        }
		public override void Deserialize(string record)
		{
			throw new NotImplementedException();
		}
	}
}

