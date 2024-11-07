using Assignment;
using System;
namespace Calculator
{
    class Calc
    {
        public static void StartCalculator()
        {
            string ch = "Y";
            do
            {
                bool eror = true;
                double num1 = 0;
                double num2 = 0;
                Console.WriteLine("Enter The Two numbers");

                do {
                    try { 
                        Console.Write("First Number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        eror = false;
                    }
                    catch
                    {
                        Console.Write("ERROR PLEASE ENTER A VALID ");
                        eror = true;
                    }
                } while (eror == true);

                
                do
                {
                    Console.Write("Second Number: ");
                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                        eror = false;
                    }
                    catch
                    {
                        Console.Write("ERROR PLEASE ENTER A VALID ");
                        eror = true;
                    }
                } while (eror == true);


                Console.Write("What operation Do you want to perform? ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":

                        if (num2 != 0)
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Error : Invalid Operand");
                        break;
                }
                Console.WriteLine("Would you like to use the calculator again?(Y|N)");
                ch = Console.ReadLine().ToUpper();
            } while (ch.ToUpper() == "Y");
            Program.Main();

        }


    }
}