using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    [Serializable()]
	public class GraphicPolygon : GraphicShape
	{
		List<Point> points = new List<Point>();
		public List<Point> Points
		{
			get
			{
				return points;
			}
			private set
			{
				points = value;
			}
		}
		public GraphicPolygon() { }

		public GraphicPolygon(Color lineColor, float lineWidth)
		{
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}

		public GraphicPolygon(List<Point> points, Color lineColor, float lineWidth)
		{
			this.points = points;
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}
		public void AddPoint(Point point)
		{
			points.Add(point);
		}
		public void ReplacePoint(Point point)
		{
			this.points[points.Count - 1] = point;
		}

		public override void Draw(Graphics g)
		{
			if (points.Count < 2) return;

			using (Pen pen = new(LineColor, LineWidth))
			{
				g.DrawPolygon(pen, points.ToArray<Point>());
			}
		}

		public override void Deserialize(string record)
		{
			throw new NotImplementedException();
		}
		public override string Serialize()
		{
			throw new NotImplementedException();
		}
	}
}
