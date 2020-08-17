using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    public class StackEnumerator<T>: IEnumerator<T>
    {
        T[] array;
        int position = -1;
        public StackEnumerator(T[] array)
        {
            this.array = array; 
        }

        public void Dispose()
        {
            position = -1;
        }
        public T Current
        {
            get
            {
                if (position == -1 || position >= array.Length)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return array[position];
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (position == -1 || position >= array.Length)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return array[position];
                }
            }
        }

        public bool MoveNext()
        {
            if (position < array.Length)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
