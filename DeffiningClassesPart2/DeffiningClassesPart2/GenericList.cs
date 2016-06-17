namespace DeffiningClassesPart2
{
    using System.Collections.Generic;

    class GenericList<T> 
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
            //this.Elements
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
            
            for (int i = 0; i < this.Elements.Count - 1; i++)
            {
                if (min > this.Elements[i + 1])
                {

                }
            }

            return min;
        }
    }
}
