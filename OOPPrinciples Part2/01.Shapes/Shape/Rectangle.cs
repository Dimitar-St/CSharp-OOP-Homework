namespace OOPPrinciples_Part2.Shape
{
    using System;

    public class Rectangle : Shapes
    {
        public Rectangle (int width, int height) : base(width, height)
        {

        }

        public override int CalculateSurface()
        {
            return base.Width * base.Height;
        }

    }
}
