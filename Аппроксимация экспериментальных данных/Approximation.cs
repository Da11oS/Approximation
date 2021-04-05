using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximation
{
    public abstract class Approximation
    {
        public double a;
        public double b;
        public List<CoordinatePoint> ApproximationPoints;

        protected double sumXY;
        protected double sumX;
        protected double sumY;
        protected double sumXX;
        
        protected List<CoordinatePoint> Points;
        protected int n => Points.Count;

        public Approximation(List<CoordinatePoint> points)
        {
            ApproximationPoints = new List<CoordinatePoint>();
            Points = points;
            SetSums();
            SetA();
            SetB();
        }
        public abstract void SetA();
        protected abstract void SetSums();
        public abstract void SetB();
        public abstract double GetPx(double x);
        public double GetDeviation()
        {
            double deviation = 0;
            foreach(var point in Points)
            {
                deviation += Math.Pow(point.y - GetPx(point.x), 2);
            }
            return deviation;
        }
    }
    public struct CoordinatePoint
    {
        public double x;
        public double y;
        public CoordinatePoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
    }
}
