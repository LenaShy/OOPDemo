using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRelationsDemo
{
    class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        ~Point()
        {
            Console.WriteLine("~Point()");        
        }

        public Point(Point source)
        {
            _x = source._x;
            _y = source._y;
        }

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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Point pOther = (Point)obj;

            return (_x == pOther._x) && (_y == pOther._y);
            //return _x.Equals(pOther._x) && _y.Equals(pOther._y);
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", _x, _y);
        }

        private int _x;
        private int _y;
    }
}
