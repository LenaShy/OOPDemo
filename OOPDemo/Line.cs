using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRelationsDemo
{
    class Line
    {
        public Line(int xStart, int yStart, int xFinish, int yFinish)
        {
            _pStart = new Point(xStart, yStart);
            _pFinish = new Point(xFinish, yFinish);
        }

        public Line(Point start, Point finish)
            : this(start.X, start.Y, finish.X, finish.Y)
        {
            //_pStart = new Point(start);
            //_pFinish = new Point(finish);
        }

        //// создание копий точек + дополнительный вызов конструктора
        //public Line(Line source)
        //    : this(source.StartPoint, source.FinishPoint)
        //{
        //}

        public Line(Line source)
            : this(source._pStart.X, source._pStart.Y, 
                  source._pFinish.X, source._pFinish.Y)
        {

        }

        // дополнительный вызов конструктора
        //public Line(Line source)
        //    : this(source._pStart, source._pFinish)
        //{

        //}


        public Point StartPoint
        {
            get
            {
                // return _pStart;    // !!! error, copy reference !!!
                return new Point(_pStart);    // copy object point
            }
        }

        public Point FinishPoint
        {
            get
            {
                return new Point(_pFinish);
            }
        }


        #region INDEXATORS

        public Point GetPointByIndex(int index)
        {
            Point pResult = null;

            switch (index)
            {
                case 0:
                    pResult = StartPoint;
                    break;
                case 1:
                    pResult = FinishPoint;
                    break;
            }

            return pResult;
        }

        public Point this[int index]
        {
            get
            {
                Point pResult = null;

                switch (index)
                {
                    case 0:
                        pResult = StartPoint;
                        break;
                    case 1:
                        pResult = FinishPoint;
                        break;
                }

                return pResult;
            }
        }

        public bool this[Point source]
        {
            get
            {
                return (_pStart.Equals(source)) || (_pFinish.Equals(source));
            }
        }

        #endregion


        public override string ToString()
        {
            return string.Format("{0}-{1}", _pStart, _pFinish);
        }

        // !!! agregation: один класс является полем другого класса
        // "has", "part of"
        private Point _pStart;
        private Point _pFinish;
    }
}
