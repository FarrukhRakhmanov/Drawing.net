using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    [Serializable()]
    public class GraphicPolyline : GraphicShape
    {
        private List<Point> points =  new List<Point>();
        public List<Point> Points
        {
            get
            {
                return points;
			}
            set
            {
                points = value;
            }
        }
        public GraphicPolyline(){}

		public GraphicPolyline(Color lineColor, float lineWidth)
		{
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}

		[JsonConstructor]
		public GraphicPolyline(Color lineColor, float lineWidth, List<Point> listPoints)
        {
            this.points = listPoints;
            base.LineColor = lineColor;
            base.LineWidth = lineWidth;
        }
		public void AddPoint(Point point)
		{
			this.points.Add(point);
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
				g.DrawLines(pen, points.ToArray<Point>());
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
