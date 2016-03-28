namespace _01.Fugures
{
    using System;

    public class Circle : Shape
    {
        public Circle(int width, int height)
            : base(width, height)
        {
            if (this.Height != this.Width ||
                this.Width != this.Height)
            {
                throw new CircleSurfaceDimenssionsExeption("Circle width and height must be equal");
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Height;
        }
    }
}
