using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

        public Node()
        {

        }
        public Node(int data)
        {
            Data = data;

        }
    }
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            if (root==null)
            {
                root = new Node(data);
                return;
            }
            InsertRecursiv(root, new Node(data));
        }
        private void InsertRecursiv(Node root,Node newNode)
        {
            if (newNode.Data < root.Data)
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode;
                }
                else
                {
                    InsertRecursiv(root.LeftNode, newNode);
                }
            }
            else
            {
                if(root.RightNode==null)
                {
                    root.RightNode = newNode;
                }
                else
                {
                    InsertRecursiv(root.RightNode, newNode);
                }
            }
        }
        public void DisplayTree()
        {
            TraverseInOrder(root);
        }


        public void TraverseInOrder(Node root)
        {
            if (root != null)
            {
                TraverseInOrder(root.LeftNode);

                Console.Write(root.Data + " ");

                TraverseInOrder(root.RightNode);
            }
        }

        public void TraversePreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");

                TraversePreOrder(root.LeftNode);

                TraversePreOrder(root.RightNode);
            }
        }



        public void TraversePostOrder(Node root)
        {
            if (root != null)
            {
                TraversePostOrder(root.LeftNode);

                TraversePostOrder(root.RightNode);

                Console.Write(root.Data + " ");
            }
        }
    }


}
