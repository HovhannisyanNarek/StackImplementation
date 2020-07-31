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
            //  BasicStackTest();
            // BinaryTreeTest();
        }

        private static void BasicStackTest()
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


        private static void BinaryTreeTest()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(0);
            binaryTree.Add(1);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(2);
            binaryTree.Add(5);
            binaryTree.Add(6);


            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
