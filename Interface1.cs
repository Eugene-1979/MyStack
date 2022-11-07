using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal interface IMyStack<T>
    {

        static public double LoadFactor = 0.75;
        void Push(T t);
        T Pop();
        void Clear();
        int Count();
        T Peek();

        bool CopyTo(T[] t);



    }
}
