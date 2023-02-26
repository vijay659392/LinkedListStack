using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node headNode;
        public Node tailNode;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.headNode == null)
            {
                this.headNode = node;
            }
            else
            {
                Node tempNode = headNode;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list ", node.data);

        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = headNode;
            headNode = newNode;
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
                tailNode = headNode = newNode;
            else
            {
                tailNode.Next = newNode;
                tailNode = newNode;
            }
        }
        public void ReversOrder(int data)
        {
            Node newNode = new Node(data);

            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = this.headNode;
                headNode = newNode;
                headNode.Next = tempNode;
            }
            Console.WriteLine(newNode.data + " is inserted into the linked list");
        }

        public void RemoveFirstNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("linked list is empty");
            }
            this.headNode = this.headNode.Next;
            Console.WriteLine("the first element is deleted");
        }

        public void RemoveLastNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("linked list is empty");
            }
            if (headNode.Next == null)
            {
                headNode = null;
            }
            else
            {
                Node lastNode = this.headNode;
                while (lastNode.Next.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = null;
                Console.WriteLine("the last element is deleted");
            }
        }

        public void SearchValue(int value)
        {
            bool doesExists = false;
            if (headNode != null)
            {
                int count = 0;
                Node temp = headNode;
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        doesExists = true;
                        count++;
                    }
                    temp = temp.Next;
                }
                if (doesExists)
                {
                    Console.WriteLine($">>>>>(value) exists {count} times");
                }
                else
                {
                    Console.WriteLine($">>>>>{value} is not present in list");
                }
            }
            Display();
        }

        public void Size()
        {
            Node temp = headNode;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Lined List is empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.Next;
                count++;
            }
            Console.WriteLine(count);
        }
        public void Display()
        {
            Node temp = this.headNode;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine("Linked list is: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }


        }
    }
}