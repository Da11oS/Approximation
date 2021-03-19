using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Approximation
{
    public abstract class Approximation
    {
        public double a;
        public double b;
        protected double sumXY;
        protected double sumX;
        protected double sumY;
        protected double sumXX;
        protected List<CoordinatePoint> Points;
        protected int n => Points.Count;
        public Approximation(List<CoordinatePoint> points)
        {
            Points = points;
            SetSums();
            SetA();
            SetB();

        }
        public abstract void SetA();
        protected abstract void SetSums();
        public abstract void SetB();
        public abstract double GetPx(double x);
        
    }
    public class Line : Approximation
    {
        public Line(List<CoordinatePoint> points) :base(points)
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

    public class Exp : Approximation
    {
        public Exp(List<CoordinatePoint> points) : base(points)
        {

        }
        protected override void SetSums()
        {
            foreach (var point in Points)
            {
                var x = point.x;
                var y = Math.Log(point.y);
                sumX += x;
                sumXY += x * y;
                sumXX += x * x;
                sumY += y;
            }
        }
        public override void SetA()
        {
            double A;
            A = sumY * sumXX - sumXY * sumX;
            A /= n * sumXX - sumX * sumX;
            a = Math.Exp(A);
        }
        public override void SetB()
        {
            double B;
            B = n * sumXY - sumY * sumX;
            B /= n * sumXX - sumX * sumX;
            b = B;
        }
        public override double GetPx(double x)
        {
            return a * Math.Exp(b * x);
        }
    }

    public class Poly : Approximation
    {
        int K;
        public List<double> Factors;
        public double[,] S;
        public List<double> FreeMembers;
        public Poly(List<CoordinatePoint> points, int factorsCount) : base(points)
        {
            SetSum();
            SetDiagonal();
            K = factorsCount;
            for (int i = K - 1; i >= 0; i--)
            {
                double s = 0;
                for (int j = i; j < K; j++)
                {
                    MessageBox.Show($"K{K}: {i}, {j} ");
                    s = s + S[i, j] * Factors[j];
                }
                Factors[i] = (Factors[i] - s) / S[i, i];
            }
          
        }

        private void SetSum()
        {

            S = new double[K, K];
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    S[i, j] = 0;
                        MessageBox.Show("|" + i + " " + j);
                    for (int k = 0; k < n; k++)
                    {
                        S[i, j] += Math.Pow(Points[k].x, i + j);
                    }
                }
            }
            for (int i = 0; i < K; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    FreeMembers[i] += Math.Pow(Points[k].x, i) * Points[k].y;
                }
            }
        }
        void SetDiagonal()
        {
            double temp = 0;
            for (int i = 0; i < K; i++)
            {
                if (S[i,i] == 0)
                {
                    for (int j = 0; j < K; j++)
                    {
                        if (j == i) continue;
                        if (S[j,i] != 0 && S[i,j] != 0)
                        {
                            for (int k = 0; k < K; k++)
                            {
                                temp = S[j,k];
                                S[j,k] = S[i,k];
                                S[i,k] = temp;
                            }
                            temp = FreeMembers[j];
                            FreeMembers[j] = FreeMembers[i];
                            FreeMembers[i] = temp;
                            break;
                        }
                    }
                }
            }

        }
        protected override void SetSums()
        {

        }
        public override void SetA()
        {
   
        }
        public override void SetB()
        {
        }
        public override double GetPx(double x)
        {
        
            double p = 0;
 
            for (var i = 0; i < Factors.Count; i++)
            {
                System.Windows.Forms.MessageBox.Show("IsSetP" + i + " = " + p);
                p += Factors[i] * Math.Pow(x, i);
            }
            System.Windows.Forms.MessageBox.Show("IsSetPX = " + p);
            return p;
        }
    }
    public class Poly2: Approximation
    {
        public new double[] a = new double[3];
        public double[] S = new double[8];
        public double[] det = new double[3];
        public double mainDet;
        public Poly2(List<CoordinatePoint> points) : base(points)
        {

        }
        protected override void SetSums()
        {
            for(int i = 0; i <= 4; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    S[i] += Math.Pow(Points[j].x, i);
                }
            }
            for(int j = 0; j < n; j++)
            {
                S[5] += Points[j].y;
                S[6] += Points[j].y * Points[j].x;
                S[7] += Points[j].y * Points[j].x * Points[j].x;
            }

        }
        public override void SetA()
        {
            mainDet = Get3Det(new double[,] {
                { n, S[1], S[2] },
                { S[1], S[2], S[3] },
                { S[2], S[3], S[4] },
            });
            det[0] = Get3Det(new double[,] {
                { S[5], S[1], S[2] },
                { S[6], S[2], S[3] },
                { S[7], S[3], S[4] },
            });
            det[1] = Get3Det(new double[,] {
                { n, S[5], S[2] },
                { S[1], S[6], S[3] },
                { S[2], S[7], S[4] },
            });
            det[2] = Get3Det(new double[,] {
                { n, S[1], S[5] },
                { S[1], S[2], S[6] },
                { S[2], S[3], S[7] },
            });
        }
        public override void SetB()
        {
            for(int i = 0; i < 3; i++)
            {
                a[i] = det[i] / mainDet;
            }
        }
        public override double GetPx(double x)
        {
            return a[0] + a[1] * x + a[2] * x * x;
        }
        private double Get3Det(double[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
                return 0;
            var main = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                matrix[0, 2] * matrix[1, 0] * matrix[2, 1];
            var main1 = matrix[0, 2] * matrix[1, 1] * matrix[2, 0] +
                matrix[0, 1] * matrix[1, 0] * matrix[2, 2] +
                matrix[0, 0] * matrix[1, 2] * matrix[2, 1];
            return main - main1;
        }
    }

    public class Pow : Approximation
    {
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
            double A = sumY * sumXX - sumXY * sumX;
            A /= n * sumXX - sumX * sumX;
            a = Math.Pow(10,A);
        }

        public override void SetB()
        { 
            double B = n * sumXY - sumY * sumX;
            B /= n * sumXX - sumX * sumX;
            b = B;
        }

        public override double GetPx(double x)
        {
            return a * Math.Pow(x, b);
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
