using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monorail.Entities;

namespace Monorail.DrawningObjects
{
    public class DrawningAdvancedMonorail : DrawningMonorail
    {
        public DrawningAdvancedMonorail(int speed, double weight, Color bodyColor, Color wheelColor, Color tireColor, int width, int height, int addWheelsNumb, 
            Color additionalWheelsColor, Color additionalTireColor) : base(speed, weight, bodyColor, wheelColor, tireColor, width, height)
        {
            if(EntityMonorail != null)
            {
                EntityMonorail = new EntityAdvancedMonorail(speed, weight, bodyColor, wheelColor, tireColor,
                    addWheelsNumb, additionalWheelsColor, additionalTireColor);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            if (EntityMonorail == null)
                return;
            base.DrawTransport(g);
            if(EntityMonorail is not EntityAdvancedMonorail advancedMonorail)
            {
                return;
            }
            Pen additionalPen = new(advancedMonorail.AdditiontalTireColor);
            Brush additionalBrush = new SolidBrush(advancedMonorail.AdditiontalWheelsColor);

            //3 колеса
            if (advancedMonorail.AddWheelsNumb >= 3)
            {
                g.FillEllipse(additionalBrush, _startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(additionalPen, _startPosX + _monoRailWidth / 10 * 6, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
            }

            //4 колеса

            if (advancedMonorail.AddWheelsNumb >= 4)
            {
                g.FillEllipse(additionalBrush, _startPosX + _monoRailWidth / 10 * 3, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
                g.DrawEllipse(additionalPen, _startPosX + _monoRailWidth / 10 * 3, _startPosY + _monoRailHeight / 10 * 7, wheelSz, wheelSz);
            }
        }
    }

}
