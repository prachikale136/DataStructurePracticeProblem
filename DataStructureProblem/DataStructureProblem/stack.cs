using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Stack<T>
    {
        private Node<T> top;

        public Stack()
        {
            top = null;
        }

        private void IfTopisNull()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty!!!");
            }
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = top;
            top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }

        public void Display()
        {
            IfTopisNull();
            Node<T> temp = top;
            Console.WriteLine("\nStack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
