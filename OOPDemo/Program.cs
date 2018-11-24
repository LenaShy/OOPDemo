using System;

namespace OOPRelationsDemo
{
    class Program
    {
        const int DEFAULT_POINTS_COUNT = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // PointsDemo();

            //LineDemo();

            Circle c = new Circle(12, 14, 5);

            Console.WriteLine(c);

            Console.ReadKey();
        }

        private static void LineDemo()
        {
            Line l = new Line(2, 3, 4, 5);

            Console.WriteLine(l);

            //Point p1 = l.StartPoint;
            // Point p1 = l.GetPointByIndex(0);
            Point p1 = l[0];
            p1.X = 22;
            p1.Y = 33;


            // Point p2 = l.FinishPoint;
            Point p2 = l[1];
            p2.X = 44;
            p2.Y = 55;

            bool fEq = l[new Point(4, 5)];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(l);
        }

        private static void PointsDemo()
        {
            Point p1 = new Point(3, 6);

            Console.WriteLine(p1);

            Point p2 = new Point(23, 16);

            Point p3 = new Point(33, 16);

            Console.WriteLine(p2);

            p2.X = 33;

            Console.WriteLine(p2);

            // Point - reference type
            // nulls - by default
            Point[] points = new Point[DEFAULT_POINTS_COUNT];

            points[0] = p1;
            points[1] = p2;
            points[2] = new Point(3, 6);
            points[1] = p2;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == null)
                {
                    continue;
                }
                Console.WriteLine("[{0}] : {1}", i, points[i]);
            }

            int searchResultIndex = Array.IndexOf(points, p3);
            Console.WriteLine("First index of {0} : {1}", p3, searchResultIndex);

            Point searchedPoint = new Point(3, 6);
            int searchResultLastIndex = Array.LastIndexOf(points, searchedPoint);
            Console.WriteLine("last index of {0} : {1}", searchedPoint, searchResultLastIndex);
        }
    }
}
