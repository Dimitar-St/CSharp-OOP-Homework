namespace DefiningClassesPart1
{
    class Display
    {
        // fields
        private string size;
        public int numebrOfColors;

        // constructors

        public Display(string size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        
        // properties
        public string Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.NumberOfColors;
            }

            set
            {
                this.numebrOfColors = value;
            }

        }

        // method


    }
}
