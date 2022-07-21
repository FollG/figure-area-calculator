using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcSquare
{
    public class Triangle : Shape
    {
        public double Ab { get; private set; }
        public double Bc { get; private set; }
        public double Ca { get; private set; }

        public Triangle(double AB, double BC, double CA)
        {
            if (AB <= 0 || BC <= 0 || CA <= 0)
            {
                throw new Exception("side cannot be lower or equal than zero");
            }
            else if (AB > (BC + CA) || BC > (AB + CA) || CA > (AB + BC))
            {
                throw new Exception("one side cannot be large than sum two other sides");
            }

            Ab = AB;
            Bc = BC;
            Ca = CA;
        }

        public bool IsRectangular()
        {
            bool Rectangularity = (Ab == Math.Sqrt(Math.Pow(Bc, 2) + Math.Pow(Ca, 2))
                                || Bc == Math.Sqrt(Math.Pow(Ab, 2) + Math.Pow(Ca, 2))
                                || Ca == Math.Sqrt(Math.Pow(Ab, 2) + Math.Pow(Bc, 2)));

            return Rectangularity;
        }
            
        public override double Calc()
        {
            double PI = (Ab + Bc + Ca) / 2;
            double answer = Math.Round(Math.Sqrt(PI * (PI - Ab) * (PI - Bc) * (PI - Ca)), 2);

            return answer;
        }
    }
}
