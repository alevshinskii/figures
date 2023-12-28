namespace FiguresLib.NewFolder
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
