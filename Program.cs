using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        private static object queue;
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList linkedList = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);

            while (flag)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.AddFirst");
                Console.WriteLine("3.AddLast");
                Console.WriteLine("4.Remove the last Node");
                Console.WriteLine("5.Display");
                Console.WriteLine("6.searchvalue");
                Console.WriteLine("7.Size");
                Console.WriteLine("8.Push");
                Console.WriteLine("9.Pop");
                Console.WriteLine("10.queue");
                Console.WriteLine("Enter The Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        //linkedList.AddFirst(70);
                        //linkedList.AddFirst(30);
                        //linkedList.AddFirst(56);
                        linkedList.ReversOrder(70);
                        linkedList.ReversOrder(30);
                        linkedList.ReversOrder(56);
                        break;
                    case 3:
                         linkedList.AddLast(56);
                         linkedList.AddLast(30);
                         linkedList.AddLast(70);
                       break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.SearchValue(10);
                        linkedList.Display();
                        break;
                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(40);
                        linkedList.Add(20);
                        linkedList.Add(10);
                        linkedList.Display();
                        linkedList.Size();
                        break;
                    case 8:
                        //stack.Push(10);
                        //stack.Push(20);
                        //stack.Push(30);
                        stack.Pop();
                        stack.Display();
                        break;
                    case 9:
                        object value = queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        queue.Enqueue(45);
                        break;
                    case 10:
                        //linkedList.Display();
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Please Enter Current Value");
                        break;
                }
            }
        }
    }
}
