using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day04
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        public decimal Salary { set; get; } // Auto property(The compiler Automatically creates a private data field for the property)

        public int Id // Full Property
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name { get => name; set => name = value; } 
        public int Age { get; set; } 


        public string Print()
        {
            return $"{Id}-{Name}-{Age}-{Salary}";
        }

        public static Employee AddEmployee(int indx)
        {
            Employee tempEmp = new Employee();
            tempEmp.Id = indx;
            Console.WriteLine("Please Enter the Name of the Employee");
            tempEmp.Name =Console.ReadLine();

            int age;
            Console.WriteLine("Please Enter the Age of the Employee");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please Enter a Valid number for the age");
            }
            tempEmp.Age = age;


            decimal salary;
            Console.WriteLine("Please Enter the Salary of the Employee");
            while (!decimal.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Please Enter a Valid number for the salary");
            }
            tempEmp.Salary = salary;
            return tempEmp;
        }

    }

}
