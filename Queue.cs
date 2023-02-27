using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Queue
    {
        private Node front;
        private Node tail;

        public Queue() 
        {
            this.front = null;
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
            {
                tail = node;
                front = node;
            }
            else
            {
                node.Next = tail;
                tail = node;
            }
            Console.WriteLine($"\n{data} is added in queue");
        }
        public void Dequeue()
        {
            if (tail != null)
            {
                if (tail.Next == null)
                {
                    tail = null;
                }
                else
                {
                    Node temp = tail;
                    while (temp.Next.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                    front = temp;
                }
            }

            Display();

        }

        public void Display()
        {
            if (tail != null)
            {
                Node temp = tail;
                Console.WriteLine("\nThe Queue: ");
                while (temp != null)
                {
                    Console.WriteLine($"|{temp.data}|");
                    temp = temp.Next;
                }
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine();
        }
    }
}
