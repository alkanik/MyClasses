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

        public void AddFirst(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index<0 || index>Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if(_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }

            else if (index == 0)
            {
                AddFirst(value);
            }

            else
            {
                Node prevCrnt = GetNodeByIndex(index - 1);
                Node crnt = GetNodeByIndex(index);
                Node newCrnt = new Node(value);
                prevCrnt.Next = newCrnt;
                newCrnt.Next = crnt;
            }
        }


        public void DeleteLast()
        {
            if (_root is null)
            {
                throw new Exception("list is empty");
            }

            else if (Length == 1)
            {
                _root = null;
                _tail = _root;
            }

            else
            {
                _tail = GetNodeByIndex(Length - 2);
                _tail.Next = null;
            }
        }

        public void DeleteFirst()
        {
            if (_root is null)
            {
                throw new Exception("list is empty");
            }

            else if (Length == 1)
            {
                _root = null;
                _tail = _root;
            }

            else
            {
                _root = _root.Next;
            }
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = crnt.Next.Next;
            }
        }

        public void DeleteNLast(int n)
        {
            if (n > Length || n<0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (n == Length)
            {
                _root = null;
                _tail = _root;
            }
            else
            {
                _tail = GetNodeByIndex(Length - n-1);
                _tail.Next = null;
            }
        }

        public void DeleteNFirst(int n)
        {
            if (n > Length || n<0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (n == Length)
            {
                _root = null;
                _tail = _root;
            }
            else
            {
                _root = GetNodeByIndex(n);
            }
        }

        public void DeleteNByIndex(int index, int n)
        {
            if (n > Length || n<0 || index <0 || index >=Length || (index+n)>Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if ((index+n)==Length)
            {
                _root = null;
                _tail = _root;
            }
            else
            {
                Node crntL = GetNodeByIndex(index-1);
                Node crntR = GetNodeByIndex(index+n);
                crntL.Next = crntR;
            }
        }

        public int FindIndexByValue(int value)
        {

            int index = -1;
            Node crnt = _root;
            
            for (int i = 0; crnt != null; i++)
            {
                if (crnt.Value == value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }

            return index;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if (index<0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                GetNodeByIndex(index).Value = value;
            }
        }

        public void Reverse()
        {
            Node tmp = _root;
            if (Length <= 1)
            {
            }
            else
            {
                Node crnt = _root.Next;
                for (int i=0; crnt.Next!=null; i++)
                {
                    
                    tmp.Next = tmp.Next.Next;
                    crnt.Next = _root;
                    _root = crnt;
                    crnt = tmp.Next;
                }
                crnt.Next = _root;
                tmp.Next = null;
                _root = crnt;
                _tail = tmp;
            }
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("list is empty");
            }

            Node crnt = _root;
            int value = crnt.Value;
            while (crnt.Next!=null)
            {
                crnt = crnt.Next;
                if (crnt.Value > value)
                {
                    value = crnt.Value;
                }
            }

            return value;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("list is empty");
            }

            Node crnt = _root;
            int value = crnt.Value;
            while (crnt.Next != null)
            {
                crnt = crnt.Next;
                if (crnt.Value < value)
                {
                    value = crnt.Value;
                }
            }

            return value;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                throw new Exception("list is empty");
            }

            Node crnt = _root;
            int value = crnt.Value;
            int index = 0;
            for (int i= 1; crnt.Next != null; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value > value)
                {
                    value = crnt.Value;
                    index = i;
                }
            }

            return index;
        }

        public int FindIndexOfMin()
        {
            if (Length == 0)
            {
                throw new Exception("list is empty");
            }

            Node crnt = _root;
            int value = crnt.Value;
            int index = 0;
            for (int i = 1; crnt.Next != null; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value < value)
                {
                    value = crnt.Value;
                    index = i;
                }
            }

            return index;
        }

        public void SortAscending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;
                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public void SortDescending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value < crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value < crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;
                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public int DeleteFirstByValue(int value)
        {
            int index = -1;
            Node crnt = _root;
            for (int i=0; crnt!=null; i++)
            {
                if (crnt.Value == value)
                {
                    index = i;
                    DeleteByIndex(index);
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public int DeleteAllByValue(int value)
        {
            int l = Length;
            int number = 0;
            Node crnt=_tail;

            for (int i = l-1; i>=0; i--)
            {
                if (crnt.Value == value)
                {
                    DeleteByIndex(i);
                    number++;
                }
                crnt = GetNodeByIndex(i-1);
            }
            return number;
        }

        public void AddListInTheEnd(MyLinkedList list)
        {
            MyLinkedList newList = list.Copy();
            if (this._root is null)
            {
                this._root = newList._root;
                this._tail = newList._tail;
            }
            else
            {
                this._tail.Next = newList._root;
                this._tail = newList._tail;
            } 
        }

        public void AddListInTheStart(MyLinkedList list)
        {
            if (list._root != null)
            {
                MyLinkedList newList = list.Copy();
                newList._tail.Next = this._root;
                newList._tail = this._tail;
                this._root = newList._root;
            }
        }

        public void AddListByIndex(int index, MyLinkedList list)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            else if (list._root != null)
            {
                MyLinkedList newList = list.Copy();
                Node gap = GetNodeByIndex(index);
                Node prev = GetNodeByIndex(index-1);
                prev.Next = newList._root;
                newList._tail.Next = gap;
            }
        }

        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;
            for (int i=1; i<=index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;
        }

        public MyLinkedList Copy()
        {
            int l = this.Length;
            MyLinkedList newList = new MyLinkedList();
            
            for(int i=0; i<l; i++)
            {
                newList.AddLast(this.GetNodeByIndex(i).Value);
            }
            newList._root = newList.GetNodeByIndex(0);
            newList._tail = newList.GetNodeByIndex(l - 1);
            return newList;
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

