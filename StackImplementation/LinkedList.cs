using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class DNode<T>
    {
        internal T data;

        internal DNode<T> prev;

        internal DNode<T> next;

        public DNode(T d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    public class DoubleLinkedList<T>
    {
        internal DNode<T> head;

        internal void InsertFront(DoubleLinkedList<T> doubleLinkedList, T data)
        {
            DNode<T> newNode = new DNode<T>(data);

            newNode.next = doubleLinkedList.head;

            newNode.prev = null;

            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }

            doubleLinkedList.head = newNode;
        }
        internal DNode<T> GetLastNode(DoubleLinkedList<T> doubleLinkedList)
        {
            DNode<T> temp = doubleLinkedList.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void InsertLast(DoubleLinkedList<T> doubleLinkedList, T data)
        {
            DNode<T> newNode = new DNode<T>(data);

            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;

                doubleLinkedList.head = newNode;

                return;
            }

            DNode<T> lastNode = GetLastNode(doubleLinkedList);

            lastNode.next = newNode;

            newNode.prev = lastNode;
        }
        internal void InsertAfter(DNode<T> prevNode, T data)
        {
            if (prevNode == null)
            {
               throw new Exception("The given prevoius node cannot be null");               
            }
            DNode<T> newNode = new DNode<T>(data);

            newNode.next = prevNode.next;

            prevNode.next = newNode;

            newNode.prev = prevNode;

            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        internal void DeleteNodebyKey(DoubleLinkedList<T> doubleLinkedList, T key)
        {
            DNode<T> temp = doubleLinkedList.head;
            if (temp != null && temp.data.Equals(key))
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
    }
}
