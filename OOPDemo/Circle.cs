using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRelationsDemo
{
    // "IS"
    class Circle : Point
    {
        public Circle(int x, int y, int r)
            : base(x, y)
        {
            _r = r;
        }

        ~Circle()
        {
            Console.WriteLine("~Circle()");
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", base.ToString(), _r);
        }

        private int _r;
    }
}
