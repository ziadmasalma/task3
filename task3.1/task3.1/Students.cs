using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{
    internal class Students
    {
        public Students(string name, float avg)
        {
            this.name = name;
            this.avg = avg;
        }

        public string name { get; set; }
        public float avg { get; set; }
    }
}
