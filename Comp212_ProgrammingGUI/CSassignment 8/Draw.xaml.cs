using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab8
{
    /// <summary>
    /// Interaction logic for Draw.xaml
    /// </summary>
    public partial class Draw : UserControl
    {
        private double[] pointsDouble = new double[] { 0,0,0,150,30};
        public double[] PointsDouble { get => pointsDouble; set => pointsDouble = value; }

        public Draw()
        {
            InitializeComponent();
           
        }


        public void SetData(double[] array) {
            this.pointsDouble = array;
            
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            
            base.OnRender(drawingContext);
            Pen pen = new Pen(Brushes.Purple, 3);


            double x1 = PointsDouble[0];
            double y1 = PointsDouble[1];

            double y2 = PointsDouble[2];
            double yEx = PointsDouble[3];
            double eF = PointsDouble[4];

            for (float x = 0; x<300; x += 0.2f)
            {
                y2 = Math.Sin(x);
                Point A = new Point(x1 * eF, y1 * eF + yEx);
                Point B = new Point(x * eF, y2 * eF + yEx);
                drawingContext.DrawLine(pen, A,B);

                x1 = x;
                y1 = y2;
            }
        
        }
    }
}
