using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                if (Lenght == 0)
                {
                    throw new ArgumentException("LinkedList is empty");
                }
                if (index < 0 || index > Lenght)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set 
            {
                if (index < 0 || index > Lenght)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Value = value;
            }
        }

        public int Lenght 
        { 
            get
            {
                int count = 0;
                Node crnt = _root;
                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }
            private set { }
        }

        // 3 конструктора(пустой, на основе одного элемента, на основе массива) (task 23)
        public LinkedList()
        {
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                    _tail = crnt;
                }
            }
        }

        // добавление значения в конец (task 1)
        public void AddLast(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        // добавление значения в начало (task 2)
        public void AddFirst(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }

        public override string ToString()
        {
            string s = "[ ";
            Node crnt = _root;
            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }
            s += "]";
            return s;
        }

        //дописать
        public override bool Equals(object? obj)
        {
            bool isEqual = true;
            if (obj is null || !(obj is LinkedList))
            {
                isEqual = false;
            }
            else
            {
                LinkedList list = (LinkedList)obj;
                if (list.Lenght != this.Lenght)
                {
                    isEqual = false;
                }
                else
                {
                    Node crnt = _root;
                    while (crnt != null)
                    {
                        if (crnt.Value != )
                        {
                            isEqual = false;
                        }
                        crnt = crnt.Next;
                    }
                }
            }
            return isEqual;
        }
    }
}
