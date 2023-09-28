using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail.Entities
{
    public class EntityAdvancedMonorail : EntityMonorail
    {
        public Color AdditiontalWheelsColor { get; private set; }
        public Color AdditiontalTireColor { get; private set; }
        public int AddWheelsNumb { get; private set; }

        public EntityAdvancedMonorail(int speed, double weight, Color bodyColor, Color wheelColor,
            Color tireColor, int addWheelsNumb, Color additionalWheelsColor,
            Color additionalTireColor) : base(speed, weight, bodyColor, wheelColor, tireColor)
        {
            AdditiontalWheelsColor = additionalWheelsColor;
            AdditiontalTireColor = additionalTireColor;
            AddWheelsNumb = addWheelsNumb;
        }

    }
}
