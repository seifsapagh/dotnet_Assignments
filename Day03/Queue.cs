using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Queue
    {
        private int head;
        private int tail;
        private int[] q;
        private int maxSize;

        public Queue(int maxSize = 6)
        {
            this.maxSize = maxSize;
            q = new int[maxSize];

            head = 0;
            tail = 0;
        }
        public bool IsEmpty()
        {
            return tail == head;
        }
        public bool IsFull()
        {
            return tail== maxSize;
        }
        public void Enqueue(int value)
        {

            if (!IsFull()&& tail <= maxSize)
            {
                q[tail++] = value;
            }
            else
            {
                Console.WriteLine("Queue is Full, Can't add more at the moment");
            }
        }
        public void Dequeue()
        {

            if (!IsEmpty())
            {
                head++;
            }
            else
            {
                Console.WriteLine("Queue is Empty, Can't Dequeu");

            }
        }
        public void Head(ref int value)
        {
            if (!IsEmpty() )
            {
                value = q[head];
            }
        }

        public void Tail(ref int value)
        {
            if (!IsEmpty())
            {
                value = q[tail-1];
            }
        }

        public void PrintQueue()
        {
            if (!IsEmpty()) { 
                Console.WriteLine();
                for (int i = head; i< tail; i++)
                {
                    Console.Write($"| {q[i]} |");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Queue is Empty!");
            }
        }

        public static void Main()
        {
            Queue myQ = new(3);
            int x=-10, z=-10;
            myQ.Head(ref x);
            myQ.Tail(ref z);
            myQ.Dequeue();
            myQ.Enqueue(1);
            myQ.PrintQueue();
            myQ.Enqueue(2);
            myQ.PrintQueue();
            myQ.Enqueue(3);
            myQ.PrintQueue();
            Console.Write("Enqueue 4th:");
            myQ.Enqueue(4);
            myQ.Dequeue();
            myQ.PrintQueue();
            myQ.Dequeue();
            myQ.PrintQueue();
            myQ.Dequeue();
            myQ.PrintQueue();
            myQ.Dequeue();
            myQ.PrintQueue();



        }

    }

}