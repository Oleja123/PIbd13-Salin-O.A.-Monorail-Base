using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail.Entities
{
    public class EntityMonorail
    {
        public int Speed { get; private set; }
        public double Weight { get; private set; }

        public Color BodyColor { get; private set; }

        public Color WheelColor { get; private set; }

        public Color TireColor { get; private set; }

        public double Step => (double)Speed * 100 / Weight;

        public EntityMonorail(int speed, double weight,Color bodyColor, Color wheelColor, Color tireColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            WheelColor = wheelColor;
            TireColor = tireColor;
        }
    }
}
