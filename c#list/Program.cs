using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CList<int> list = new CList<int>();
            list.addElement(1);
            list.addElement(2);
            list.addElement(6);
            list.PushFront(7);
            list.Print();
            list.InsertAfter(3, 3333);
            list.InsertBefore(0, 5555);
            Console.WriteLine("============");
            list.Print();
            Console.WriteLine("============");
            list.Remove(0);
            list.Remove(5);
            list.Print();
            Console.WriteLine("============");
            list.PopBack();
            list.PopFront();
            list.Print();
            Console.ReadKey();
        }
    }
}
