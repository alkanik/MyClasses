using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
	public class MyLinkedList
	{
		private Node _root;
		private Node _tail;

		public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i=1; i<=index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set
            {
            }
        }

        public int Length
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
            private set
            {

            }
        }

        public MyLinkedList()
        {
			_root = null;
            _tail = null;
        }

		public MyLinkedList(int value)
        {
			_root = new Node(value);
            _tail = _root;
        }

        public MyLinkedList(int[] array)
        {

            if (array.Length == 0)
            {
                _root = null;
                _tail = null;
            }

            else
            {
                _root = new Node(array[0]);
                _tail = _root;

                for (int i = 1; i < array.Length; i++)
                {
                    AddLast(array[i]);
                }
            }
        }

        public void AddLast(int value)
        {
            if (_root == null)
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

        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }
            return s;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is MyLinkedList))
            {
                return false;
            }

            MyLinkedList list = (MyLinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }
                else
                {
                    thisCrnt = thisCrnt.Next;
                    listCrnt = listCrnt.Next;
                }
            }
            return true;
        }

    }
}

