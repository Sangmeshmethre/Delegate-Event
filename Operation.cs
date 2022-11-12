using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Operation
    {

        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }
        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiple={0}", a * b);
        }


    }
    class ArrayDelegates
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            //Delegate Instanation 
            DelOp[] Obj =
            {
                new DelOp(Operation.Add),
                new DelOp(Operation.Multiple),
            };
            for (int i = 0; i < Obj.Length; i++)
            {
                Obj[i](2, 5);
                Obj[i](8, 5);
                Obj[i](4, 6);
                Console.WriteLine();
            }
        }
    }

}
