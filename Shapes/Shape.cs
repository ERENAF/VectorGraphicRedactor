using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace VectorGraphicRedactor.Shapes
{
    public abstract class Shape
    {
        public Guid Id { get; set; }
        private PointF _pos;
        private float _rotation;
        private float _scale = 1.0f;
        private Color _fillColor;
        private Color _strokeColor;
        private float _strokeWidth;
        public bool IsSelected { get; set; }

        public Shape(PointF position, float rotation, float scale, Color fillColor, Color strokeColor, float strokewidth,bool isSelected = false)
        {
            Id = Guid.NewGuid();
            Position = position;
            Rotation = rotation;
            Scale = scale;
            Rotation = rotation;
            FillColor = fillColor;
            StrokeColor = strokeColor;
            StrokeWidth = strokewidth;
            IsSelected = isSelected;
        }
        private PointF Position
        {
            get => _pos;
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("position is missing");
                }
                _pos = value;
            }
        }
        private float Rotation
        {
            get => _rotation;
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("rotation is missing");

                }
                _rotation = value;
            }
        }
        public float Scale
        {
            get => _scale;
            set
            {
                if (value < 0.0f)
                {
                    throw new InvalidOperationException("scale is negative number");
                }
                if (value == null)
                {
                    throw new InvalidOperationException("scale is missing");
                }
                _scale = value;
            }
        }

        public Color FillColor
        {
            get => _fillColor;
            set
            {
                if (value == null)
                {

                    throw new InvalidOperationException("fillcolor is missing");
                }
                _fillColor = value;
            }
        }
        public Color StrokeColor
        {
            get => _strokeColor;
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("strokecolor is missing");
                }
                _strokeColor = value;
            }
        }

        public float StrokeWidth
        {
            get => _strokeWidth;
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("strokewidth is missing");
                }
                if (value < 0)
                {
                    throw new InvalidOperationException("strokewidth is negative number");
                }
                _strokeWidth = value; 
            }
        }


        public abstract bool Contains(PointF point);
        public abstract void Draw(Graphics g);
    }
}
