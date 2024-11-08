using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public enum Gender
    {
        Male,
        Female
    }
    [Flags]
    public enum Security
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        SecurityOfficer = 15
    }

    internal class Employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Date HiringDate { get; set; }
        public Gender EmpGender { get; set; }
        public Security SecurityLevel { get; set; }
        private static int IdCounter= 0;
        public Employee( string name, decimal salary, Date hiringDate, Gender empGender, Security securityLevel)
        {
            Id = IdCounter++;
            Name = name;
            Salary = salary;
            HiringDate = hiringDate;
            EmpGender = empGender;
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"{Id} : {Name} : {Salary:C} : {HiringDate} :  {EmpGender} : {SecurityLevel}";
        }

        public static void SortEmployees(ref Employee[] emps, bool desc = false)
        {
            for(int i = 1; i<emps.Length; i++)
            {
                Employee temp = emps[i];
                int j = i - 1;

                while(j>=0 && emps[j].HiringDate > temp.HiringDate)
                {
                    emps[j + 1] = emps[j];
                    j--;
                }
                emps[j + 1] = temp;
            }
            if (desc)
            {
                int l = emps.Length;
                for(int i = 0; i<emps.Length/2; i++)
                {
                    Employee temp = emps[i];
                    emps[i] = emps[l - i - 1];
                    emps[l - i - 1] = temp;
                }


            }

        }

    }
}
