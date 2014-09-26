namespace GenericList
{
    using System;
    using System.Linq;
    using System.Text;

    [VersionAttribute("1.11")]
    public class GenericList<T>
    {
        private T[] myList;
        private uint count = 0;
        private uint length = 16;

        public GenericList()
        {
            this.myList = new T[length];
        }

        public GenericList(uint initialCapacity)
        {
            this.length = initialCapacity;
            this.myList = new T[length];
        }

        public uint Length
        {
            get
            {
                return this.length;
            }
        }

        public uint Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[uint index]
        {
            get
            {
                if (index < Count)
                {
                    return myList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Outside the list boundaries!");
                }
            }
        }

        public void Add(T member)
        {
            if (!(Count < length - 1))
            {
                Grow();
            }

            this.myList[count] = member;
            count++;
        }

        public void RemoveAtPosition(uint index)
        {
            if (index < Count)
            {
                for (uint i = index; i < Count - 1; i++)
                {
                    this.myList[i] = this.myList[i + 1];
                }

                count--;
                this.myList[Count] = default(T);
            }
            else
            {
                throw new IndexOutOfRangeException("You try to remove element  outside the boundaries of the GenericList!");
            }
        }

        public void Insert(uint index, T item)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException();
            }

            if (count == length)
            {
                Grow();
            }

            Array.Copy(this.myList, index, this.myList, index + 1, this.count - index);
            this.myList[index] = item;
            count++;
        }

        public void Grow() //   auto-grow functionality     <--------|
        {
            T[] newArray = new T[2 * this.length];
            Array.Copy(this.myList, newArray, count);
            this.myList = newArray;
            this.length = length * 2;
        }

        public void Clear()
        {
            if (this.count > 0)
            {
                Array.Clear(this.myList, 0, (int)this.count);
                this.count = 0;
            }
        }

        public bool Contain(T value)
        {
            return this.myList.Contains(value);
        }

        public int Find(Predicate<T> match)
        {
            int position = 0;

            while (position < count - 1)
            {
                if (!match(this.myList[position]))
                {
                    position++;
                }
                else
                {
                    return position;
                }
            }

            return -1;
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            if (this.count == 0)
            {
                return default(T);
            }
            else
            {
                var min = this.myList[0];

                for (int i = 0; i < this.count; i++)
                {
                    T item = (dynamic)this.myList[i];
                    if (item.CompareTo(min) < 0)
                    {
                        min = this.myList[i];
                    }
                }

                return (dynamic)min;
            }
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            if (this.count == 0)
            {
                return default(T);
            }
            else
            {
                var max = this.myList[0];

                for (int i = 1; i < this.count; i++)
                {
                    T item = (dynamic)this.myList[i];
                    if (item.CompareTo(max) > 0)
                    {
                        max = this.myList[i];
                    }
                }
                return (dynamic)max;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(String.Format("{0}", this.myList[i].ToString()));

                if (i == this.count - 1)
                {
                    return result.ToString();
                }
                result.Append(", ");
            }
            return result.ToString();
        }
    }
}
