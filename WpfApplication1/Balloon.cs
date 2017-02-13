using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;

        Ellipse ellipse = new Ellipse();

        Label label = new Label();
        private Canvas canvas;
        private object rndGen;

        void UpdateLabel(Canvas canvas)
        {
            /*label.Content = "Happy Birthday";
            label.Margin = ellipse.Margin;
            canvas.Children.Add(label);*/
        }      
        

        public Balloon(Canvas canvas,Random rndGen)
        {
            diameter = rndGen.Next(10, 30);
            x = rndGen.Next(10, 300);
            y = rndGen.Next(10, 300);
            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, Random rndGen)
        {
            this.diameter = diameter;
            x = rndGen.Next(10, 300);
            y =  rndGen.Next(10, 200);

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int height, int xpos)
        {
            this.diameter = diameter;
            x = xpos;
            y = height;

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int x)
        {
            this.canvas = canvas;
            this.x = x;
        }

        public Balloon(Canvas canvas, object rndGen)
        {
            this.canvas = canvas;
            this.rndGen = rndGen;
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Brown);
            ellipse.Fill = new SolidColorBrush(Colors.Brown);
            canvas.Children.Add(ellipse);
            this.canvas = canvas;
            UpdateLabel(canvas);
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            UpdateLabel(canvas);
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            UpdateLabel(canvas);
        }

    }
}
