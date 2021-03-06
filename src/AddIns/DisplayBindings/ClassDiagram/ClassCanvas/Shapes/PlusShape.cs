﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ClassDiagram
{
	public class PlusShape : SmallButtonShape
	{
		static PointF[] plusPoints = new PointF[]{
			new PointF(4.0f, 2.0f),
			new PointF(6.0f, 2.0f),
			new PointF(6.0f, 4.0f),
			new PointF(8.0f, 4.0f),
			new PointF(8.0f, 6.0f),
			new PointF(6.0f, 6.0f),
			new PointF(6.0f, 8.0f),
			new PointF(4.0f, 8.0f),
			new PointF(4.0f, 6.0f),
			new PointF(2.0f, 6.0f),
			new PointF(2.0f, 4.0f),
			new PointF(4.0f, 4.0f)
		};
		
		static Pen stroke = Pens.Black;
		static Brush fill = Brushes.White;
		
		public override void Draw(Graphics graphics)
		{
			if (graphics == null) return;
			base.Draw(graphics);
			graphics.FillPolygon (fill , plusPoints);
			graphics.DrawPolygon (stroke, plusPoints);
		}
	}
}
