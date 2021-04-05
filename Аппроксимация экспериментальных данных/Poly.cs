using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximation
{
    public class Poly2 : Approximation
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
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    S[i] += Math.Pow(Points[j].x, i);
                }
            }
            for (int j = 0; j < n; j++)
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
            for (int i = 0; i < 3; i++)
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
}
