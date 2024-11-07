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
    public class Stack
    {
        private int tos = 0;
        private int maxSize;
        private int[] stack;

        public Stack(int _maxSize) // Stack Size dynamically set at run-time
        {
            maxSize = _maxSize;
            stack = new int[maxSize];
        }
        public int Len()
        {
            return tos;
        }
        public bool IsFull()
        {
            return tos == maxSize;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                stack[tos++] = value;
                Console.WriteLine($"{value,5}...Pushed into the stack!");

            }
            else
            {
                Console.WriteLine("Stack Overflow!");
            }
        }
        public int GetTop()
        {
            if (!IsEmpty())
            {
                return stack[tos - 1];
            }
            else
            {
                Console.WriteLine("Stack is still empty.");
                return int.MinValue;
            }

        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                tos--;
                Console.WriteLine($"{stack[tos],5}..Popped From the Stack");

            }
            else
            {
                Console.WriteLine("Empty Stack");
            }
        }
        public void Pop(ref int value)
        {
            if (!IsEmpty())
            {
                value = stack[--tos];
                Console.WriteLine($"{stack[tos],5}..Popped From the Stack");

            }
            else
            {
                Console.WriteLine("Empty Stack");
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("[");

                for (int i = tos - 1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.WriteLine("]");
            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }

        }

    }
}
