using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class StackLinked<T> : IMyStack<T>
    {
     
        int _arrSize = 0;
        Node<T> _endNode;
        class Node<T> {
           public T val;
           public Node<T> next;
           public Node<T> prev;

            public Node(T val)
            {
                this.val = val;
             
            }
        }

        public void Clear()
        {
           _arrSize = 0;
            _endNode = null;

        }

        public bool CopyTo(T[] t)
        {
            if (t == null) return false;
            int length = _arrSize < t.Length ? _arrSize-1 : t.Length-1;
            Node<T> temp = _endNode;

            for (int i = length; i >= 0; i--)
            {
                t[i] = temp.val;
                temp = temp.prev;
            }

            return true;
        }

        public int Count()
        {
            return _arrSize;
        }

        public T Peek()
        {

            if (_endNode.prev==null) new Exception("Not Element in Stack");
            return _endNode.val;
        }

        public T Pop()
        {
            --_arrSize;
            if (_endNode.prev == null) new Exception("Not Element in Stack");
            Node<T> val = _endNode;
            _endNode = val.prev;
            _endNode.next = null;
            return val.val;

        }

        public void Push(T t)
        {
            _arrSize++;
            Node <T>val = _endNode;
            _endNode = new Node<T>(t);
            _endNode.prev = val;
            if(val!=null) val.next=_endNode;
             
        }



        public void Print()
        {


            Node<T> temp = _endNode;
            Node<T> temp1;
            while (temp != null)
            {
                temp1 = temp;
                temp = temp.prev;
                Console.WriteLine(temp1.val);

            }


        }

        





    }
}
