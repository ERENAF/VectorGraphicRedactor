using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

namespace VectorGraphicRedactor.Shapes
{
    public abstract class Shape
    {
        public Guid Id { get; set; }
        private PointF _position;
        private float _transperancy;
        private Color _fillColor;
        private Color _strokeColor;
        private float _strokeWidth;
        private float _width;
        private float _height;
        private bool _isSelected;

        public PointF Position
        {
            get => _position; 
            set => _position = value;
        }
        public float Transperancy
        {
            get => _transperancy;
            set
            {
                if (value < 0 ||  value > 100)
                {
                    throw new InvalidOperationException("value has to be from 0 to 100");
                }
                _transperancy = value;
            }
        }
        public Color FillColor
        {
            get => _fillColor;
            set => _fillColor = value;
        }
        
        public Color StrokeColor
        {
            get => _strokeColor;
            set => _strokeColor = value;
        }
        public float StrokeWidth
        {
            get => _strokeWidth;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("value is negative!");
                }
                _strokeWidth = value;
            }
        }
        public float Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("value is negative!");
                }
                _width = value;
            }
        }
        public float Height
        {
            get => _height;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("value is negative!");
                }
                _height = value;
            }
        }
        public bool IsSelected
        {
            get => _isSelected;
            set => _isSelected = value;
        }
        public abstract void Move(float deltaX, float deltaY);
        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point point);
        public abstract RectangleF GetBounds();
        
        protected Color ApplyTransp(Color color){ return Color.FromArgb((int)(Transperancy*255), color); }
        protected Pen CreatePen()
        {
            var pen = new Pen(ApplyTransp(StrokeColor), StrokeWidth);
            if (IsSelected)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.Color = Color.Red;
            }
            return pen;
        }
        protected Brush CreateBrush()
        {
            return new SolidBrush(ApplyTransp(FillColor));
        }
    }
}
