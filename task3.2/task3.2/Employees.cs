using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._2
{
    internal class Employees
    {
        public string name { get; set; }
        public int age { get; set; }
        public float salary { get; set; }
        public Employees(string name, int age, float salary)
        {
            this.name = name;   
            this.age = age;
            this.salary = salary;
        }
    }
}
