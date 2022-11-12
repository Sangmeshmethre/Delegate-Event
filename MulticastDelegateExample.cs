using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class MulticastDelegateExample
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            // Delegate Instantiation
            DelOp Obj = Operation.Add;
            Obj += Oparation.Square;
            Obj(5, 5);
            Obj(8, 3);
            Console.ReadLine();
        }
        public class Oparation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition={0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple={0}", a * b);
            }
        }
    }

}
