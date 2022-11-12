using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int Oparation(int x, int y);
    class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            MulticastDelegateExample.ImplementDelegate();
        }
    }
}