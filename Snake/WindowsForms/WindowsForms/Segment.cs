using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    abstract class Segment
    {
        private int _x;
        private int _y;
        private int _radius;
        private Color _color;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Color Color
        {
            get
            {
                return _color;
            }
            private set
            {
                _color = value;
            }
        }
        public override string ToString()
        {
            return $"Segment: X {X}; Y {Y}; Radius {Radius}; Color {Color};";
        }
        public Segment()
        {
            X = 100;
            Y = 100;
            Radius = 5;
            Color = Color.Red;
        }
        public Segment(int x, int y, int radius, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
        }
    }
}
