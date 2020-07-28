using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStack<int> stack = new BasicStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.PrintStack();
            stack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", stack.Pop());
            stack.PrintStack();
        }
    }
}
