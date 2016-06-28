namespace OOPPrinciples_Part2.Shape
{
    using System;

    public class Square : Shapes
    {
        public Square(int width, int height) : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("The two parameters have to be equal");
            }
        } 

        public override int CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
