using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public int[,] myMatrix ;
        private int r;
        private int c;
        public Matrix(int r, int c)
        {
            this.r = r;
            this.c = c;
            myMatrix = new int[r, c];

            Console.WriteLine("Enter Matrix Elements");
            for(int i =0; i< r;i++)
            {
                for(int j =0; j<c; j++)
                {
                    int num = 0;
                    while (true)
                    {
                        try { 
                            num = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch{
                            Console.WriteLine("Please Enter a Valid Number for");
                        }
                    }

                    myMatrix[i,j] = num;
                    Console.WriteLine($"matrix[{i+1}][{j+1}] = {num}...added");
                }
            }

            
        }

        // TODO: 
        ////6-Bonus multiply 2 matrix
        //3*2    *  2*1  =  3*1


        //7- bonus 3*3     *    3*2   =  3*2

        //public int[,] Multiply(int[,] mat1, int[,] mat2)
        //{
        //    int rows = mat1.GetLength(0);
        //    int cols = mat2.GetLength(1);
        //    int[,] res = new int[rows,cols];

        //}
        public int [] getSum()
        {
            int[] rowSums = new int[r];
            for (int i = 0; i < r; i++)
            {
                int tempRowSum = 0;
                for (int j = 0; j < c; j++)
                {
                    tempRowSum += myMatrix[i, j];
                }
                rowSums[i] += tempRowSum;
            }
            return rowSums;

        }
        public void Print()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    Console.Write($"{myMatrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintSums()
        {
            int[] sums = getSum();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    Console.Write($"{myMatrix[i, j],5} ");
                }
                Console.Write($"{sums[i],5} ");
                Console.WriteLine();
            }
        }

        public void Start()
        {
            Console.WriteLine($"The Matrix You Entered:{r}×{c}");
            Print();

            Console.WriteLine("Matrix Row Sums");
            PrintSums();
        }

    }
}
