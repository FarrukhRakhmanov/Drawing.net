namespace Drawing.net
{
    partial class DrawingMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingMainForm));
			toolStripDrawing = new ToolStrip();
			toolStripButtonNewFile = new ToolStripButton();
			toolStripButtonOpenFile = new ToolStripButton();
			toolStripButtonSaveFile = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonDrawLine = new ToolStripButton();
			toolStripButtonPolyLine = new ToolStripButton();
			toolStripButtonEllipse = new ToolStripButton();
			toolStripButtonSquare = new ToolStripButton();
			toolStripButtonPolygon = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripButtonColorPicker = new ToolStripButton();
			toolStripComboBoxLineWidth = new ToolStripComboBox();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabelDrawingTool = new ToolStripStatusLabel();
			toolStripStatusLabelColor = new ToolStripStatusLabel();
			toolStripStatusLabelLineWidth = new ToolStripStatusLabel();
			panelDrawing = new Panel();
			colorDialogDrawing = new ColorDialog();
			toolStripDrawing.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStripDrawing
			// 
			toolStripDrawing.ImageScalingSize = new Size(32, 32);
			toolStripDrawing.Items.AddRange(new ToolStripItem[] { toolStripButtonNewFile, toolStripButtonOpenFile, toolStripButtonSaveFile, toolStripSeparator1, toolStripButtonDrawLine, toolStripButtonPolyLine, toolStripButtonEllipse, toolStripButtonSquare, toolStripButtonPolygon, toolStripSeparator2, toolStripButtonColorPicker, toolStripComboBoxLineWidth });
			toolStripDrawing.Location = new Point(0, 0);
			toolStripDrawing.Name = "toolStripDrawing";
			toolStripDrawing.Size = new Size(1311, 41);
			toolStripDrawing.TabIndex = 0;
			toolStripDrawing.Text = "toolStripDrawing";
			// 
			// toolStripButtonNewFile
			// 
			toolStripButtonNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonNewFile.Image = (Image)resources.GetObject("toolStripButtonNewFile.Image");
			toolStripButtonNewFile.ImageTransparentColor = Color.Magenta;
			toolStripButtonNewFile.Name = "toolStripButtonNewFile";
			toolStripButtonNewFile.Size = new Size(36, 36);
			toolStripButtonNewFile.Text = "toolStripButton1";
			// 
			// toolStripButtonOpenFile
			// 
			toolStripButtonOpenFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonOpenFile.Image = (Image)resources.GetObject("toolStripButtonOpenFile.Image");
			toolStripButtonOpenFile.ImageTransparentColor = Color.Magenta;
			toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
			toolStripButtonOpenFile.Size = new Size(36, 36);
			toolStripButtonOpenFile.Text = "toolStripButton1";
			// 
			// toolStripButtonSaveFile
			// 
			toolStripButtonSaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSaveFile.Image = (Image)resources.GetObject("toolStripButtonSaveFile.Image");
			toolStripButtonSaveFile.ImageTransparentColor = Color.Magenta;
			toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
			toolStripButtonSaveFile.Size = new Size(36, 36);
			toolStripButtonSaveFile.Text = "toolStripButton1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 41);
			// 
			// toolStripButtonDrawLine
			// 
			toolStripButtonDrawLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonDrawLine.Image = (Image)resources.GetObject("toolStripButtonDrawLine.Image");
			toolStripButtonDrawLine.ImageTransparentColor = Color.Magenta;
			toolStripButtonDrawLine.Name = "toolStripButtonDrawLine";
			toolStripButtonDrawLine.Size = new Size(36, 36);
			toolStripButtonDrawLine.Text = "Line";
			toolStripButtonDrawLine.Click += toolStripButtonDrawLine_Click;
			// 
			// toolStripButtonPolyLine
			// 
			toolStripButtonPolyLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonPolyLine.Image = (Image)resources.GetObject("toolStripButtonPolyLine.Image");
			toolStripButtonPolyLine.ImageTransparentColor = Color.Magenta;
			toolStripButtonPolyLine.Name = "toolStripButtonPolyLine";
			toolStripButtonPolyLine.Size = new Size(36, 36);
			toolStripButtonPolyLine.Text = "Polyline";
			toolStripButtonPolyLine.Click += toolStripButtonPolyLine_Click;
			// 
			// toolStripButtonEllipse
			// 
			toolStripButtonEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonEllipse.Image = (Image)resources.GetObject("toolStripButtonEllipse.Image");
			toolStripButtonEllipse.ImageTransparentColor = Color.Magenta;
			toolStripButtonEllipse.Name = "toolStripButtonEllipse";
			toolStripButtonEllipse.Size = new Size(36, 36);
			toolStripButtonEllipse.Text = "Ellipse";
			toolStripButtonEllipse.Click += toolStripButtonEllipse_Click;
			// 
			// toolStripButtonSquare
			// 
			toolStripButtonSquare.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSquare.Image = (Image)resources.GetObject("toolStripButtonSquare.Image");
			toolStripButtonSquare.ImageTransparentColor = Color.Magenta;
			toolStripButtonSquare.Name = "toolStripButtonSquare";
			toolStripButtonSquare.Size = new Size(36, 36);
			toolStripButtonSquare.Text = "Rectangle";
			toolStripButtonSquare.Click += toolStripButtonSquare_Click;
			// 
			// toolStripButtonPolygon
			// 
			toolStripButtonPolygon.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonPolygon.Image = (Image)resources.GetObject("toolStripButtonPolygon.Image");
			toolStripButtonPolygon.ImageTransparentColor = Color.Magenta;
			toolStripButtonPolygon.Name = "toolStripButtonPolygon";
			toolStripButtonPolygon.Size = new Size(36, 36);
			toolStripButtonPolygon.Text = "Polygon";
			toolStripButtonPolygon.Click += toolStripButtonPolygon_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 41);
			// 
			// toolStripButtonColorPicker
			// 
			toolStripButtonColorPicker.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonColorPicker.Image = (Image)resources.GetObject("toolStripButtonColorPicker.Image");
			toolStripButtonColorPicker.ImageTransparentColor = Color.Magenta;
			toolStripButtonColorPicker.Name = "toolStripButtonColorPicker";
			toolStripButtonColorPicker.Size = new Size(36, 36);
			toolStripButtonColorPicker.Text = "toolStripButton1";
			toolStripButtonColorPicker.Click += toolStripButtonColorPicker_Click;
			// 
			// toolStripComboBoxLineWidth
			// 
			toolStripComboBoxLineWidth.Items.AddRange(new object[] { "1 px", "2 px", "3 px", "4 px", "5 px", "6 px", "7 px", "8 px", "9 px", "10 px", "15 px", "20 px" });
			toolStripComboBoxLineWidth.Name = "toolStripComboBoxLineWidth";
			toolStripComboBoxLineWidth.Size = new Size(94, 41);
			toolStripComboBoxLineWidth.Text = "Width";
			toolStripComboBoxLineWidth.SelectedIndexChanged += toolStripComboBoxLineWidth_SelectedIndexChanged;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(32, 32);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelDrawingTool, toolStripStatusLabelColor, toolStripStatusLabelLineWidth });
			statusStrip1.Location = new Point(0, 525);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new Padding(1, 0, 11, 0);
			statusStrip1.Size = new Size(1311, 42);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStripDrawing";
			// 
			// toolStripStatusLabelDrawingTool
			// 
			toolStripStatusLabelDrawingTool.AutoSize = false;
			toolStripStatusLabelDrawingTool.Name = "toolStripStatusLabelDrawingTool";
			toolStripStatusLabelDrawingTool.Size = new Size(250, 35);
			toolStripStatusLabelDrawingTool.Text = "Drawing";
			// 
			// toolStripStatusLabelColor
			// 
			toolStripStatusLabelColor.AutoSize = false;
			toolStripStatusLabelColor.BackColor = Color.Red;
			toolStripStatusLabelColor.Name = "toolStripStatusLabelColor";
			toolStripStatusLabelColor.Size = new Size(250, 35);
			toolStripStatusLabelColor.Text = "Color (Red)";
			// 
			// toolStripStatusLabelLineWidth
			// 
			toolStripStatusLabelLineWidth.AutoSize = false;
			toolStripStatusLabelLineWidth.Name = "toolStripStatusLabelLineWidth";
			toolStripStatusLabelLineWidth.Size = new Size(250, 35);
			// 
			// panelDrawing
			// 
			panelDrawing.Dock = DockStyle.Fill;
			panelDrawing.Location = new Point(0, 41);
			panelDrawing.Margin = new Padding(2);
			panelDrawing.Name = "panelDrawing";
			panelDrawing.Size = new Size(1311, 484);
			panelDrawing.TabIndex = 2;
			panelDrawing.Paint += panelDrawing_Paint;
			panelDrawing.MouseDoubleClick += panelDrawing_MouseDoubleClick;
			panelDrawing.MouseDown += panelDrawing_MouseDown;
			panelDrawing.MouseMove += panelDrawing_MouseMove;
			panelDrawing.MouseUp += panelDrawing_MouseUp;
			// 
			// DrawingMainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1311, 567);
			Controls.Add(panelDrawing);
			Controls.Add(statusStrip1);
			Controls.Add(toolStripDrawing);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			Name = "DrawingMainForm";
			Text = "Drawing.net";
			toolStripDrawing.ResumeLayout(false);
			toolStripDrawing.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStripDrawing;
        private ToolStripButton toolStripButtonDrawLine;
        private ToolStripComboBox toolStripComboBoxLineWidth;
        private ToolStripButton toolStripButtonSquare;
        private ToolStripButton toolStripButtonNewFile;
        private ToolStripButton toolStripButtonOpenFile;
        private ToolStripButton toolStripButtonEllipse;
        private ToolStripButton toolStripButtonColorPicker;
        private ToolStripButton toolStripButtonPolygon;
        private ToolStripButton toolStripButtonSaveFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonPolyLine;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelDrawingTool;
        private ToolStripStatusLabel toolStripStatusLabelColor;
        private ToolStripStatusLabel toolStripStatusLabelLineWidth;
        private Panel panelDrawing;
        private ColorDialog colorDialogDrawing;
    }
}
