namespace _01.Fugures
{
    public interface IShape
    {
        int Width { get; set; }

        int Height { get; set; }

        double CalculateSurface();
    }
}
