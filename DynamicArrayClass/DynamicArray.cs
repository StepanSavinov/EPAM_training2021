using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArrayClass
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] _array;
        private int _capacity;
        private int _length;

        public int Length { get => _length; set => _length = value; }

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                if (value >= 0)
                {
                    _capacity = value;

                    Array.Resize(ref _array, _capacity);

                    if (Length > _capacity)
                    {
                        Length = _capacity;
                    }
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if ((index < -Length) || (index >= Length))
                {
                    throw new ArgumentOutOfRangeException("You went out of array bounds");
                }
                else if (index < 0)
                {
                    return _array[Length + index];
                }
                else
                {
                    return _array[index];
                }
            }

            set
            {
                if ((index < -Length) || (index >= Length))
                {
                    throw new ArgumentOutOfRangeException("You went out of array bounds");
                }
                else if (index < 0)
                {
                    _array[Length + index] = value;
                }
                else
                {
                    _array[index] = value;
                }
            }
        }

        public DynamicArray() : this(8) { }

        public DynamicArray(int capacity)
        {
            if (capacity >= 0)
            {
                Capacity = capacity;
                _array = new T[Capacity];
            }

            else
            {
                throw new ArgumentException("Capacity cannot be less than 0");
            }
        }

        public DynamicArray(IEnumerable<T> colection) : this(colection.Count())
        {
            if (colection != null)
            {
                _array = colection.ToArray();
                Length = _array.Length;
            }

            else
            {
                throw new ArgumentNullException("Collection does not exist");
            }
        }

        public void Add(T item)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref _array, Capacity);
            }

            _array[Length] = item;
            Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection != null)
            {

                while (Capacity < Length + collection.Count())
                {
                    Capacity *= 2;
                    Array.Resize(ref _array, Capacity);
                }

                collection.ToArray().CopyTo(_array, Length);
                Length += collection.Count();
            }

            else
            {
                throw new ArgumentNullException("Collection does not exist");
            }
        }

        public bool Remove(T item)
        {
            try
            {
                int index = Array.FindIndex(_array, 0, Length, element => element.Equals(item));

                if (index != -1)
                {
                    Array.Copy(_array, index + 1, _array, index, Length - index - 1);
                    Length--;
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }

        public bool Insert(int index, T item)
        {
            if ((index < 0) || (index > Length))
            {
                throw new ArgumentOutOfRangeException("You went out of array bounds");
            }
            else
            {
                try
                {
                    if (Capacity == Length)
                    {
                        Capacity *= 2;
                        Array.Resize(ref _array, Capacity);
                    }

                    Array.Copy(_array, index, _array, index + 1, Length - index);
                    _array[index] = item;
                    Length++;

                    return true;
                }

                catch
                {
                    return false;
                }
            }
        }

        public T[] ToArray()
        {
            T[] outArray = new T[Length];

            Array.Copy(_array, outArray, Length);

            return outArray;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _array[i];
            }
        }
    }
}
