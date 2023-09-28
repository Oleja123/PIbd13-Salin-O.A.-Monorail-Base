using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail.MovementStrategy
{
    public class MoveToCenter : AbstractStrategy
    {
        protected override bool IsTargetDestinaion()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.ObjectMiddleHorizontal <= FieldWidth / 2 &&
            objParams.ObjectMiddleHorizontal + GetStep() >= FieldWidth / 2 &&
            objParams.ObjectMiddleVertical <= FieldHeight / 2 &&
            objParams.ObjectMiddleVertical + GetStep() >= FieldHeight / 2;
        }

        protected override void MoveToTarget()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }
            var diffX = objParams.ObjectMiddleHorizontal - FieldWidth / 2;
            if (Math.Abs(diffX) > GetStep())
            {
                if (diffX > 0)
                {
                    MoveLeft();
                }
                else
                {
                    MoveRight();
                }
            }
            var diffY = objParams.ObjectMiddleVertical - FieldHeight / 2;
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY > 0)
                {
                    MoveUp();
                }
                else
                {
                    MoveDown();
                }
            }
        }

    }
}
