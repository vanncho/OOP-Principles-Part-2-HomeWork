namespace _01.Fugures
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
