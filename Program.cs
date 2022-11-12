using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public delegate void DelEventHandler();
    class program
    {
        public static event DelEventHandler add;
        public static void Main(string[] args)
        {
            add += new DelEventHandler(India);
            add += new DelEventHandler(USA);
            add += new DelEventHandler(England);

            add.Invoke();
            Console.WriteLine("************************Event Handling****************");
            EventHandling.ImplementEvent();
        }
        private static void India()
        {
            Console.WriteLine("India");
        }
        private static void USA()
        {
            Console.WriteLine("USA");
        }
        private static void England()
        {
            Console.WriteLine("Englend");
        }
    }
}