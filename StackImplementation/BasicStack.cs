using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    public class BasicStack<T>:IEnumerable<T>
    {
        static readonly int MAX = 1000;
        int top;
        T[] stack = new T[MAX];
        bool IsEmpty()
        {
            return (top < 0);
        }
        public BasicStack()
        {
            top = -1;
        }
        internal bool Push(T data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal T Pop()
        {
            if (top < 0)
            {
                throw new Exception("Stack Underflow");
            }
            else
            {
                T value = stack[top--];
                return value;
            }
        }

        internal T Peek()
        {
            if (top < 0)
            {
                throw new Exception("Stack Underflow");
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            return stack[top];
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        public int Count()
        {
            return top;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(stack);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StackEnumerator<T>(stack);
        }
    }
}


