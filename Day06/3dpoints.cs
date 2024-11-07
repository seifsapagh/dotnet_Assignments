using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{ 
    public class Point3D
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int Z { set; get; }

        public Point3D(int p1, int p2, int p3)
        {
            X = p1;
            Y = p2;
            Z = p3;
        }
        public Point3D()
        {
            int temp;
            Console.Write("point 1: ");
            while (!(int.TryParse(Console.ReadLine(), out temp)))
            {
                Console.WriteLine("Please Enter a valid number for point 1");
            }
            X = temp;

            Console.Write("point 2: ");
            bool converted = false;
            do
            {
                try
                {

                    Y = int.Parse(Console.ReadLine());
                    converted = true;
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number for point 2");
                }

            } while (!converted);


            Console.Write("point 3: ");
            converted = false;
            do
            {
                try
                {

                    Z = Convert.ToInt32(Console.ReadLine());
                    if (Z == 0)
                    {
                        Console.WriteLine("Are you sure you want to set the 3rd point as 0(y/n)");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            converted = true;
                        }
                        else
                        {
                            converted = false;


                        }
                    }
                    else
                    {
                        converted = true;
                    }

                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number for point 3");
                }

            } while (!converted);
        }

        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        public static explicit operator string(Point3D shape)
        {
            return shape.ToString();
        }
      


    }
}
