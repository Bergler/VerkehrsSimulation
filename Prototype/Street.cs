using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Prototype
{
    class Street
    {
        private Rectangle rect;
        private double x1, y1, x2, y2;
        private char heading;
        private int speedlimit;
        List<Car> cars;
        private Canvas canvas;

        private Street nextelem;
        private Street prevelem;

        public Street(double x1, double y1, double x2,double y2,Canvas canv)
        {
            canvas = canv;
            rect = new Rectangle();
            rect.Height = 100;
            rect.Width = 500;
            rect.Fill = new SolidColorBrush(Colors.Gray);
            canv.Children.Add(rect);
            Canvas.SetLeft(rect, 0);
            Canvas.SetTop(rect, 150);
            cars = new List<Car>();
    
        }

        public void updateAll()
        {
            foreach(Car car in cars)
            {
                car.moveNext();
            }
        }

        public void addCar(int speed)
        {
            cars.Add(new Car(canvas,speed));
        }


    }
}
