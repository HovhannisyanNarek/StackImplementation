using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class List<T> : IList<T>
    {
        private const int defaultSize = 5;

        private T[] list;

        private int top;
        public List()
        {
            list = new T[defaultSize];
            top = 0;
        }
        public List(int arraySize)
        {
            if (arraySize < 0)
            {
                throw new Exception("Size must be positiv number");
            }
            list = new T[arraySize];
            top = 0;
        }

        public T this[int index] 
        {
            get
            {
                return list[index];
            } 
            set 
            {
                value = list[index];
            }  
        }

        public int Count { get { return top; } }

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            if(Count==list.Length )
            { 
                T[] newList = new T[2 * list.Length];
                CopyTo(newList, 0);
                list = newList;
            }
            list[Count] = item;
            top++;
        }

        public void Clear()
        {
            top = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(list[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < Count; i++)
            {
                list[i] = array[i-arrayIndex];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if ((top + 1 <= list.Length) && (index < Count) && (index > -1) )
            {
                top++;
                for (int i = Count-1; i > index; i--)
                {
                    list[i] = list[i - 1];
                }
                list[index] = item;
            }
        }

        public bool Remove(T item)
        {
            if(IndexOf(item)>-1&& IndexOf(item)<Count)
            {
                RemoveAt(IndexOf(item));
                return true;
            }
            return false;
            
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            top--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
