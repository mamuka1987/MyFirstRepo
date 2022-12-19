using System;
using System.Collections.Generic;
namespace Impelented_Solution
{
    class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format($"id = {0}, Name = {1}", id, Name);
        }
        class EmployeeByIdComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.id.CompareTo(y.id);
            }
        }
        public static void SortList()
        {
            var list = new List<Employee>();
            list.Sort(new EmployeeByIdComparer());
            list.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "jamal";
        }
    }


}
