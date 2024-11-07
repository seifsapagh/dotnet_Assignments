using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Assignment;
namespace Arr
{
    internal class MyArray
    {
        
        private int[] arr= new int[10];
        int arrMax = int.MinValue;
        int arrMin = int.MaxValue;
        public MyArray()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter Array item #{i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
                UpdateMinMax(arr[i]);
            }

        }

        public void UpdateMinMax(int value)
        {
            if (value > arrMax)
            {
                arrMax = value;
            }

            if (value < arrMin)
            {
                arrMin = value;
            }
        }

        public int[][] Sort()
        {
            // Hold the original Positions
            int[] originalPositions = new int[arr.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                originalPositions[k] = k;
            }

            // Clone originl arr
            int[] arrCopy = new int[arr.Length];
            arr.CopyTo(arrCopy, 0);

            int i = 1;
            for(;i< arrCopy.Length; i++)
            {
                int k = originalPositions[i];

                int key = arrCopy[i];
                int j = i - 1; ;
                while (j >= 0 && arrCopy[j] > key)
                {
                    originalPositions[j + 1] = originalPositions[j];

                    arrCopy[j + 1] = arrCopy[j];
                    j--;
                }

                originalPositions[j + 1] = k;

                arrCopy[j + 1] = key;
            }
            return [arrCopy, originalPositions];

        }
        public void Print(int[] arr)
        {
            Console.Write($"[ ");
            string chr = " - ";
            for (int i = 0; i < arr.Length; i++)
            {
                if(i==arr.Length - 1)
                {
                    chr = "";
                }
                
                Console.Write($"{arr[i]}{chr}");
            }
            Console.WriteLine($"]");
        }


        public int Find(int target)
        {
            int[] arrCopy = Sort()[0];
            int[] originalPositions = Sort()[1];
            int l = 0; int r = arr.Length-1;
            while (l <= r)
            {
                int mid = (r+l) / 2;
                if (arrCopy[mid] > target)
                {
                    r = mid-1;

                }else if (arrCopy[mid] < target)
                {
                    l = mid+1;
                }
                else
                {
                    return originalPositions[mid];
                    //return mid;
                }

                //Console.WriteLine(mid);

            }
            return -1;
        }

        public void Start()
        {
            Console.WriteLine($"You Entered:");
            Print(arr);
            Console.WriteLine($"Array Minimum Value: {arrMin} \n Array Maximum Value:{arrMax}");
            Console.WriteLine($"Array Sorted:");
            
            Print(Sort()[0]);
            string ch = "Y";
            do
            {
                Console.WriteLine($"Please Enter the Value you would like to get the index of");
                int num = int.Parse(Console.ReadLine());
                string Index = "";
                if (Find(num) == -1)
                {
                    Index = "Doesn\'t Exist";
                }
                else
                {
                    Index = $"is at index {Find(num)}";
                }
                
                Console.WriteLine($"{num} {Index}");

                Console.WriteLine($"Would you like to Search another number?");
                ch = Console.ReadLine();

            } while (ch.ToUpper() == "Y");
                
            Assignment.Program.Main();

        }

    }
}
