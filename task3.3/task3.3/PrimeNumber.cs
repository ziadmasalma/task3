using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._3
{
    internal class PrimeNumber
    {
        public bool check(int n)
        {
            int i = 2;
            while (i < n)
            {
                if (n%i==0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
