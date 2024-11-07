using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day02
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private decimal salary;

        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setSalary(decimal salary)
        {
            this.salary = salary;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public decimal getSalary()
        {
            return salary;
        }

        public string Print()
        {
            return $"{id}-{name}-{age}-{salary}";
        }

        public static Employee AddEmployee(int indx)
        {
            Employee tempEmp = new Employee();
            tempEmp.setId(indx);
            Console.WriteLine("Please Enter the Name of the Employee");
            tempEmp.setName(Console.ReadLine());

            int age;
            Console.WriteLine("Please Enter the Age of the Employee");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please Enter a Valid number for the age");
            }
            tempEmp.setAge(age);


            decimal salary;
            Console.WriteLine("Please Enter the Salary of the Employee");
            while (!decimal.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Please Enter a Valid number for the salary");
            }
            tempEmp.setSalary(age);
            return tempEmp;
        }

    }

}
