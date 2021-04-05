using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Approximation;

namespace Аппроксимация_экспериментальных_данных
{
    public partial class Form1 : Form
    {
        public Action SetChart;
        public List<CoordinatePoint> Points = new List<CoordinatePoint>();
        public List<CoordinatePoint> RegresPoints = new List<CoordinatePoint>();
        public double step;
        public Form1()
        {

            InitializeComponent();
            step = 1;
            SetChart += SetPoints;
            SetChart += SetChartPoints;

        }
        private void PoliCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PoliCheck.Checked)
            {
                SetChart += SetPolyApproximation;
                
            }
            else SetChart -= SetPolyApproximation;
        }

        private void ExpCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(ExpCheck.Checked)
            {
                SetChart += SetExpApproximation;
            }
            else SetChart -= SetExpApproximation;

    }

        private void PowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PowCheck.Checked)
            {
                SetChart += SetPowApproximation;
            }
            else SetChart -= SetPowApproximation;
        }

        private void LineCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LineCheck.Checked)
            {
               
                SetChart += SetLineApproximation;
            }
            else SetChart -= SetLineApproximation;
        }

        public void SetPowApproximation()
        {
            Pow pow = new Pow(Points);
            PowALabel.Text = pow.a.ToString();
            PowBLable.Text = pow.b.ToString();
            chart1.Series[1].BorderWidth = 2;
            for (int i = 0; i < Points.Count; i++)
            {
                pow.ApproximationPoints.Add(new CoordinatePoint(Points[i].x, pow.GetPx(Points[i].x)));
                var currentPoint = pow.ApproximationPoints[i];
                chart1.Series[1].Points.AddXY(currentPoint.x, currentPoint.y);
            }
            powDeviation.Text = pow.GetDeviation().ToString();
        }
        public void SetLineApproximation()
        {
       
            Line pow = new Line(Points);
            LineALabel.Text = pow.a.ToString();
            LineBLabel.Text = pow.b.ToString();
            chart1.Series[2].BorderWidth = 2;
            for (int i = 0; i < Points.Count; i++)
            {
                var currentPoint = new CoordinatePoint(Points[i].x, pow.GetPx(Points[i].x));
                pow.ApproximationPoints.Add(currentPoint);
                chart1.Series[2].Points.AddXY(currentPoint.x, currentPoint.y);
            }
           lineDeviation.Text = pow.GetDeviation().ToString();
        }
        public void SetExpApproximation()
        {
            MessageBox.Show("Exp");
            Exp pow = new Exp(Points);
            ExpALabel.Text = pow.a.ToString();
            ExpBLabel.Text = pow.b.ToString();
            chart1.Series[3].BorderWidth = 2;
            for (int i = 0; i < Points.Count; i++)
            {
                pow.ApproximationPoints.Add(new CoordinatePoint(Points[i].x, pow.GetPx(Points[i].x)));
                var currentPoint = pow.ApproximationPoints[i];
                chart1.Series[3].Points.AddXY(currentPoint.x, currentPoint.y);
            }
            expDeviation.Text = pow.GetDeviation().ToString();
        }
        public void SetPolyApproximation()
        {
            Poly2 pow = new Poly2(Points);
            MessageBox.Show("Was createdd Poly");
            PolyALabel.Text = pow.a[2].ToString();
            PolyBLabel.Text = pow.a[1].ToString();
            PolyCLabel.Text = pow.a[0].ToString();
            chart1.Series[4].BorderWidth = 2;
            for (int i = 0; i < Points.Count; i++)
            {
                pow.ApproximationPoints.Add(new CoordinatePoint(Points[i].x, pow.GetPx(Points[i].x)));
                var currentPoint = pow.ApproximationPoints[i];
                chart1.Series[4].Points.AddXY(currentPoint.x, currentPoint.y);
            }
            polyDeviation.Text = pow.GetDeviation().ToString();
        }
        public void SetPoints()
        {

            Points = new List<CoordinatePoint>();

            for (int i =0; i < PointsTable.Rows.Count - 1; i++)
            {
                var x = double.Parse(PointsTable.Rows[i].Cells[0].Value.ToString().Replace('.', ','));
                var y = double.Parse(PointsTable.Rows[i].Cells[1].Value.ToString().Replace('.', ','));
                Points.Add(new CoordinatePoint(x, y));
            }
        }
        public void SetChartPoints()
        {
            chart1.Series[0].BorderWidth = 5;
            foreach (var point in Points)
            {
                chart1.Series[0].Points.AddXY(point.x, point.y);
            }
        }

        private void SetChartButton_Click_1(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            SetPoints();

            SetChart?.Invoke();

            foreach (var area in chart1.ChartAreas)
            {
                area.AxisX.Minimum = Points[0].x - 1;
                area.AxisX.Maximum = Points[Points.Count - 1].x + 1;
                area.AxisY.Minimum = Points[0].y - 1;
                area.AxisY.Maximum = Points[Points.Count - 1].y + 1;
            }
        }
    }


}
