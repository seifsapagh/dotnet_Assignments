using System;
namespace Day04
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    /*
        Commented out Because Property initializer can't be used with Constructor overloading,
        because this causes ambiguity and the compiler doesn't know which Consutrctor i want to call
        public Point(int num = 0)
            {
                X = num;
                Y = num;
            }
        */


        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    // Aggregation : parent(Line, Cirvle, Triangle) can exist independantly of the child (Point)

    public class Line(Point p1 , Point p2 )
    {
        public Point P1 { get; set; } = p1;
        public Point P2 { get; set; } = p2;
        public override string ToString()
        {
            return $"{P1} - {P2}";
        }
    }

    public class Tri(Point p1 , Point p2 , Point p3 )
    {
        public Point P1 { get; set; } = p1;
        public Point P2 { get; set; } = p2;
        public Point P3 { get; set; } = p3;
        public override string ToString()
        {
            return $"{P1} - {P2} - {P3}";
        }
    }

    public class Circle(Point center , int radius = 0)
    {
        public int Radius { get; set; } = radius;
        public Point Center { get; set; } = center;
    }

    // Composition : parent(Rectanle) are Dependant of the child (Point) 
     
    
    public class Rect
    {
        public Point UpperLeft { get; private set; }
        public Point LowerRight{ get; private set; }

        public Rect(int x1,int y1, int x2, int y2)
        {
            UpperLeft  = new Point(x1,y1);
            LowerRight = new Point(x2,y2);
        }
        public override string ToString()
        {
            return $"UpperLeftPoint: {UpperLeft} - LowerRightPoint: {LowerRight} ";     
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Trying Aggregation
            Tri triangle = new(new Point(5, 10), new Point(9, 11), new Point(9, 8));
            Console.WriteLine(triangle);

            Line l = new(new Point(5, 10), new Point(9, 8));
            Console.WriteLine(l);

            // Trying Composition
            Rect rectangle = new(0, 5, 5, 0);
            Console.WriteLine(rectangle);


            // Create Object with Property Initializer

            // Point p1 = new Point{ 5, 7 }; // this results in an ERROR, u need to specify the name of the property like in named Parameters
            Point p1 = new(){ X = 5, Y = 7 }; // this doesn't work if Constructor overloading is used 
        }
    }
}