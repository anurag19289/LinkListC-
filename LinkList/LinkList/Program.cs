using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkList = new LinkedList<int>();
            linkList.AddFirst(2);
            linkList.AddFirst(4);
            linkList.AddFirst(6);
            linkList.AddFirst(8);
            linkList.Remove(6);

            var current = linkList.Head; //o/p :-  8 6 4 2
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }


            Console.ReadLine();
        }
    }
}
