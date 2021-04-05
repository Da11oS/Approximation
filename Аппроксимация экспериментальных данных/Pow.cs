using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximation
{
    public class Pow : Approximation
    {
        double A;
        double B;
        public Pow(List<CoordinatePoint> points) : base(points)
        {

        }
        protected override void SetSums()
        {
            foreach (var point in Points)
            {
                var x = Math.Log10(point.x);
                var y = Math.Log10(point.y);
                sumX += x;
                sumXY += x * y;
                sumXX += x * x;
                sumY += y;
            }
        }
        public override void SetA()
        {
            A = sumY * sumXX - sumXY * sumX;
            A /= n * sumXX - sumX * sumX;
            a = Math.Pow(10, A);
        }

        public override void SetB()
        {
            B = n * sumXY - sumY * sumX;
            B /= n * sumXX - sumX * sumX;
            b = B;
        }

        public override double GetPx(double x)
        {
            return a * Math.Pow(x, b);
        }

    }
}
