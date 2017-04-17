using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Prototype
{
    class Car
    {
        private Rectangle car;
        private int speed;
        private double x, y;


        public Car(Canvas canv, int _speed)
        {
            speed = _speed;
            car = new Rectangle();
            car.Height = 40;
            car.Width = 50;
            car.Fill = new SolidColorBrush(Colors.Black);
            canv.Children.Add(car);
            Canvas.SetTop(car, 160);
            Canvas.SetLeft(car, 0);
        }

        public void moveNext()
        {
            Canvas.SetLeft(car, Canvas.GetLeft(car)+speed);
        }


    }
}
