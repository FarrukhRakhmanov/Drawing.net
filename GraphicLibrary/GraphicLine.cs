using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicLine : GraphicShape
    {
        #region fields
        private Point endPt;
        private Point startPt;
		#endregion

		#region properties
		public Point EndPt
        {
            get
            {
                return endPt;
            }
            set
            {
                endPt = value;
            }
        }
        public Point StartPt
        {
            get
            {
                return startPt;
            }
            set
            {
                startPt = value;
            }
        }

		#endregion

		#region constructors
		public GraphicLine() { }

		public GraphicLine(Color lineColor, float lineWidth)
		{
			base.LineColor = lineColor;
			base.LineWidth = lineWidth;
		}

		public GraphicLine(Point endPt, Point startPt, Color lineColor, float lineWidth)
        {
            this.endPt = endPt;
            this.startPt = startPt;
            base.LineColor = lineColor;
            base.LineWidth = lineWidth;
        }
		#endregion

		#region methods
		public override void Deserialize(string record)
        {
            throw new NotImplementedException();
        }
        public override void Draw(Graphics g)
		{
			using (Pen pen = new Pen(LineColor, LineWidth))
			{
				g.DrawLine(pen, startPt, endPt);
			}
		}
		public override string Serialize()
        {
            throw new NotImplementedException();
        }
		#endregion
	}
}

