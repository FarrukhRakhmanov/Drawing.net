using GraphicLibrary;
using GraphicObjectManagers;

namespace Drawing.net
{
	public partial class DrawingMainForm : Form
	{
		public enum DrawingMode
		{
			None,
			Line,
			PolyLine,
			Circle,
			Ellipse,
			Rectangle,
			Polygon
		}

		private DrawingMode drawingMode;
		private bool isMouseDown = false;
		private GraphicShape? shape = null;
		private Color shapeColor = Color.Red;
		private float lineWidth = 2.0f;

		private GraphicObjectManager graphicObjectManager = new GraphicObjectManager();

		public DrawingMainForm()
		{
			InitializeComponent();
			ClearButtonCheckedState();

			// Default lineWith to 2 px
			this.toolStripComboBoxLineWidth.SelectedIndex = 1;
			this.toolStripStatusLabelColor.Text = shapeColor.ToString();
			this.toolStripStatusLabelColor.BackColor = shapeColor;
			this.toolStripStatusLabelDrawingTool.Text = "";
		}
		private void toolStripButtonColorPicker_Click(object sender, EventArgs e)
		{
			if (this.colorDialogDrawing.ShowDialog() == DialogResult.OK)
			{
				this.shapeColor = this.colorDialogDrawing.Color;

				this.toolStripStatusLabelColor.BackColor = this.shapeColor;
				this.toolStripStatusLabelColor.Text = this.shapeColor.ToString();
				this.CreateNewDrawingObject();
			}
		}

		private void ClearButtonCheckedState()
		{
			this.toolStripButtonDrawLine.Checked = false;
			this.toolStripButtonPolyLine.Checked = false;
			this.toolStripButtonEllipse.Checked = false;
			this.toolStripButtonSquare.Checked = false;
			this.toolStripButtonPolygon.Checked = false;
		}

		private void toolStripComboBoxLineWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.lineWidth = float.Parse(this.toolStripComboBoxLineWidth.Text.Substring(0, toolStripComboBoxLineWidth.Text.Length - 3));
			this.toolStripStatusLabelLineWidth.Text = "Line Width: " +
			this.toolStripComboBoxLineWidth.Text;

		}

		private void CreateNewDrawingObject()
		{
			switch (drawingMode)
			{
				case DrawingMode.Line:
					shape = new GraphicLine(shapeColor, lineWidth);
					break;
				case DrawingMode.PolyLine:
					shape = new GraphicPolyline(shapeColor, lineWidth);
					break;
				case DrawingMode.Polygon:
					shape = new GraphicPolygon(shapeColor, lineWidth);
					break;
				case DrawingMode.Rectangle:
					shape = new GraphicRectangle(shapeColor, lineWidth);
					break;
				case DrawingMode.Ellipse:
					shape = new GraphicEllipse(shapeColor, lineWidth);
					break;
			}
		}

		private void panelDrawing_Paint(object sender, PaintEventArgs e)
		{
			if (graphicObjectManager.GraphicShapes.Count > 0)
			{
				foreach (GraphicShape shape in graphicObjectManager.GraphicShapes)
				{
					shape.Draw(e.Graphics);
				}
			}

			if (!isMouseDown)
			{
				return;
			}
			if (shape != null)
			{
				shape.Draw(e.Graphics);
			}
		}
		private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
		{
			isMouseDown = true;

			if (shape != null)
			{
				switch (drawingMode)
				{
					case DrawingMode.Line:
						((GraphicLine)shape).StartPt = e.Location;
						break;
					case DrawingMode.Polygon:
						((GraphicPolygon)shape).AddPoint(e.Location);
						break;
					case DrawingMode.PolyLine:
						((GraphicPolyline)shape).AddPoint(e.Location);
						break;
					case DrawingMode.Rectangle:
						((GraphicRectangle)shape).TopLeft = e.Location;
						break;
					case DrawingMode.Ellipse:
						((GraphicEllipse)shape).TopLeft = e.Location;
						break;
				}
			}
		}

