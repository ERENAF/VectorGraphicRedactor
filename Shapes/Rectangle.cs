using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicRedactor.Shapes
{
    internal class Rectangle: Shape
    {
        public Rectangle(PointF pos,float transperancy, 
            Color fillColor, Color strokeColor, float strokeWidth,
            float width, float height, bool isSelected) 
        { 
            Id = Guid.NewGuid();
            Position = pos;
            FillColor = fillColor;
            StrokeColor = strokeColor;
            Width = width;
            Height = height;
            IsSelected = isSelected;
        }

        public override void Move(float deltaX, float deltaY)
        {
            Position = new PointF(Position.X+deltaX, Position.Y+deltaY);
        }
        public override bool Contains(Point point)
        {
            var bounds = GetBounds();
            return bounds.Contains(point);
        }
        public override RectangleF GetBounds()
        {
            return new RectangleF(Position.X, Position.Y, Width, Height);
        }
        public override void Draw(Graphics g)
        {
            using (var brush = CreateBrush())
            using (var pen = CreatePen())
            {
                var bounds = GetBounds();
                g.FillRectangle(brush, bounds);
                g.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width,bounds.Height);
            }
        }
    }
}
  