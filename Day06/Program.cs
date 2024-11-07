/*
Problem Statement

1. 3D Points
    1. Design 3D Point Class and Include the basic Constructor(s) [ 

    2. Override the ToString Function to produce this output 
        Point3D P = new Point3D(10,10,10);
        Console.WriteLine(Point3D.ToString());
        - Point Coordinates:   (10, 10, 10)
    Try to Cast Point3D to string type

    3. Read from the User the Coordinates for 2 point P1, P2
    (Check the input, tryPares ,  Parse , Convert )
        3.1 Try Array of Three Points Read and Write

2. Math
    4. Write a program with a Math class that has four methods: Add, Subtract, Multiply, and Divide, each of which takes two parameters. Call each method from Main ( ).
    5. Modify the program from Exercise 4 so that you do not have to create an instance of Math to call the four methods

3. Duration

    5. Define Class Duration

    To include Three Attributes (Hours, Minutes, Seconds)

    Override All System.Object Members ( ToString, Equals,GetHasCode) .

    Override Equals to Work as Value Equality

    Output from ToString Should follow this pattern 
    Hours: 1, Minutes :30, Seconds :20

    Support All Required Constructors to Produce this output 

    Duration D1 =new Duration (1,10,15);
    D.ToString(); 
    Output: Hours: 1, Minutes :10 , Seconds :15

    Duration D1 =new Duration (3600);
    D.ToString(); 
    Output: Hours: 1, Minutes :0 , Seconds :0

    Duration D2 =new Duration (7800);
    D.ToString(); 
    Output: Hours: 2, Minutes :10 , Seconds :0

    Duration D3 =new Duration (666);
    D.ToString(); 
    Output: Minutes :11 , Seconds :6

    Implement All required Operators overloading’s to enable this Code

    D3=D1+D2
    D3=D1 + 7800
    D3=666+D3
    D3=D1++ (Increase One Minute)
    D3 =--D2; (Decrease One Minute)
    If ( D1>D2);
    If ( D1<=D2);
*/


using System;
using M = Day06.math;
namespace Day06
{
    public class Program
    {

        public static void Run3D()
        {
            Console.WriteLine("\t3D Points:--");
            // A 3d coordinates 
            Point3D P = new(50, 90, 100);
            Console.WriteLine($"{P}");

            Point3D[] points = new Point3D[3]; // initialize pts arr of size 3

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point3D(); // Write pts array
                Console.WriteLine("\t---");
            }

            points[0].X = int.MinValue; // Update pts array

            Console.WriteLine($"First Point X Coordinate has been changed into {int.MinValue}");
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]); // Read pts array
            }

        }

        public static void RunMath()
        {
            int num1 = 10;
            int num2 = 5;

            Math m = new();
            Console.WriteLine($"Testing Math Class:\n\t num1 = {num1}, num2 = {num2}");
            Console.WriteLine($"{"Addition",-20} {m.Add(num1, num2)}");
            Console.WriteLine($"{"Subtraction",-20} {m.Subtract(num1, num2)}");
            Console.WriteLine($"{"Multiplication",-20} {m.Multiply(num1, num2)}");
            Console.WriteLine($"{"Division",-20} {m.Divide(num1, num2)}");

            Console.WriteLine("\tUser Input");
            int n1, n2;

            Console.Write("number 1 :");
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Please Enter A Valid number");
            }

            Console.Write("number 2 :");
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Please Enter A Valid number");
            }

            Console.WriteLine(M.Add(n1, n2));
            Console.WriteLine(M.Subtract(n1, n2));
            Console.WriteLine(M.Multiply(n1, n2));
            Console.WriteLine(M.Divide(n1, n2));
        }

        public static void RunDuration()
        {
            // Time Display
            Console.WriteLine($"Input (5) => {new Duration(5)}"); // Seconds Only

            Console.WriteLine($"Input (60) => {new Duration(60)}"); // Minutes Only
            Console.WriteLine($"Input (65) => {new Duration(65)}"); // Miutes + Seconds

            Console.WriteLine($"Input (3600) =>{new Duration(3600)}"); // Hours Only
            Console.WriteLine($"Input (3660) =>{new Duration(3660)}"); // Hours + Minutes
            Console.WriteLine($"Input (3605) =>{new Duration(3605)}"); // Hours + Seconds
            Console.WriteLine($"Input (3665) =>{new Duration(3665)}"); // Full Time

            Console.WriteLine();
            // Duration objects Operations
            Duration d1 = new(1, 30, 5);
            Duration d2 = new(m: 30, s: 55);

            Console.WriteLine(d1 + d2);
            Console.WriteLine(d2 + 5);

            Console.WriteLine(d1 > d2);
            Console.WriteLine(d1 <= (d2 + new Duration(h: 1) - new Duration(50)));

            Console.WriteLine(--d1);
            Console.WriteLine(++d2);

        }

        public static void Main()
        {
            Run3D();
            Console.WriteLine();
            RunMath();
            Console.WriteLine();
            RunDuration();  

        }
    }
}

