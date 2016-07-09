namespace GenericClassT
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>  where T : IComparable<T>
    {
        //Implement methods for adding element, accessing element by index, 
        //removing element by index, inserting element at given position, clearing the list
        //, finding element by its value and ToString().
        //Check all input parameters to avoid accessing elements at invalid positions.

        //array and capacity
        private T[] data;
        private int nextIndex = 0;

        public GenericList(int capacity)
        {
            this.data = new T[capacity];
        }

        //indexer
        public T this[int index]
        {
            get 
            {  
                if(index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index]; 
            }
            private set { this.data[index] = value; }
        }

        public void AddElement(T element)
        {
            if (this.nextIndex == this.data.Length)
            {
                this.AutoGrow();
            }

            this.data[nextIndex] = element;
            nextIndex++;
        }

        public void Clear()
        {
            this.data = new T[this.data.Length];
        }

        public void RemoveByIndex(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.nextIndex--;
            this.data[nextIndex] = default(T);
        }

        public void InsertAtIndex(int index, T element)
        {
            if(this.nextIndex == this.data.Length)
            {
                AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = element;
            this.nextIndex++;
        }

        public T Max()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("Generic list is empty");
            }

            T max = this.data[0];

            for (int i = 0; i < this.nextIndex; i++)
            {
                if (max.CompareTo(this.data[i]) < 0)
                {
                    max = this.data[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("Generic list is empty");
            }

            T min = this.data[0];

            foreach (var item in this.data)
            {
                if (min.CompareTo(item) > 0) 
                {
                    min = item;
                }
            }

            return min;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.nextIndex; i++)
            {
                sb.Append(this.data[i]);

                if (i < this.nextIndex - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

    }
}
