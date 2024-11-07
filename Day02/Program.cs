using System;
using System.Numerics;
namespace Day02
{
    public class Program
    {
        public static int PickIndex(int maxIndex)
        {
            int indx;
            Console.WriteLine($"Please Enter the index you want to add into [0-{maxIndex - 1}]");
            while (!int.TryParse(Console.ReadLine(), out indx) || (indx < 0 || indx > 9))
            {
                Console.WriteLine("Please Enter a Valid number");
            }
            return indx;

        }

        public static void Main()
        {
            string ch = "y";
            Console.WriteLine("Please Choose:");
            do
            {

                Console.WriteLine("[1] Employees");
                Console.WriteLine("[2] Complex Numbers");
                Console.WriteLine("[3] quit");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        int EmpsCount = 10;
                        Employee[] emps = new Employee[EmpsCount];
                        bool[] EnteredEmps = new bool[EmpsCount];
                        bool cont = true;
                        do
                        {
                            int indx = PickIndex(EmpsCount);
                            string tmp = "";
                            while (EnteredEmps[indx]) 
                            {
                                Console.WriteLine("The index you entered already Exists, would you like to over-write it?(y/n)");
                                tmp = Console.ReadLine();
                                if (tmp.ToLower() == "n")
                                {
                                    indx = PickIndex(EmpsCount);
                                }
                                else
                                {
                                    break;
                                }
                            } 

                            emps[indx]= Employee.AddEmployee(indx);
                            EnteredEmps[indx] = true;
                            Console.WriteLine("Would you like to add more?(y/n)");

                            cont = Console.ReadLine().ToLower() == "y" ? true : false;

                        } while (cont);

                        for (int j = 0; j < EmpsCount; j++)
                        {
                            if (EnteredEmps[j])
                            {
                                Console.WriteLine(emps[j].Print());
                            }
                        }
                        
                        break;
                    case "2":
                        Console.Write("Enter Real Number:");
                        int r;
                        while (!int.TryParse(Console.ReadLine(), out r))
                        {
                            Console.WriteLine("Please Enter a Valid Number");
                        }

                        Console.Write("Enter Imaginary Number:");
                        int i;
                        while (!int.TryParse(Console.ReadLine(), out i))
                        {
                            Console.WriteLine("Please Enter a Valid Number");
                        }

                        Complex myComplex = new();
                        myComplex.SetReal(r);
                        myComplex.SetImaginary(i);

                        Console.WriteLine(myComplex);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid Input or (3) to quit");
                        ch = "y";
                        break;
                }

            } while (ch.ToLower() == "y");

        }
    }
}