using System;
namespace MyList
{
    public class MyArrayList
    {
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public int Length { get; private set; }

        private int[] _array;

        public MyArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public MyArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }

        public MyArrayList(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public void AddLast(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            Length++;
            if (Length >= _array.Length)
            {
                UpSize();
            }

            int i = Length;
            while (i > 0)
            {
                _array[i] = _array[i - 1];
                i--;
            }
            _array[0] = value;
        }

        public void AddByIndex(int index, int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            int i = Length;
            while (i > index)
            {
                _array[i] = _array[i - 1];
                i--;
            }
            _array[index] = value;
            Length++;
        }

        public void DeleteLast()
        {
            if (Length <=0 )
            {
                throw new Exception("list can't be empty");
            }
            
            Length--;
        }

        public void DeleteFirst()
        {
            if (Length <= 0)
            {
                throw new Exception("list can't be empty");
            }

            for (int i =0; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
            Length--;
        }

        public void DeleteByIndex(int index)
        {
            if (Length <= 0)
            {
                throw new Exception("list can't be empty");
            }

            for (int i=index; i<Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }

        public void DeleteNLast(int n)
        {
            if (Length <= 0)
            {
                throw new Exception("list can't be empty");
            }

            int newLength = Length - n;

            while (Length > newLength)
            {
                Length--;
            }

            if (_array.Length / Length >= 2)
            {
                DownSize();
            }
        }
        public void DeleteNFirst(int n)
        {
            if (Length <= 0)
            {
                throw new Exception("list can't be empty");
            }

            int newLength = Length - n;

            for (int i=0; i<newLength; i++)
            {
                _array[i] = _array[i + n];
            }
            Length = newLength;

            if (_array.Length / Length >= 2)
            {
                DownSize();
            }
        }

        public void DeleteNByIndex(int n, int index)
        {
            if (Length <= 0)
            {
                throw new Exception("list can't be empty");
            }

            int newLength = Length - n;

            for (int i = index; i < newLength; i++)
            {
                _array[i] = _array[i + n];
            }
            Length = newLength;

            if (_array.Length / Length >= 2)
            {
                DownSize();
            }
        }

        public int FindIndexByValue(int value)
        {

            int index = -1;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if (Length <= index)
            {
                throw new Exception("index out of range");
            }

            _array[index] = value;
        }

        public void Reverse()
        {
            for (int i = 0; i < (Length / 2); i++)
            {
                int tmp = _array[i];
                _array[i] = _array[Length - (1 + i)];
                _array[Length - (1 + i)] = tmp;
            }
        }
        public int FindMax()
        {
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int FindMin()
        {
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int FindIndexMax()
        {
            int max = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    index = i;
                }
            }
            return index;
        }

        public int FindIndexMin()
        {
            int min = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    index = i;
                }
            }
            return index;
        }

        public void SortAscending()
        {
            int tmp = 0;
            for (int i = 0; i < Length-1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public void SortDescending()
        {
            int tmp = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public int DeleteFirstByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    DeleteByIndex(index);
                }
            }
            return index;
        }
        public int DeleteAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        private void DownSize()
        {
            int newLength = _array.Length / 3 * 2 + 1;
            int[] newArray = new int[newLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }

            return s;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is MyArrayList))
            {
                isEqual = false;
            }
            else
            {
                MyArrayList list = (MyArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }
    }
}


