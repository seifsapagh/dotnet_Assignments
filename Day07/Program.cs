
using System;
namespace Day07
{
    public class Program
    {
        public static void Main()
        {


            Employee e1 = new("Seif", 0, new(2020, 5, 5), Gender.Male, Security.Guest);
            Employee e2 = new("Aly", 500, new(2021, 5, 5), Gender.Male, Security.DBA);
            Security MaxPrivilage = Security.Guest ^ Security.Developer ^ Security.DBA ^Security.Secretary;
            Employee e3 = new("Alyaa", 5000, new(2018, 5, 5), Gender.Female, MaxPrivilage);
            Employee[] Employees ={e1,e2,e3};

            Console.WriteLine("Before Sorting");
            for(int i =0; i< 3; i++)
            {
                Console.WriteLine(Employees[i]);
            }
            Employee.SortEmployees(ref Employees,true);

            Console.WriteLine("After Sorting");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Employees[i]);
            }
        }
    }
}