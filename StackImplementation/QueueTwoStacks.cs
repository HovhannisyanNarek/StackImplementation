using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Queue<T>
    {
        BasicStack<T> s1 = new BasicStack<T>();
        BasicStack<T> s2 = new BasicStack<T>();

        public void enQueue(T x)
        {
            while (s1.Count() > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(x);
            while (s2.Count() > 0)
            {
                s1.Push(s2.Pop());
            }
        }
        public T deQueue()
        {

            if (s1.Count() == 0)
            {
                Console.WriteLine("Q is Empty");

            }


            T x = (T)s1.Peek();
            s1.Pop();
            return x;
        }

        //public void PrintQueue()
        //{
        //    if (s1.Count() <= 0)
        //    {
        //        Console.WriteLine("Queue Underflow");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Items in the Queue are :");
        //        s1.PrintStack();
        //    }
        //}
    }
}
