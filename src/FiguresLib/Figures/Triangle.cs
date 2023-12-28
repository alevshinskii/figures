namespace FiguresLib.Figures
{
    public class Triangle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRight
        {
            get
            {
                return SideA * SideA + SideB * SideB == SideC * SideC ||
                       SideA * SideA + SideC * SideC == SideB * SideB ||
                       SideB * SideB + SideC * SideC == SideA * SideA;
            }
        }
    }
}
