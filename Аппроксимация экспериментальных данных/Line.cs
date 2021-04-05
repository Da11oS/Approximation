using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximation
{
    public class Line : Approximation
    {
        public Line(List<CoordinatePoint> points) : base(points)
        {

        }
        protected override void SetSums()
        {
            foreach (var point in Points)
            {
                var x = point.x;
                var y = point.y;
                sumX += x;
                sumXY += x * y;
                sumXX += x * x;
                sumY += y;
            }
        }
        public override void SetA()
        {
            a = (n * sumXY - sumX * sumY) / (n * sumXX - sumX * sumX);

        }
        public override void SetB()
        {
            SetA();
            b = sumY - a * sumX;
            b /= n;
        }
        public override double GetPx(double x)
        {
            return a * x + b;
        }
    }
}
