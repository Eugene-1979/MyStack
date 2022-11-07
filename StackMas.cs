using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class Stackmas<T> : IMyStack<T>,IEnumerable<T>
    {


        int _capasity = 10;
        int _arrSize = 0;
        T[] mas;

        public Stackmas()
        {
            mas = new T[_capasity];
        }

        public Stackmas(T[] mas)
        {
            this.mas = mas;
        }


        void resize()
        {
            if (_arrSize > IMyStack<T>.LoadFactor * _capasity)
            {
                _capasity *= 2;
                Array.Resize(ref mas, _capasity);
            }

        }


        public void Clear()
        {
            _arrSize = 0;
        }

        public bool CopyTo(T[] t)
        {
            if (t == null) return false;
            int length = _arrSize < t.Length ? _arrSize : t.Length;

            for (int i = 0; i < length; i++)
            {
                t[i] = mas[i];
            }

            return true;
        }

        public int Count()
        {
            return _arrSize;
        }

        public T Peek()
        {
            if (_arrSize < 1) new Exception("Not Element in Stack");
            return mas[_arrSize - 1];
        }

        public T Pop()
        {
            if (_arrSize < 1) new Exception("Not Element in Stack");
            return mas[--_arrSize];
        }

        public void Push(T t)
        {
            resize();
            mas[_arrSize++] = t;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _arrSize; i++)
            {

                yield return mas[i];
            }
        }

          IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _arrSize; i++)
            {

                yield return mas[i];
            }
        }

        /* public IEnumerator<T> GetEnumerator()
         {
             for (int i = 0; i < _arrSize; i++)
             {

                 yield return mas[i];
             }
         }*/


    }
}
