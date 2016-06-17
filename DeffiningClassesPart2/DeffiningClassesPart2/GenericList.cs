namespace DeffiningClassesPart2
{
    using System;
    using System.Collections.Generic;

    class GenericList<T> where T : IComparable 
    {
        // fields

        private List<T> elements;
        private int index = 0;

        // constructures

        public GenericList(int capacity)
        {
            this.elements = new List<T>();
        }

        // properties

        public List<T> Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }

        // methods

        public void Add (T element)
        {
            this.Elements[this.index] = element;
            this.index++;
        }

        public T AccessEl (int index)
        {
            return this.Elements[index];
        }

        public void RemoveEl (int index)
        {
            this.Elements.Remove(this.Elements[index]);
        }

        public void InsertEl (int index, T element)
        {
            this.Elements[index] = element;
        }

        public void Clear ()
        {   
            this.Elements.Clear();
        }

        public T Min () 
        {
            T min = this.Elements[0];
            
            foreach (T element in this.Elements)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public T Max ()
        {
            T max = this.Elements[0];

            foreach (T element in this.Elements)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            
            return max;
        }
    }
}
