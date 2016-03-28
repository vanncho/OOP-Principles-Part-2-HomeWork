﻿namespace _01.Fugures
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