		private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
		{
			if (isMouseDown == true)
			{
				if (shape != null)
				{
					switch (drawingMode)
					{
						case DrawingMode.Line:
							((GraphicLine)shape).EndPt = e.Location;
							graphicObjectManager.GraphicShapes.Add(shape);
							isMouseDown = false;
							CreateNewDrawingObject();
							break;
						case DrawingMode.PolyLine:
							((GraphicPolyline)shape).AddPoint(e.Location);
							break;
						case DrawingMode.Polygon:
							((GraphicPolygon)shape).AddPoint(e.Location);
							break;
						case DrawingMode.Rectangle:
							((GraphicRectangle)shape).BottomRight = e.Location;
							graphicObjectManager.GraphicShapes.Add(shape);
							isMouseDown = false;
							CreateNewDrawingObject();
							break;
						case DrawingMode.Ellipse:
							((GraphicEllipse)shape).BottomRight = e.Location;
							graphicObjectManager.GraphicShapes.Add(shape);
							isMouseDown = false;
							CreateNewDrawingObject();
							break;
					}
					panelDrawing.Refresh();
				}
			}
		}

		private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
		{
			if (!isMouseDown)
			{
				return;
			}
			if (shape != null)
			{
				switch (drawingMode)
				{
					case DrawingMode.Line:
						((GraphicLine)shape).EndPt = e.Location;
						break;
					case DrawingMode.PolyLine:
						((GraphicPolyline)shape).ReplacePoint(e.Location);
						break;
					case DrawingMode.Polygon:
						((GraphicPolygon)shape).ReplacePoint(e.Location);
						break;
					case DrawingMode.Rectangle:
						((GraphicRectangle)shape).BottomRight = e.Location;
						break;
					case DrawingMode.Ellipse:
						((GraphicEllipse)shape).BottomRight = e.Location;
						break;
				}

				panelDrawing.Refresh();
			}
		}

		private void panelDrawing_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (isMouseDown == true) // This Block Is Not Execute Until Mouse Down Event Is Not a Fire.
			{
				if (shape != null)
				{
					switch (drawingMode)
					{
						case DrawingMode.PolyLine:
							// For drawing polyline, mouse up means adding this point 
							// to the polyline object
							((GraphicPolyline)shape).AddPoint(e.Location);

							graphicObjectManager.AddGraphicShape(shape);
							isMouseDown = false; // false this..

							//Need to recreate object based on currently select tool
							CreateNewDrawingObject();
							break;

						case DrawingMode.Polygon:
							// For drawing polygon, mouse up means adding this point 
							// to the polygon object
							((GraphicPolygon)shape).AddPoint(e.Location);

							graphicObjectManager.AddGraphicShape(shape);
							isMouseDown = false; // false this..

							//Need to recreate object based on currently select tool
							CreateNewDrawingObject();
							break;
					}

					panelDrawing.Refresh();
				}
			}
		}
		private void toolStripButtonDrawLine_Click(object sender, EventArgs e)
		{
			ClearButtonCheckedState();
			toolStripButtonDrawLine.Checked = true;

			toolStripStatusLabelDrawingTool.Text = "Drawing Line";

			drawingMode = DrawingMode.Line;

			shape = new GraphicLine();
		}

		private void toolStripButtonPolyLine_Click(object sender, EventArgs e)
		{
			ClearButtonCheckedState();
			toolStripButtonPolyLine.Checked = true;
			drawingMode = DrawingMode.PolyLine;
			this.toolStripStatusLabelDrawingTool.Text = "Drawing Polyline";
			CreateNewDrawingObject();
		}

		private void toolStripButtonEllipse_Click(object sender, EventArgs e)
		{
			ClearButtonCheckedState();
			toolStripButtonEllipse.Checked = true;

			drawingMode = DrawingMode.Ellipse;

			this.toolStripStatusLabelDrawingTool.Text = "Drawing Ellipse";

			CreateNewDrawingObject();
		}


		private void toolStripButtonSquare_Click(object sender, EventArgs e)
		{
			ClearButtonCheckedState();
			toolStripButtonSquare.Checked = true;

			drawingMode = DrawingMode.Rectangle;

			this.toolStripStatusLabelDrawingTool.Text = "Drawing Rectangle";

			CreateNewDrawingObject();
		}

		private void toolStripButtonPolygon_Click(object sender, EventArgs e)
		{
			ClearButtonCheckedState();
			this.toolStripButtonPolygon.Checked = true;
			drawingMode = DrawingMode.Polygon;
			this.toolStripStatusLabelDrawingTool.Text = "Drawing Polygon";
			CreateNewDrawingObject();
		}
	}
}

