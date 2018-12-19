using System;
using System.Drawing;
using System.Linq;
using MathNet.Spatial.Euclidean;
using MathNet.Spatial.Units;

namespace LoveCalculatorLogic
{
    public class LoveCalculator
    {
        public bool CalculateLove(string first, string second)
        {
            Point2D firstPoint = Calculate2DPoint(first);
            Point2D secondPoint = Calculate2DPoint(second);

            var line2D = new Line2D(firstPoint, secondPoint);
            Angle angleTo = line2D.Direction.AngleTo(new Vector2D(100, 0));
            return angleTo.Degrees < 140 && angleTo.Degrees > 40;
        }

        private Point2D Calculate2DPoint(string first)
        {
            int sum1 = first.ToCharArray().Where((c, i) => i % 2 == 0).Sum(c => c.GetHashCode()) / first.Length / 2;
            int sum2 = first.ToCharArray().Where((c, i) => i % 2 == 1).Sum(c => c.GetHashCode()) / first.Length / 2;

            return new Point2D(sum1, sum2);
        }
    }
}
