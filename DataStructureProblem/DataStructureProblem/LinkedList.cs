using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class LinkedList<T>
    {
       
            public Node<T> head;

            public void Add(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> current = head;

                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    current.next = newNode;
                }
                Console.WriteLine("{0} inserted into linked list", newNode.data);
            }

            public void Display()
            {
                Node<T> temp = head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
}
