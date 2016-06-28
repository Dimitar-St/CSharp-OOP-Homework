namespace OOPPrinciples_Part2.Shape
{
    using System;

    public class Triangle : Shapes
    {
        public Triangle (int width, int height) : base(width, height)
        {

        }

        public override int CalculateSurface()
        {
            return (base.Width * base.Height) / 2;
        }
    }
}
