using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day05
{
    internal class GeoShape
    {
        protected double Dim1 { get; set; }
        protected double Dim2 { get; set; }
        public GeoShape()
        {
            Dim1=Dim2 = 0;
            Console.WriteLine("GeoShape Default Constructor");
        }
        public GeoShape(double dim1, double dim2)
        {
            Dim1 = dim1; Dim2 = dim2;
            Console.WriteLine("GeoShape Constructor");
        }   
        public virtual string Print()
        {
            return $"{Dim1},{Dim2}";
        }
    }

    /*You can't have a parent be less accessible than their child*/
    /*public class Rect: Geoshape, won't work cuz geo is internal*/
    class Rect: GeoShape
    {
        public Rect(double d1, double d2) : base(d1,d2) 
        {
            Dim1 = d1;Dim2 = d2;
            Console.WriteLine("Rectangle constructor!");
        }

        public double CArea()
        {
            return Dim1 * Dim2;
        }
    }

    class Square : GeoShape
    {
        public Square(double d1, double d2) : base(d1, d2)
        {
            Dim1 = d1; Dim2 = d2;
            Console.WriteLine("Sqaure constructor!");

        }

        public double CArea()
        {
            return Dim1 * Dim2;
        }
    }

    class Triangle : GeoShape
    {
        public Triangle(double _base, double _height): base(_base, _height)
        {
            Console.WriteLine("Triangle constructor!");

        }

        public double CArea()
        {
            return 0.5 * Dim1 * Dim2;
        }
    }

    class Circle : GeoShape
    {
        public Circle(int _r)
        {
            Dim1 = Dim2 = _r;
            Console.WriteLine("Circle constructor!");

        }
        public double CArea()
        {
            return Math.PI * Dim1 * Dim2;
        }

    }



}
