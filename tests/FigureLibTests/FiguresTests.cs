using FiguresLib;
using FiguresLib.Figures;
using FluentAssertions;

namespace FigureLibTests
{
    public class FiguresTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCircle()
        {
            Figure circle = new Circle(10);

            circle.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToCreateTriangle()
        {
            Figure triangle = new Triangle(10, 10, 10);

            triangle.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToFiguresAreas()
        {
            var figures = new Figure[]
            {
                new Circle(10),
                new Triangle(10, 10, 10)
            };

            var areas = figures.Select(f => f.Area());

            areas.Should().BeEquivalentTo(new List<double> { 314.1592653589793, 43.30127018922193 });
        }

        [Fact]
        public void ShouldBeAbleToCheckIsTriangleRight()
        {
            var rightTriangles = new Figure[]
            {
                new Triangle(3, 4, 5),
                new Triangle(6, 8, 10),
                new Triangle(5, 12, 13),
            };


            foreach (var figure in rightTriangles)
            {
                if (figure is Triangle triangle)
                {
                    triangle.IsRight.Should().BeTrue();
                }
            }
        }

        [Fact]
        public void ShouldBeAbleToCheckIsTriangleNotRight()
        {
            var notRightTriangles = new Figure[]
            {
                new Triangle(1, 2, 333),
                new Triangle(111, 2, 3),
                new Triangle(1, 222, 3),
            };


            foreach (var figure in notRightTriangles)
            {
                if (figure is Triangle triangle)
                {
                    triangle.IsRight.Should().BeFalse();
                }
            }
        }
    }
}