using Arr;
using System;
using AgeCalculator = Brithdate.AgeCalculator;
using Cal = Calculator.Calc;
using myarr = Arr.MyArray;
using matrix = Matrix.Matrix;
namespace Assignment

{
    class Program
    {
        public static void Main()
        {
            /* Asgienments:
                [x] 1. Age Calculator      
                [x] 2. Calculator
                [x] 3. int arr[10] through user input
                [x]    3.1 get arr.min arr.max
                [x]    3.2 sorted(arr)
                [x]    3.3 arr.search()
                [x] 4. Matrix through user input
                [x]    4.1 sum of rows
                [-]    4.2 [3][2] * [2][1]
                [-]    4.3 [3][3] * [3][2]
            */
            string ch = "";

            Console.WriteLine("Please Choose a program to run:");
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Age Calculator");
                Console.WriteLine("[2] Basic Calculator");
                Console.WriteLine("[3] Array Operations");
                Console.WriteLine("[4] Matrix Operations");
                Console.WriteLine("[5] quit");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        AgeCalculator.Start();
                        break;
                    case "2":
                        Cal.StartCalculator();
                        break;
                    case "3":
                        myarr Arr = new myarr();
                        Arr.Start();
                        break;
                    case "4":
                        matrix mat = new matrix(3,4);
                        mat.Start();
                        break;

                    case "5":
                        break;

                    default:
                        Console.WriteLine("Please Ener a Valid Choice");
                        break;
                }
            } while (ch.Length > 0 && ch != "5");



        }
    }
}