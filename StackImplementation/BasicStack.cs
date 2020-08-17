using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    public class BasicStack<T>:IEnumerable<T>
    {
        int top;
        public const int defaultSize = 5;
        T[] stack ;
        bool IsEmpty()
        {
            return (top < 0);
        }
        public BasicStack()
        {
            stack = new T[defaultSize];
            top = 0;
        }
        public BasicStack(int size)
        {
            if(size<0)
            {
                throw new Exception("Size must be positiv number");
            }
            stack = new T[size];
            top = -1;
        }
        public void Push(T data)
        {
            if (top == stack.Length)
            {
                T[] newStack = new T[2 * stack.Length];

                Array.Copy(stack, 0, newStack, 0, top);

                stack = newStack;
            }
            stack[top] = data;
            top++;
        }

        public T Pop()
        {
            if (top == 0)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                return stack[top-1];
            }
        }

        public T Peek()
        {
            if (top == 0)
            {
                throw new Exception("Stack Empty");
            }
            else
            {               
                return stack[top-1];
            }
        }

        //public void PrintStack()
        //{
        //    if (top < 0)
        //    {
        //        Console.WriteLine("Stack Underflow");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Items in the Stack are :");
        //        for (int i = top; i >= 0; i--)
        //        {
        //            Console.WriteLine(stack[i]);
        //        }
        //    }
        //}
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


