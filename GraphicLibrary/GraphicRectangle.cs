using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
	public class GraphicRectangle : GraphicShape
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

		public GraphicRectangle() { }

		public GraphicRectangle(Color lineColor, float lineWidth)
		{
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}
		public GraphicRectangle(Point endPt, Point startPt, Color lineColor, float lineWidth)
		{
			this.TopLeft = startPt;
			this.BottomRight = endPt;
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}

		public override void Deserialize(string record)
		{
			throw new NotImplementedException();
		}
		public override void Draw(Graphics g)
		{
			using (Pen pen = new Pen(LineColor, LineWidth))
			{
				g.DrawRectangle(pen, GetRect());
			}
		}
		public override string Serialize()
		{
			throw new NotImplementedException();
		}

		public RectangleF GetRect()
		{
			RectangleF rect = new RectangleF();
			rect.X = Math.Min(topLeft.X, bottomRight.X);

			rect.Y = Math.Min(topLeft.Y, bottomRight.Y);

			rect.Width = Math.Abs(topLeft.X - bottomRight.X);
			rect.Height = Math.Abs(topLeft.Y - bottomRight.Y);

			return rect;

		}
	}
}
