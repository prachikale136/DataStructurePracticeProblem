using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
