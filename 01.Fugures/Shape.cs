namespace _01.Fugures
{
    public abstract class Shape : IShape
    {
        public Shape(int width, int heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public abstract double CalculateSurface();
    }
}
