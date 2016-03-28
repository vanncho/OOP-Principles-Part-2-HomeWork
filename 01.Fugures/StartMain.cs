namespace _01.Fugures
{
    using System;
    public class StartMain
    {
        public static void Main(string[] args)
        {
            //var triangle = new Triangle(5, 6);
            //double triangleSurface = triangle.CalculateSurface();
            //Console.WriteLine(triangleSurface);

            //var rectangle = new Rectangle(4, 7);

            //var circle = new Circle(4,4);
            //Console.WriteLine(circle.CalculateSurface());

            IShape[] shapes = {
                                  new Triangle(5, 6),
                                  new Rectangle(4, 7),
                                  new Circle(4,4)
                              };
        }
    }
}
