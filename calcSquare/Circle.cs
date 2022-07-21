using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcSquare
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double Radius)
        {
            if (Radius <= 0)
            {
                throw new Exception("side cannot be lower or equal than zero");
            }
            this.Radius = Radius;
        }

        public override double Calc()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
