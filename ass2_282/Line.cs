using System.Drawing;

namespace DrawLines

{
    class Line
    {
        private Point _point1;
        private Point _point2;
        private Color _lineColor = Color.Black;

        public Line(Point point1, Point point2, Color lineColor)
        {
            this._point1 = point1;
            this._point2 = point2;
            this._lineColor = lineColor;
        }

        public Point Point1
        {
            get { return _point1; }
            set { _point1 = value; }
        }

        public Point Point2
        {
            get { return _point2; }
            set { _point2 = value; }
        }

        public Color LineColor
        {
            get { return _lineColor; }
            set { _lineColor = value; }
        }

        public override string ToString()
        {
            return $"First point: (X={_point1.X}, Y={_point1.Y}), Second point: (X={_point2.X}, Y={_point2.Y})";
        }
    }
}