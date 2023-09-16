using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    public class EntityMonorail
    {
        public int Speed { get; private set; }
        public double Weight { get; private set; }

        public Color BodyColor { get; private set; }

        public int WheelsNumb { get; private set; }

        public Color WheelColor { get; private set; }

        public Color TireColor { get; private set; }

        public double Step => (double)Speed * 100 / Weight;

        public void Init(int speed, double weight,Color bodyColor, int wheelsNumb, Color wheelColor, Color tireColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            if (!(wheelsNumb >= 2 && wheelsNumb <= 4))
                wheelsNumb = 2;
            WheelsNumb = wheelsNumb;
            WheelColor = wheelColor;
            TireColor = tireColor;
        }
    }
}
