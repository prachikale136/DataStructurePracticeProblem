
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Program
    {
        public static void Main(string[] args) 
        { 
           /* LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Display();*/

           /* Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Display();*/
           Queue<string> queue = new Queue<string>();
           queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Display();
        }
    }
}
