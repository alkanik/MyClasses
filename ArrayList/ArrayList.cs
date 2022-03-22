﻿using System;
namespace MyList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
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

        public void Write()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
    }
}


