namespace OOPPrinciples_Part2.Shape
{
    using System;

    public abstract class Shapes
    {
        private int width;
        private int height;

        public Shapes(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public abstract int CalculateSurface();

        
        
    }
}
