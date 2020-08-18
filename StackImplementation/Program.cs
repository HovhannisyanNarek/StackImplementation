using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicStackTest();

             BinaryTreeTest();

           

        }

        private static void BasicStackTest()
        {
            BasicStack<int> stack = new BasicStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
          //stack.PrintStack();
            stack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", stack.Pop());
          //stack.PrintStack();
        }


        private static void BinaryTreeTest()
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.DisplayTree();
        }
    }
}
